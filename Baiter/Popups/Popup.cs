using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Baiter.Popups {
    public abstract class Popup {

        public string HTML;
        public AnnoyanceMessageBox MessageBox;
        public Bitmap Icon;
        public string Name;
        public string WindowTitle;
        public int WindowWidth;
        public int WindowHeight;

        public ArgList Arguments;

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

        }

    }
}
