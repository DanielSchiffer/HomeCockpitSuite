using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielSchiffer.HCS.Logic.Settings;

namespace DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels
{
    public class SettingsModel : ViewModelBase
    {
        public SettingsManager setting { get; }

        public SettingsModel(SettingsManager setting)
        {
            this.setting = setting;
        }

        #region Propertys

        //private string _SimbriefUser;

        public string SimBriefUser
        {
            get 
            { return setting.configuration.SimBriefUser is null ? String.Empty : setting.configuration.SimBriefUser; }

            set
            {
                if (setting.configuration.SimBriefUser != value)
                {
                    setting.configuration.SimBriefUser = value;
                    setting.SaveConfig();
                    OnPropertyChanged();
                }
            }
        }

        public bool EntwicklerModus
        {
            get { return setting.configuration.EntwicklerModus; }
            set
            {
                if (setting.configuration.EntwicklerModus != value)
                {
                    setting.configuration.EntwicklerModus = value;
                    setting.SaveConfig();
                    OnPropertyChanged();
                }
            }
        }



        #endregion

    }
}
