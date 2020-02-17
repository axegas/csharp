using System;
using System.Collections.Generic;
using Gtk;
using Calculadora;
namespace Calculadora
{
    public class Cientifica
    {
        private Button[] buttons;
        public Cientifica(VBox vBox)
        {
            uint rows = 1;
            uint columns = 3;
            Table tabla = new Table(rows, columns, true);

            buttons = new Button[3];

            for (int i = 0; i < 3; i++) buttons[i] = new Button();
            buttons[0].Label = "raiz";
            buttons[1].Label = "coseno";
            buttons[2].Label = "seno";

            for(uint i=0;i<3;i++)
                tabla.Attach(buttons[i], i,i+1, rows - 1, rows);
        
            vBox.Add(tabla);
            tabla.ShowAll();
        }
        public static Button GetButton()
        {
            Button but = new Button();
            
            return but;
        }
    }
}
