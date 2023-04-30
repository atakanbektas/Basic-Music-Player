using System;
using System.Windows.Forms;

namespace MusicPlayer.UI.HelperUI
{
    public static class FormHelper
    {
        private static Form _form;
        private static Timer _timer;
        private static Timer _timer2;
        public static void OnFormOpenSetOpacity(this Form form, int invertal)
        {
            if (form != null)
            {
                form.Opacity = 0;
                _form = form;
                _timer = new Timer();
                _timer.Interval = invertal;
                _timer.Tick += Timer_Tick;
                _timer.Start();
            }
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Opacity += 0.02;
                if (_form.Opacity >= 0.90)
                {
                    _form.Opacity = 1;
                    _timer.Stop();
                }
            }
        }

        public static void OnFormCloseSetOpacity(this Form form, int invertal)
        {
            if (form != null)
            {
                form.Opacity = 1;
                _form = form;
                _timer2 = new Timer();
                _timer2.Interval = invertal;
                _timer2.Tick += _timer2_Tick;
                _timer2.Start();
            }
        }

        private static void _timer2_Tick(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Opacity -= 0.02;
                if (_form.Opacity <= 0.10)
                {
                    _form.Opacity = 0;
                    Application.Exit();
                }
            }
        }
    }
}
