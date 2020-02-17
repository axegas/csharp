using System;
using Gtk;
using Bingo;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    private int val = 90;
    private Panel panel;
    private Bombo bombo;
    private IList<Carton> cartones = new List<Carton>();
    private IList<int[]> valores = new List<int[]>();
    private int id=1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        bombo = new Bombo(val);
        panel = new Panel(vbox2, val, 10, 9);
   
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnClickLanzar(object sender, EventArgs e)
    {
        int suma = 0;
        int l = bombo.sacarBola();
        if (l == -1)
        {
            MessageDialog err = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Desea reiniciar el bombo?");
            err.Run();
            err.Destroy();
        }
        else
        {
            panel.Marcar(l);

            for(int i = 0; i < cartones.Count; i++)
            {
                cartones[i].Marcar(l);
          
            }
      
            for(int i = 0; i < cartones.Count; i++)
            {
                for(int j = 0; j < 18; j++)
                {
                    if (cartones[i].valores[j]==l)
                    {
                        cartones[i].valores[j] = 0;
                    }
                }
            }
            for (int i = 0; i < cartones.Count; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    suma += cartones[i].valores[j];
               
                }
                if (suma == 0)
                {
                    MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Ha ganado el nº: "+(i+1));
                    md.Run();
                    md.Destroy();
                    Application.Quit();
                }
                suma = 0;
            }
        }
    }

    protected void OnClickSalir(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnClickReset(object sender, EventArgs e)
    {
        bombo.inicia(val);
        panel.Reset();
        for (int i = 0; i < cartones.Count; i++)
        {
            cartones[i].Reset();

        }
    }

    protected void OnClickNBoleto(object sender, EventArgs e)
    {
        cartones.Add(new Carton(val, 3, 6,id));
        id++;
    }
}
