using System.Drawing;
using System.Windows.Forms;

namespace Baiter.Popups {
    public class HackedIP : Popup {

        public override string HTML => Properties.Resources.BlockedIP;

        public override AnnoyanceMessageBox messageBox => null;

        public override Bitmap Icon => Properties.Resources.flat_x;

        public override string Name => "Hacked IP";

        public override string WindowTitle => "Your IP Address has been Hacked";

        public override int WindowWidth => 900;

        public override int WindowHeight => 720;

        public override FormWindowState WindowState => FormWindowState.Normal;

        public override ArgList Arguments => new ArgList {
                new Argument() { Arg = "%phone%", Name = "Phone", Value = "1-800-555-5555" },
                new Argument() {Arg = "%ip%", Name = "IP Address", Value = "192.168.1.101" },
            };

        public override FormBorderStyle BorderStyle => FormBorderStyle.FixedSingle;

        public override Bitmap Screenshot => Properties.Resources.hackedip;
    }
}
