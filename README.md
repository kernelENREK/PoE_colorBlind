# Path of Exile colorblind tool

This is a QoL (quality-of-life) tool for colorblind Path of Exile (PoE) players.

# Colorblind thread on Path of Exile forum: https://www.pathofexile.com/forum/view-thread/2050144

![Alt text](https://github.com/kernelENREK/PoE_colorBlind/blob/master/readme_gif1.gif "Sample")

# Settings:

In the first run it shows you the options. By default the options are configured for a 1920 x 1080 screen resolution to display overlay on Currecny tab. So, if you are using 1920 x 1080 Path of Exile screen resolution and have a currency tab, don't need to 'adjust' the sockets locations manually.

Also, the tool set the 64 bit 'Steam' Path of Exile process as default.

You can use Windows task manager to check your Path of Exile process (Steam or GGG, 32 or 64 bits). Remember not to include the '.exe', only the name.

![alt text](https://github.com/kernelENREK/PoE_colorBlind/blob/master/reamde_ss2.jpg "Options screen")

If your PoE game resolution is not equal to 1920 x 1080 you should 'adjust' your sockets positions in order to overlay the sockets propertly on the currency tab. Use the Mouse pointer info for this action.
Advice #1: You should use the 'center point' of the socket, not the 'upper-left' corner.
Advice #2: Sockets on the same x-Axis will have the same X value, and sockets on the same y-Axis will have the same Y value. (Captain Obvious to the rescue)

Once you are done, press the SAVE button and the settings will be saved in a file named settings.xml located in the same path folder where you are running the tool.

# Advanced settings:
In the settings.xml file there are some settings you can tweak manually:

* CheckForNewReleases: by default is true. This check for new releases on this GitHub repo. If a new release is found its shows you on main window.
* AutomodePollTime_ms: Only works if you checked "Always Show Sockets" from main window. The default value is 500 and is measured in milliseconds. This is the interval time for performing "copy item info on clipboard" if automode is On when mouse is over the item on the currency tab. Maybe 1000 (1 second) is more than enought. Anyway you should not set values lower than 500.
* PoEMustBeRunning: by default is true. 
* ProcessNotRunningTimeOut_seconds: by default 30. This parameter only takes effect if PoEMustBeRunning = false. 

On <Layout> secction:

* Radius: by default 12. This is the radius of the 'overlayed' circles.
* FontSize: by default 22. This is the font size for "R","G","B" and "W" characters.
* CharOffsetX: pixel offset on X-Axis for RGBW characters.
* CharOffsetY: pixel offset on Y-Axis for RGBW characters.

## How it works?

![alt text](https://github.com/kernelENREK/PoE_colorBlind/blob/master/reamde_ss1.jpg "Options screen")

# Manual mode:
Just hold the Ctrl + A keys while you are over an item. The hold keyword is important here, because hold not equal "to press"

# Automatic mode:
Check the option "Always Show Sockets" from tool window. When you move the mouse around the center of your currency tab (approximately) this will show the socket letters without holding Ctrl + A.
This mode will be useful in long recoloring sessions. Press the right mouse click on your Chromatic orbs and then pressing Shift key use the orbs on the item: you will see the right letters 'automatically'. (AutomodePollTime_ms setting, do you remember?)


# Tested: (Path of Exile release: 3.1.1b)

Rig 1: nVidia GTX 970 (driver 388.18) 1920 x 1080 with 64 bits PoE client (Steam)

Rig 2: Intel HD 620 (driver 21.45.34) 1366 x 768 with 64 bits PoE client (GGG)



# Special thanks to:
Hook:  https://github.com/gmamaladze/globalmousekeyhook

Overlay: https://github.com/YatoDev/Yato.DirectXOverlay
