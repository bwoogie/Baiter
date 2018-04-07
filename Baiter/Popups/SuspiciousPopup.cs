
using System.Drawing;
using System.Windows.Forms;

namespace Baiter.Popups {
    public class SuspiciousPopup : Popup {

        public override string HTML => Properties.Resources.SuspicousPopup_html;

        public override AnnoyanceMessageBox messageBox => null;

        public override Bitmap Icon => Properties.Resources.uac_icon2_200x200;

        public override string Name => "Suspicous Activity Found";

        public override string WindowTitle => "Security Warning";

        public override int WindowWidth => 720;

        public override int WindowHeight => 400;

        public override FormWindowState WindowState => FormWindowState.Normal;

        public override ArgList Arguments => new ArgList {
                new Argument() { Arg = "%phone%", Name = "Phone", Value = "1-800-555-5555" }
            };

        public override FormBorderStyle BorderStyle => FormBorderStyle.FixedSingle;

        public override Bitmap Screenshot => Properties.Resources.suspicous_ss;

        public override void ShowMessage() {
            base.ShowMessage();
        }
    }
}
