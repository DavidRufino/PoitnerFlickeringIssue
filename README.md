##Describe the bug

When ExtendsContentIntoTitleBar = true is set on both the main window and any child windows, certain interactions cause incorrect cursor event processing.

##Steps to reproduce the bug:

1. Create a child window with ExtendsContentIntoTitleBar = true
2. You can reproduce the issue by either minimizing the child window, or by moving the mouse cursor upward — starting from inside the child window, passing through its title bar, and continuing into the main window.
3. Interact with UI elements in the main window

These actions lead to:

Button hover states flickering
MenuFlyoutSubItem closing
Click events not firing correctly

##NuGet package version

Microsoft.WindowsAppSDK 1.7.250401001

##Windows version

Windows 11 Pro (24H2), Build 26100.3775

##Not reproducible in:

Microsoft.WindowsAppSDK 1.5.250108004
