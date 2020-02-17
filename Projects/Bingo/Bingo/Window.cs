using System;
using Gtk;
using Bingo;
namespace Bingo
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            Button but = new Button();
            this.Add(but);
            this.Build();
        }
    }
}
