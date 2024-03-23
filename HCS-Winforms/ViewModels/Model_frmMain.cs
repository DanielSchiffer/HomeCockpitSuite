using DanielSchiffer.HCS.UI.HCS_Winforms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels
{
    public class Model_frmMain : INotifyPropertyChanged
    {
        private readonly System.Windows.Forms.Timer _timer;
        private readonly frmMain frm;
        private string datum;
        private string uhrzeit;
        private string _utc;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Datum
        {
            get { return datum; }
            set
            {
                if (datum != value)
                {
                    datum = value;
                    OnPropertyChanged();
                }

            }
        }
        public string Uhrzeit
        {
            get { return u hrzeit; }
            set
            {
                if (Uhrzeit != value)
                {
                    Uhrzeit = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Utc
        {
            get { return _utc; }
            set
            {
                if (_utc != value)
                {
                    _utc = value;
                }
            }
        }
        public Model_frmMain()
        {
            _timer = new System.Windows.Forms.Timer();
            frm = new frmMain(this);
        }
        public void show()
        {
            Setze_und_Starte_Timer();
            frm?.Show();
        }
        private void Setze_und_Starte_Timer()
        {
            _timer.Interval = 1000; // Set interval to 1 second;
            _timer.Tick += Timer_Tick; // Add event handler
            _timer.Start(); // Start timer
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Datum = DateTime.Now.ToString("dd.MM.yyyy"); // Display current date in tbDatum
            Uhrzeit = DateTime.Now.ToString("HH:mm"); // Display current time in tbLocalTime
            Utc = DateTime.UtcNow.ToString("HH:mm"); // Display current UTC time in tbUTC
        }

    }
}
