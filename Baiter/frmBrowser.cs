using Baiter.Popups;
using System.Drawing;
using System.Windows.Forms;
using static Baiter.Popups.Popup;

namespace Baiter {
    public partial class frmBrowser : Form {

        private Popup popup;

        public frmBrowser() {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void SetPopup(Popup popup, ArgList args) {
            this.popup = popup;
            string html = popup.HTML;

            foreach(Argument arg in args) {
                html = Popup.SetArgument(html, arg.Arg, arg.Value);
            }
            Icon = Icon.FromHandle(popup.Icon.GetHicon());
            webBrowser1.DocumentText = html;
            Text = popup.WindowTitle;
            Width = popup.WindowWidth;
            Height = popup.WindowHeight;
        }

        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }
    }
}
