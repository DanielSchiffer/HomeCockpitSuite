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
            GesamtFortschritt = 0;
            WorkItemFortschritt = 0;
            WorkItemText = "";
        }

        internal void OnClose()
        {
            // Keine Aktion erforderlich
        }

        internal void Erstellen()
        {
            throw new NotImplementedException();
        }

        #region Eigenschaften
        private string airac = "-";
        private int gesamtFortschritt;
        private int workItemFortschritt;
        private string workItemText = "";
        private string gueltigVon = "-";
        private string gueltigBis = "";
        private bool navdataErstellbar;

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
            get => string.IsNullOrEmpty(airac) ? "-" : airac;
            set
            {
                if (airac != value)
                {
                    airac = value;
                    OnPropertyChanged();
                }
            }
        }

        public string GueltigVon
        {
            get => string.IsNullOrEmpty(gueltigVon) ? "-" : gueltigVon;
            set
            {
                if (gueltigVon != value)
                {
                    gueltigVon = value;
                    OnPropertyChanged();
                }
            }
        }

        public string GueltigBis
        {
            get => string.IsNullOrEmpty(gueltigBis) ? "" : gueltigBis;
            set
            {
                if (gueltigBis != value)
                {
                    gueltigBis = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool NavdataErstellbar
        {
            get => navdataErstellbar;
            set
            {
                if (navdataErstellbar != value)
                {
                    navdataErstellbar = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}
