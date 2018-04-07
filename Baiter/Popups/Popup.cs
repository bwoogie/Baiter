using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Baiter.Popups {
    public abstract class Popup {

        public abstract ArgList Arguments { get; }                  //arguments, such as phone#, etc. to be used in the html
        public abstract string HTML { get; }                        //the html of the popup
        public abstract AnnoyanceMessageBox messageBox { get; }     //a windows messagebox with an additional message
        public abstract Bitmap Screenshot { get; }                  //a screenshot of the message
        public abstract Bitmap Icon { get; }                        //the window icon
        public abstract string Name { get; }                        //the name of the popup
        public abstract string WindowTitle { get; }                 //the window title of the popup
        public abstract int WindowWidth { get; }                    //the width of the popup window
        public abstract int WindowHeight { get; }                   //the height of the popup window
        public abstract FormWindowState WindowState { get; }        //the state of the window (minimized, maximized, normal)
        public abstract FormBorderStyle BorderStyle { get; }        //the border style of the window
        

        public virtual void ShowMessage() {
            if(messageBox == null) return;
            MessageBox.Show(messageBox.Message, messageBox.Title, messageBox.Buttons, messageBox.Icon);
            if(messageBox.Constant) {
                ShowMessage();
            }
        }

        public static string SetArgument(string html, string arg, string value) {
            string s;
            s = html.Replace(arg, value);
            return s;
        }

        public static List<Popup> GetPopups() {
            List<Popup> list = new List<Popup>();
            var type = typeof(Popup);
            var popups = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToList();
            Assembly assembly = typeof(Popup).Assembly;
            for(int i =0; i < popups.Count; i++) {
                Type t = Type.GetType(popups[i].FullName);
                Popup p = (Popup)Activator.CreateInstance(t);
                list.Add(p);
            }
            return list;
        }

        public class Argument {
            public string Arg;
            public string Name;
            public string Value;
        }

        public class ArgList : List<Argument> {
            public Argument GetArgumentByName(string name) {
                foreach(Argument arg in this) {
                    if(arg.Name == name)
                        return arg;
                }
                return null;
            }
        }

        public class AnnoyanceMessageBox {
            public string Title;
            public string Message;
            public MessageBoxIcon Icon;
            public MessageBoxButtons Buttons;
            public bool Constant;
        }

    }
}
