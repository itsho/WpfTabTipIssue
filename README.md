# What is this repo

A repo demonstrating the issue of TabTip not "notifying" WPF application of its presence.
Therefore - the keyboard is covering parts of the WPF application (.NET 4.0 -> .NET 4.6.1) 

This behavior was different in Windows 8 - see [discussion](https://social.technet.microsoft.com/Forums/en-US/a3845602-fc12-45b2-b9fd-a539eb502e49/touch-keyboard-no-longer-resizing-maximized-desktop-application?forum=win10itproapps) in Microsoft's forum.

Also - see the [discussion](https://stackoverflow.com/questions/30482440/wpf-window-size-not-affected-by-tabtip-keyboard) in StackOverflow.

# Solution for newer .NET framework

There's a [working solution](https://github.com/Microsoft/WPF-Samples/tree/master/Input%20and%20Commands/TouchKeyboard/TouchKeyboardNotifier) in Microsoft repository, but it's only relevant for .NET 4.6.2+

# Tested on
 - Windows 10 1703
 - Windows 10 1803

# Screen recording

![gif](/Example/TabTip_issue_in_fullscreen.gif)

[webm link](/Example/TabTip_issue_in_fullscreen.webm)
