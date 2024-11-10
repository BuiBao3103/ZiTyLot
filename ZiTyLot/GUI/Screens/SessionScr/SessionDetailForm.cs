using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.SessionScr
{
    public partial class SessionDetailForm : Form
    {
        public int _sessionId;
        public SessionDetailForm(int sessionId)
        {
            _sessionId = sessionId;
            InitializeComponent();
            this.CenterToScreen();

            gbInfomation.Text += " - " + sessionId;
        }

        private void btnLostCard_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
