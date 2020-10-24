using BPUtil;
using BPUtil.PasswordReset;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikvisionThermalDpcClear
{
	public partial class MainForm : Form
	{
		int x, y, w, h, port, nativeWidth, nativeHeight;
		string host, user, pass;
		int current_X, current_Y;
		int completed;
		WebRequestUtility wru;
		public MainForm()
		{
			InitializeComponent();
			nudDimValueChanged(null, null);
		}

		#region GUI crap
		private void nudDimValueChanged(object sender, EventArgs e)
		{
			x = (int)nudLeft.Value;
			y = (int)nudTop.Value;
			w = (int)nudWidth.Value;
			h = (int)nudHeight.Value;
			port = (int)nudPort.Value;
			host = txtCamIP.Text;
			user = txtUser.Text;
			pass = txtPass.Text;
			nativeWidth = (int)nudNativeWidth.Value;
			nativeHeight = (int)nudNativeHeight.Value;

			current_X = nativeWidth / 2;
			current_Y = nativeHeight / 2;

			UpdateLabelText();
		}

		private void UpdateLabelText()
		{
			lblDescription.Text = "Click Proceed to clear pixels in a " + w + "x" + h + " rectangle where the upper left corner is at [" + x + ", " + y + "]. Total pixels to clear: " + (w * h);
		}

		private void cbShowPW_CheckedChanged(object sender, EventArgs e)
		{
			if (cbShowPW.Checked)
				txtPass.PasswordChar = (char)0;
			else
				txtPass.PasswordChar = '*';
		}

		BackgroundWorker bw;
		UTF8Encoding utf8 = new UTF8Encoding(false);
		private void btnProceed_Click(object sender, EventArgs e)
		{
			if (bw == null)
			{
				completed = 0;
				lblCompleted.Text = "0";
				lblTotal.Text = (w * h).ToString();
				lblPosition.Text = current_X + ", " + current_Y;
				lblStatus.Text = "Running";

				wru = new WebRequestUtility("Defective Pixel Correction Utility");
				wru.BasicAuthCredentials = new System.Net.NetworkCredential(user, pass);

				bw = new BackgroundWorker();
				bw.WorkerReportsProgress = true;
				bw.WorkerSupportsCancellation = true;
				bw.DoWork += Bw_DoWork;
				bw.ProgressChanged += Bw_ProgressChanged;
				bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
				bw.RunWorkerAsync();

				foreach (Control c in Controls)
				{
					if (c is Button || c is NumericUpDown || c is TextBox)
						c.Enabled = false;
				}
			}
		}
		#endregion


		private void Bw_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				SendCommand("start");
				try
				{
					// Move to known point [0,0]
					MoveCrosshair(-(current_X + 10), -(current_Y + 10));

					if (current_X != 0 || current_Y != 0)
						throw new ApplicationException("Application logic error: moving to [0,0] failed.");

					int limit_left = x;
					int limit_right = x + w;
					int limit_top = y;
					int limit_bottom = y + h;

					MoveCrosshair(limit_left, limit_top);

					for (int iy = 0; iy < h; iy++)
					{
						if (iy > 0)
							MoveCrosshair(0, 1);

						if (current_Y != y + iy)
							throw new ApplicationException("Application logic error: current_Y != y + iy.");

						if (iy % 2 == 0)
						{
							if (current_X != limit_left)
								throw new ApplicationException("Application logic error: current_X != limit_left.");

							ClearPixel();
							while (current_X < limit_right - 1)
							{
								MoveCrosshair(1, 0);
								ClearPixel();
							}
						}
						else
						{
							if (current_X != limit_right - 1)
								throw new ApplicationException("Application logic error: current_X != limit_right.");

							ClearPixel();
							while (current_X > limit_left)
							{
								MoveCrosshair(-1, 0);
								ClearPixel();
							}
						}
						SendCommand("save");
					}
				}
				finally
				{
					SendCommand("save");
					SendCommand("exit");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		Stopwatch sw = Stopwatch.StartNew();
		private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (sw.ElapsedMilliseconds > 33)
				sw.Restart();
			else
				return;
			if (e.UserState is Status)
			{
				Status status = e.UserState as Status;
				string str_completed = status.completed.ToString();
				string str_pos = status.current_X + ", " + status.current_Y;
				if (lblCompleted.Text != str_completed)
					lblCompleted.Text = str_completed;
				if (lblPosition.Text != str_pos)
					lblPosition.Text = str_pos;
			}
		}
		private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lblStatus.Text = "Finished";
			foreach (Control c in Controls)
			{
				if (c is Button || c is NumericUpDown || c is TextBox)
					c.Enabled = true;
			}
			nudDimValueChanged(null, null);
			bw = null;
		}

		#region Hikvision ISAPI API
		private void ClearPixel()
		{
			SendCommand("cancelCorrect");
			completed++;
			bw.ReportProgress(0, new Status(current_X, current_Y, completed));
		}
		private void MoveCrosshair(int offsetX, int offsetY)
		{
			while (offsetX > 0)
			{
				offsetX--;
				SendCommand("moveright");
				current_X++;
				if (current_X > nativeWidth - 1)
					current_X = nativeWidth - 1;
				bw.ReportProgress(0, new Status(current_X, current_Y, completed));
			}
			while (offsetX < 0)
			{
				offsetX++;
				SendCommand("moveleft");
				current_X--;
				if (current_X < 0)
					current_X = 0;
				bw.ReportProgress(0, new Status(current_X, current_Y, completed));
			}
			while (offsetY > 0)
			{
				offsetY--;
				SendCommand("movedown");
				current_Y++;
				if (current_Y > nativeHeight - 1)
					current_Y = nativeHeight - 1;
				bw.ReportProgress(0, new Status(current_X, current_Y, completed));
			}
			while (offsetY < 0)
			{
				offsetY++;
				SendCommand("moveup");
				current_Y--;
				if (current_Y < 0)
					current_Y = 0;
				bw.ReportProgress(0, new Status(current_X, current_Y, completed));
			}
		}
		/// <summary>
		/// Executes the specified command and returns true if successful.
		/// </summary>
		/// <param name="command">XML command "mode" text</param>
		/// <param name="tries">0 for the first try. +1 each time it is retried.</param>
		/// <returns></returns>
		private void SendCommand(string command, int tries = 0)
		{
			// Example capabilities response:
			/*
				<DPC version="2.0">
					<dpcMode opt="manual" def="manual"/>
					<mode opt="correction,moveup,movedown,moveleft,moveright,cancelCorrect"/>
				</DPC>
			 */

			// Example command response:
			/*
				<?xml version="1.0" encoding="UTF-8"?>
				<ResponseStatus version="2.0" xmlns="http://www.hikvision.com/ver20/XMLSchema">
				<requestURL>/ISAPI/Image/channels/2/DPC/correction</requestURL>
				<statusCode>1</statusCode>
				<statusString>OK</statusString>
				<subStatusCode>ok</subStatusCode>
				</ResponseStatus>

			 */

			if (tries > 0)
				throw new ApplicationException("Unable to send command after 5 tries: " + command);

			byte[] body = utf8.GetBytes("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<DPC><mode>" + command + "</mode><dpcMode>manual</dpcMode></DPC>");

			BpWebResponse response = wru.PUT("http://" + host + ":" + port + "/ISAPI/Image/channels/2/DPC/correction", body, "application/x-www-form-urlencoded; charset=UTF-8");

			if (response.StatusCode == 0)
			{
				Thread.Sleep(1000);
				SendCommand(command, tries + 1);
			}
			else if (response.StatusCode == 200)
			{
				if (!response.str.Contains("<statusCode>1</statusCode>"))
					throw new ApplicationException("Unexpected response from command " + command + ": " + response.str);
			}
			else if (response.StatusCode == 401)
			{
				throw new ApplicationException("Camera refused your user name and password");
			}
			else
				throw new ApplicationException("Unexpected status code " + response.StatusCode + " after sending command " + command);
		}
		#endregion
	}

	internal class Status
	{
		public int current_X;
		public int current_Y;
		public int completed;

		public Status(int current_X, int current_Y, int completed)
		{
			this.current_X = current_X;
			this.current_Y = current_Y;
			this.completed = completed;
		}
	}
}
