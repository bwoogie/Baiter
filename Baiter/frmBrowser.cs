using Baiter.Popups;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static Baiter.Popups.Popup;

namespace Baiter {
    public partial class frmBrowser : Form {

        private Popup popup;
        private string exitCode = "scam";
        private string keys = "";

        private bool endOnX = false;

        public frmBrowser() {
            InitializeComponent();
            
            MinimizeBox = false;
            MaximizeBox = false;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            webBrowser1.ScrollBarsEnabled = false;
            TopMost = true;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            keys += (char)keyData;
            Debug.WriteLine(keys);
            
            for(int i = 0; i < exitCode.Length; i++) {
                if(keys.Length > i) {
                    if(exitCode.Substring(i, 1).ToLower() != keys.Substring(i, 1).ToLower()) {
                        keys = "";
                        return true;
                    }
                } else {
                    return true;
                }
            }
            endOnX = true;
            Application.Exit();
            return true;            
            //return base.ProcessCmdKey(ref msg, keyData);
        }

        public void SetPopup(Popup popup, ArgList args) {
            this.popup = popup;
            string html = popup.HTML;
            Width = popup.WindowWidth;
            Height = popup.WindowHeight;
            FormBorderStyle = popup.BorderStyle;
            WindowState = popup.WindowState;

            foreach(Argument arg in args) {
                html = Popup.SetArgument(html, arg.Arg, arg.Value);
            }
            Icon = Icon.FromHandle(popup.Icon.GetHicon());
            webBrowser1.DocumentText = html;
            
            Text = popup.WindowTitle;
        }

        private void ShowAnnoyanceBox() {
            if(popup.messageBox != null) {
                DialogResult dr = MessageBox.Show(popup.messageBox.Message, popup.messageBox.Title, popup.messageBox.Buttons, popup.messageBox.Icon);
                if(popup.messageBox.Constant) {
                    ShowAnnoyanceBox();
                }
            }
        }

        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e) {
            if(endOnX) return;
            SystemSounds.Beep.Play();
            e.Cancel = true;
        }

        private void frmBrowser_Shown(object sender, System.EventArgs e) {
            ShowAnnoyanceBox();
        }
    }
}