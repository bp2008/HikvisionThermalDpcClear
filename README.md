# HikvisionThermalDpcClear
A utility that assists in clearing all defective pixel markings on a Hikvision Thermal-Optical camera.

![Screenshot](https://i.imgur.com/jio2XV1.png)

## Purpose

I played with the DPC ("Defective Pixel Correction") feature on my Hikvision Thermal camera, and then discovered there was no convenient way to locate and unmark the pixels I had marked as defective.  So I built this tool that can scan across a rectangular region of the thermal sensor and unmark every pixel along the way.  It can clear the entire 160x120 sensor in a matter of minutes.

While this tool cleaned up my mess, it also uncovered several actually-defective pixels that had been marked as defective by the factory.

![dead pixels](https://i.imgur.com/EKdENbk.jpg)

So I proceeded to clean them up...

![some dead pixels marked](https://i.imgur.com/IpGyyIT.png)

![all dead pixels marked](https://i.imgur.com/nsEDeMc.png)

Good as new!
