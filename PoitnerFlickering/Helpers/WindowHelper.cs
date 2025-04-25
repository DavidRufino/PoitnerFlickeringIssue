using Microsoft.UI.Windowing;
using Microsoft.UI;
using System;
using WinRT;

namespace PoitnerFlickering.Helpers;

public class WindowHelper
{
    /// <summary>
    /// The window handle
    /// </summary>
    public IntPtr hWnd { get; private set; }
    public WindowId windowId { get; private set; }
    public AppWindow appWindow { get; private set; }
    public OverlappedPresenter Presenter { get; private set; }

    public WindowHelper(object target)
    {
        // Get the window handle using the WinRT.Interop library
        this.hWnd = WinRT.Interop.WindowNative.GetWindowHandle(target);

        // Get the window ID using the Win32Interop library
        this.windowId = Win32Interop.GetWindowIdFromWindow(hWnd);

        // Get the AppWindow object from the window ID
        this.appWindow = AppWindow.GetFromWindowId(windowId);

        // Get the presenter object from the AppWindow object and set its border and title bar
        this.Presenter = appWindow.Presenter.As<OverlappedPresenter>();
    }
}