using DanielSchiffer.Contracts.FlugplanungContract;

namespace HCS_Winforms
{
    public partial class Main : Form
    {
        private readonly IPlanung planung;

        public Main(IPlanung planung)
        {
            InitializeComponent();
            this.planung = planung;
        }
    }
}
