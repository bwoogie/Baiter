using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Baiter.Popups {
    public abstract class Popup {

        public abstract string HTML { get; }
        public abstract AnnoyanceMessageBox messageBox { get; }
        public abstract Bitmap Screenshot { get; }
        public abstract Bitmap Icon { get; }
        public abstract string Name { get; }
        public abstract string WindowTitle { get; }
        public abstract int WindowWidth { get; }
        public abstract int WindowHeight { get; }
        public abstract FormWindowState WindowState { get; }
        public abstract FormBorderStyle BorderStyle { get; }
        public abstract ArgList Arguments { get; }

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
