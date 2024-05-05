using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielSchiffer.HCS.Logic.NavdataUpdater;
using DanielSchiffer.HCS.Logic.WindowsIo;

namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels
{
    public class NavdataUpdateModel : ViewModelBase
    {
        private readonly NavDataIo winIo;
        private readonly Updater updater;

        public NavdataUpdateModel(NavDataIo io, Updater updater)
        {
            this.winIo = io;
            this.updater = updater;
            initialisiereFenster();
        }

        public void OnLoad()
        {
            
            winIo.createFSbuildImportFolder();
        }

        private void initialisiereFenster()
        {
            Airac = updater.GetAirVersionFromFile();
            _gesamtFortschritt = 0;
            _workItemFortschritt = 0;
            _workItemText = "";
            GueltigVon = updater.GetGueltigVonFromFile();
            GueltigBis = updater.getGueltigBisFromFile();

        }

        internal void OnClose()
        {
           
        
        }

        internal void Erstellen()
        {
            updater.startUpdate();
        }

        #region Propertys
        private string? _airac;
        private int _gesamtFortschritt;
        private int _workItemFortschritt  ;
        private string? _workItemText;
        private string? _gueltigVon;
        private string? _gueltigBis;
        private bool _navdataErstellbar;

        public int GesamtFortschritt
        {
            get { return _gesamtFortschritt; }
            set
            {
                if (_gesamtFortschritt != value)
                {
                    _gesamtFortschritt = value;
                    OnPropertyChanged();
                }
            }

        }

        public int WorkItemFortschritt
        {
            get { return _workItemFortschritt; }
            set
            {
                if (_workItemFortschritt != value)
                {
                    _workItemFortschritt = value;
                    OnPropertyChanged();
                }
            }
        }

        public string WorkItemText
        {
            get { return _workItemText is null ? "-" : _workItemText; }
            set
            {
                if (_workItemText != value)
                {
                    _workItemText = value;
                    OnPropertyChanged();
                }
            }
        }


        public string Airac
        {
            get { return _airac is null ? "-" : _airac; }
            set
            {
                if (_airac != value)
                {
                    _airac = value;
                    OnPropertyChanged();
                
                }
                if (_airac != "-")
                {
                    NavdataErstellbar = true;
                }
                else
                {
                    NavdataErstellbar = false;
                }
            }
        }

        public string GueltigVon
        {
            get { return _gueltigVon is null ? "-" : _gueltigVon; }
            set
            {
                if (_gueltigVon != value)
                {
                    _gueltigVon = value;
                    OnPropertyChanged();

                }
            }

        }

        public string GueltigBis
        {
            get { return _gueltigBis is null ? "" : _gueltigBis; }
            set
            {
                if (_gueltigBis != value)
                {
                    _gueltigBis = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool NavdataErstellbar
        {
            get { return _navdataErstellbar; }

            set
            {
                if (_navdataErstellbar != value)
                {
                    _navdataErstellbar = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion
    }
}
