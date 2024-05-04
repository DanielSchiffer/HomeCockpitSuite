using DanielSchiffer.HCS.Contracts.CockpitContract;
using DanielSchiffer.HCS.UI.HCS_Winforms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;

public class MainModel : ViewModelBase
{
    private readonly Timer _timer;
    private readonly FrmMain frm;
    private readonly IFlightSimInterface _flightsim;
    private string _datum = String.Empty;
    private string _uhrzeit = String.Empty;
    private string _utc = String.Empty;
    private NavdataUpdateModel _vmNavdataUpdate;

    public MainModel(IFlightSimInterface flightSim, NavdataUpdateModel vmNavdataUpdate)
    {
        _flightsim = flightSim;
        _timer = new Timer();
        frm = new FrmMain(this);
        _vmNavdataUpdate = vmNavdataUpdate;
    }
    #region Events
    public void Show()
    {
        Setze_und_Starte_Timer();
        frm?.Show();
    }
    public void OnClosing()
    {
        _timer.Stop();
    }
    internal void NavdataUpdate()
    {
        frmNavadataupdate frm = new(_vmNavdataUpdate);
        frm.ShowDialog();

    }
    #endregion
    internal void OnTestWindow()
    {
        var f = new frmTest(_flightsim);
        f.Show();
    }
    #region Propertys
    public string Datum
    {
        get { return _datum; }
        set
        {
            if (_datum != value)
            {
                _datum = value;
                OnPropertyChanged();
            }

        }
    }
    public string Uhrzeit
    {
        get { return _uhrzeit; }
        set
        {
            if (_uhrzeit != value)
            {
                _uhrzeit = value;
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
                OnPropertyChanged();
            }
        }
    }
    #endregion
    private void Setze_und_Starte_Timer()
    {
        _timer.Interval = 1000; // Set interval to 1 second;
        _timer.Elapsed += Timer_Tick; // Add event handler
        _timer.Start(); // Start timer
    }
    
    private void Timer_Tick(object? sender, ElapsedEventArgs e)
    {
        if (frm.IsHandleCreated)
        {
            frm.Invoke((MethodInvoker)delegate
            {
                Datum = DateTime.Now.ToString("dd.MM.yy"); // Display current date in tbDatum
                Uhrzeit = DateTime.Now.ToString("HH:mm"); // Display current time in tbLocalTime
                Utc = DateTime.UtcNow.ToString("HH:mm"); // Display current UTC time in tbUTC
            });
        }
    }

    internal void OnCreate()
    {
        throw new NotImplementedException();
    }
}
