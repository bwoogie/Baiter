using Baiter.Popups;
using System;
using System.Windows.Forms;
using static Baiter.Popups.Popup;

namespace Baiter {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();

            populatePopupList();
        }

        private void populatePopupList() {
            foreach(Popup p in GetPopups()) {
                lbPopups.Items.Add(p.Name);
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e) {
            if(lbPopups.SelectedIndex == -1) return;

            frmBrowser browser = new frmBrowser();

            ArgList args = new ArgList();
            foreach(TextBox tb in flpArgs.Controls) {
                Argument newArg = GetPopups()[lbPopups.SelectedIndex].Arguments.GetArgumentByName(tb.Name);
                newArg.Value = tb.Text;
                args.Add(newArg);
            }
            Visible = false;
            browser.SetPopup(GetPopups()[lbPopups.SelectedIndex], args);
            browser.Show();
        }

        private void lbPopups_SelectedIndexChanged(object sender, EventArgs e) {
            if(lbPopups.SelectedIndex == -1) return;

            flpArgs.Controls.Clear();

            if(GetPopups()[lbPopups.SelectedIndex].Screenshot != null) {
                pbScreen.Image = GetPopups()[lbPopups.SelectedIndex].Screenshot;
            } else {
                pbScreen.Image = null;
            }

            foreach(Argument arg in GetPopups()[lbPopups.SelectedIndex].Arguments) {
                TextBox tb = new TextBox();
                tb.Name = arg.Name;
                tb.Text = arg.Value;
                tb.Width = flpArgs.Width - (flpArgs.Margin.Right * 2);
                flpArgs.Controls.Add(tb);
            }
        }
    }
}
