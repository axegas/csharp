using System;
using Gtk;
using Tabla;

public partial class MainWindow : Gtk.Window
{
    public Bombo bom = new Bombo();
    public Panel panel;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        panel = new Panel(vBox);

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnClickAleatorio(object sender, EventArgs e)
    {

        int l = bom.sacarBola();
        Gdk.Color c = new Gdk.Color(200, 200, 200);
        panel.buttons[l-1].ModifyBg(StateType.Normal, c);


    }
}
