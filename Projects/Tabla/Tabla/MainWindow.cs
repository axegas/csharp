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

    protected void OnClickLanzar(object sender, EventArgs e)
    {

        int l = bom.sacarBola();
        Gdk.Color c = new Gdk.Color(200, 200, 200);
        panel.buttons[l-1].ModifyBg(StateType.Normal, c);


    }

    protected void onClickReset(object sender, EventArgs e)
    {
        bom.inicia();
        Gdk.Color c = new Gdk.Color(250, 250, 250);
        for(int i = 0; i < panel.buttons.Length; i++)
        {
            panel.buttons[i].ModifyBg(StateType.Normal, c);
        }

    }

    protected void OnClickSalir(object sender, EventArgs e)
    {

        this.Destroy();
    }
}
