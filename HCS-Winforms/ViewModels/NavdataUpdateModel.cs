using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielSchiffer.HCS.Logic.WindowsIo;

namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels
{
    public class NavdataUpdateModel : ViewModelBase
    {
        private readonly NavDataIo winIo;

        public NavdataUpdateModel(NavDataIo io)
        {
            initialisiereFenster();
            this.winIo = io;
        }

        public void OnLoad()
        {
            string pfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HCS");
            winIo.createFSbuildImportFolder(pfad);
        }

        private void initialisiereFenster()
        {
            airac = "-";
            gesamtFortschritt = 0;
            workItemFortschritt = 0;
            workItemText = "";
            gueltigVon = "-";
            gueltigBis = "-";

        }

        internal void OnClose()
        {
           
        
        }

        internal void Erstellen()
        {
            throw new NotImplementedException();
        }

        #region Propertys
        private string? airac;
        private int gesamtFortschritt;
        private int workItemFortschritt  ;
        private string? workItemText;
        private string? gueltigVon;
        private string? gueltigBis;
        private bool navdataErstellbar;

        public int GesamtFortschritt
        {
            get { return gesamtFortschritt; }
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
            get { return workItemFortschritt; }
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
            get { return workItemText is null ? "-" : workItemText; }
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
            get { return airac is null ? "-" : airac; }
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
            get { return gueltigVon is null ? "-" : gueltigVon; }
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
            get { return gueltigBis is null ? "" : gueltigBis; }
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
            get { return navdataErstellbar; }

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
