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
            this.winIo = io;
        }

        public void OnLoad()
        {
            string pfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HCS");
            winIo.createFSbuildImportFolder(pfad);
        }
    }
}
