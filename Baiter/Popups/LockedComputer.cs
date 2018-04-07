using System;
using System.Drawing;
using System.Windows.Forms;

namespace Baiter.Popups {
    public class LockedComputer : Popup {

        public override string HTML => Properties.Resources.LockedComputer;

        public override AnnoyanceMessageBox messageBox => new AnnoyanceMessageBox() {
            Title = "Computer is danger",
            Message =
            "********************************" + Environment.NewLine +
            "DRK/Ness.worm1944CCFCFFEC" + Environment.NewLine +
            "********************************" + Environment.NewLine +
            Environment.NewLine +
            "Call Technical Support Immediately" + Environment.NewLine +
            Environment.NewLine +
            "The following data will be compromised if you continue:" + Environment.NewLine +
            "1. Passwords" + Environment.NewLine +
            "2. Browser Histroy" + Environment.NewLine +
            "3. Credit Card Information" + Environment.NewLine +
             Environment.NewLine +
             "This virus is well known for complete identity and credit card threft. Further action through this computer or any computer on the network will reveal private information and involve and involve serious risks." + Environment.NewLine +
             Environment.NewLine +
             "Call Technical Support Immediately"
            ,
            Buttons = System.Windows.Forms.MessageBoxButtons.OK,
            Icon = System.Windows.Forms.MessageBoxIcon.None,
            Constant = true,
        };

        public override Bitmap Icon => Properties.Resources.flat_x;

        public override string Name => "Locked Computer";

        public override string WindowTitle => "Your computer has been locked";

        public override int WindowWidth => 900;

        public override int WindowHeight => 720;

        public override FormWindowState WindowState => FormWindowState.Maximized;

        public override ArgList Arguments => new ArgList {
                new Argument() { Arg = "%phone%", Name = "Phone", Value = "1-800-555-5555" },
                new Argument() {Arg = "%ip%", Name = "IP Address", Value = "192.168.1.101" },
            };

        public override FormBorderStyle BorderStyle => FormBorderStyle.None;

        public override Bitmap Screenshot => Properties.Resources.locked_ss;
    }
}
