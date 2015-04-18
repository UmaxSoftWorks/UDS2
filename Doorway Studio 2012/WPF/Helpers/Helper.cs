using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Umax.WPF.Helpers
{
    public static class Helper
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);

        public static ImageSource ToImageSource(this Icon Icon)
        {
            Bitmap bitmap = Icon.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();
            ImageSource wpfBitmap = Imaging.CreateBitmapSourceFromHBitmap(hBitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            if (!DeleteObject(hBitmap))
            {
                throw new Win32Exception();
            }

            return wpfBitmap;
        }

        public static bool IsDisposed(this Window Window)
        {
            return new WindowInteropHelper(Window).Handle == IntPtr.Zero;
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Image"/> into a WPF <see cref="BitmapSource"/>.
        /// </summary>
        /// <param name="source">The source image.</param>
        /// <returns>A BitmapSource</returns>
        public static BitmapSource ToBitmapSource(this System.Drawing.Image source)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(source);

            var bitSrc = bitmap.ToBitmapSource();

            bitmap.Dispose();
            bitmap = null;

            return bitSrc;
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Bitmap"/> into a WPF <see cref="BitmapSource"/>.
        /// </summary>
        /// <remarks>Uses GDI to do the conversion. Hence the call to the marshalled DeleteObject.
        /// </remarks>
        /// <param name="source">The source bitmap.</param>
        /// <returns>A BitmapSource</returns>
        public static BitmapSource ToBitmapSource(this System.Drawing.Bitmap source)
        {
            BitmapSource bitSrc = null;

            var hBitmap = source.GetHbitmap();

            try
            {
                bitSrc = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    hBitmap,
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
            }
            catch (Win32Exception)
            {
                bitSrc = null;
            }
            finally
            {
                DeleteObject(hBitmap);
            }

            return bitSrc;
        }

        #region Window Header
        private const Int32 GWL_STYLE = -16;
        private const Int32 WS_MAXIMIZEBOX = 0x00010000;
        private const Int32 WS_MINIMIZEBOX = 0x00020000;

        [DllImport("User32.dll", EntryPoint = "GetWindowLong")]
        private extern static Int32 GetWindowLongPtr(IntPtr hWnd, Int32 nIndex);

        [DllImport("User32.dll", EntryPoint = "SetWindowLong")]
        private extern static Int32 SetWindowLongPtr(IntPtr hWnd, Int32 nIndex, Int32 dwNewLong);

        /// <summary>
        /// Disables the maximize functionality of a WPF window.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void DisableMaximize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);
                SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle & ~WS_MAXIMIZEBOX);
            }
        }

        /// <summary>
        /// Disables the minimize functionality of a WPF window.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void DisableMinimize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);
                SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle & ~WS_MINIMIZEBOX);
            }
        }

        /// <summary>
        /// Enables the maximize functionality of a WPF window.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void EnableMaximize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);
                SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle | WS_MAXIMIZEBOX);
            }
        }

        /// <summary>
        /// Enables the minimize functionality of a WPF window.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void EnableMinimize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);
                SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle | WS_MINIMIZEBOX);
            }
        }

        /// <summary>
        /// Toggles the enabled state of a WPF window's maximize functionality.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void ToggleMaximize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);

                if ((windowStyle | WS_MAXIMIZEBOX) == windowStyle)
                {
                    SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle & ~WS_MAXIMIZEBOX);
                }
                else
                {
                    SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle | WS_MAXIMIZEBOX);
                }
            }
        }

        /// <summary>
        /// Toggles the enabled state of a WPF window's minimize functionality.
        /// </summary>
        /// <param name="window">The WPF window to be modified.</param>
        public static void ToggleMinimize(Window window)
        {
            lock (window)
            {
                IntPtr hWnd = new WindowInteropHelper(window).Handle;
                Int32 windowStyle = GetWindowLongPtr(hWnd, GWL_STYLE);

                if ((windowStyle | WS_MINIMIZEBOX) == windowStyle)
                {
                    SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle & ~WS_MINIMIZEBOX);
                }
                else
                {
                    SetWindowLongPtr(hWnd, GWL_STYLE, windowStyle | WS_MINIMIZEBOX);
                }
            }
        }
        #endregion
    }
}
