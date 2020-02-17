using System;
using Gtk;
using Tabla;




public partial class MainWindow : Gtk.Window
{
    private int val = 90;
    private Panel panel;
    private Bolet boleto;

    private Bombo bom;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        bom = new Bombo(val);
        panel = new Panel(vbox3, 90,10,9);
        boleto = new Bolet(vbox4, 90, 3, 6);

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnClickLanzar(object sender, EventArgs e)
    {
        int l = bom.sacarBola();
        if (l == -1)
        {
            MessageDialog err = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Desea reiniciar el bombo?");
            err.Run();
            err.Destroy();


            OnClickReset(sender, e);
        }
        else
        {
            panel.Marcar(l);
            boleto.Marcar(l);
        }
    }

    protected void OnClickSalir(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnClickReset(object sender, EventArgs e)
    {
        panel.Reset();
        boleto.Reset();
        bom = new Bombo(val);
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
