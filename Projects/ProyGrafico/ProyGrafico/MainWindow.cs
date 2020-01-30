using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void OnBSaludar(object sender, EventArgs a)
    {
       MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Hola " + entrada.Text);

        md.Run();
        md.Destroy();
    }

    protected void OnBAleatorio(object sender, EventArgs e)
    {
        Random r = new Random();

        
        int minimo = int.Parse(min.Text);
        int maximo = int.Parse(max.Text);
        if (minimo > maximo)
        {
            MessageDialog err = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El número mínimo tiene que ser menor o igual que el máximo.");
            err.Run();
            err.Destroy();
        }
        else
        {
            int num = (int)r.Next(minimo, maximo);
            MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, num + "");
            md.Run();
            md.Destroy();
        }

    }

    protected void OnBSalir(object sender, EventArgs args)
    {
        this.Destroy();
    }
}
