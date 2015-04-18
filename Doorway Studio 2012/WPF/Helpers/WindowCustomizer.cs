using System.Windows;

namespace Umax.WPF.Helpers
{
    public static class WindowCustomizer
    {
        #region CanMaximize
        public static readonly DependencyProperty CanMaximize = DependencyProperty.RegisterAttached("CanMaximize", typeof(bool), typeof(Window),
                                                                                                    new PropertyMetadata(true, new PropertyChangedCallback(OnCanMaximizeChanged)));
        
        private static void OnCanMaximizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Window window = d as Window;
            if (window != null)
            {
                RoutedEventHandler loadedHandler = null;
                loadedHandler = delegate
                {
                    if ((bool)e.NewValue)
                    {
                        Helper.EnableMaximize(window);
                    }
                    else
                    {
                        Helper.DisableMaximize(window);
                    }

                    window.Loaded -= loadedHandler;
                };

                if (!window.IsLoaded)
                {
                    window.Loaded += loadedHandler;
                }
                else
                {
                    loadedHandler(null, null);
                }
            }
        }
        public static void SetCanMaximize(DependencyObject d, bool value)
        {
            d.SetValue(CanMaximize, value);
        }

        public static bool GetCanMaximize(DependencyObject d)
        {
            return (bool)d.GetValue(CanMaximize);
        }
        #endregion CanMaximize

        #region CanMinimize

        public static readonly DependencyProperty CanMinimize = DependencyProperty.RegisterAttached("CanMinimize", typeof (bool), typeof (Window),
                                                                                                    new PropertyMetadata(true, new PropertyChangedCallback(OnCanMinimizeChanged)));

        private static void OnCanMinimizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Window window = d as Window;
            if (window != null)
            {
                RoutedEventHandler loadedHandler = null;
                loadedHandler = delegate
                {
                    if ((bool)e.NewValue)
                    {
                        Helper.EnableMinimize(window);
                    }
                    else
                    {
                        Helper.DisableMinimize(window);
                    }

                    window.Loaded -= loadedHandler;
                };

                if (!window.IsLoaded)
                {
                    window.Loaded += loadedHandler;
                }
                else
                {
                    loadedHandler(null, null);
                }
            }
        }

        public static void SetCanMinimize(DependencyObject d, bool value)
        {
            d.SetValue(CanMinimize, value);
        }

        public static bool GetCanMinimize(DependencyObject d)
        {
            return (bool)d.GetValue(CanMinimize);
        }
        #endregion CanMinimize
    }
}
