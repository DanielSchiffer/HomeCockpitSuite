using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielSchiffer.HCS.Contracts.IOSIO;
using DanielSchiffer.HCS.Logic.NavdataUpdater;
using DanielSchiffer.HCS.Logic.WindowsIo;

namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels
{
    public class NavdataUpdateModel : ViewModelBase
    {
        private readonly INavDataIo winIo;
        private readonly Updater updater;

        public NavdataUpdateModel(INavDataIo io, Updater updater)
        {
            winIo = io;
            this.updater = updater;
            InitializeWindow();
        }

        public void OnLoad()
        {
            winIo.CreateFSbuildImportFolder();
            Airac = updater.GetAirVersionFromFile() ?? "-";
            GueltigVon = updater.GetGueltigVonFromFile() ?? "-";
            GueltigBis = updater.GetGueltigBisFromFile() ?? "-";
        }

        private void InitializeWindow()
        {
            gesamtFortschritt = 0;
            workItemFortschritt = 0;
            workItemText = "";

        }

        internal void OnClose()
        {
            // Keine Aktion erforderlich
        }

        internal void Erstellen()
        {
            updater.startUpdate();
        }

        #region Eigenschaften
        private string _airac = "-";
        private int gesamtFortschritt;
        private int workItemFortschritt;
        private string workItemText = "";
        private string _gueltigVon = "-";
        private string _gueltigBis = "";
        private bool _navdataErstellbar;

        public int GesamtFortschritt
        {
            get => gesamtFortschritt;
            set
            {
                if (gesamtFortschritt != value)
                {
                    gesamtFortschritt = value;
                    OnPropertyChanged();
                }
            }
        }

        public int WorkItemFortschritt
        {
            get => workItemFortschritt;
            set
            {
                if (workItemFortschritt != value)
                {
                    workItemFortschritt = value;
                    OnPropertyChanged();
                }
            }
        }

        public string WorkItemText
        {
            get => string.IsNullOrEmpty(workItemText) ? "-" : workItemText;
            set
            {
                if (workItemText != value)
                {
                    workItemText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Airac
        {
            get => string.IsNullOrEmpty(_airac) ? "-" : _airac;
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
            get => string.IsNullOrEmpty(_gueltigVon) ? "-" : _gueltigVon;
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
            get => string.IsNullOrEmpty(_gueltigBis) ? "" : _gueltigBis;
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
            get => _navdataErstellbar;
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
