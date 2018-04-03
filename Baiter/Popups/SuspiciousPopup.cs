
namespace Baiter.Popups {
    public class SuspiciousPopup : Popup {
        public SuspiciousPopup() {
            WindowTitle = "Security Warning";
            Name = "Suspicous Activity Found";
            HTML = Properties.Resources.SuspicousPopup_html;
            Icon = Properties.Resources.uac_icon2_200x200;
            WindowHeight = 400;
            WindowWidth = 720;
            Arguments = new ArgList {
                new Argument() { Arg = "%phone%", Name = "Phone" }
            };

        }
    }
}
