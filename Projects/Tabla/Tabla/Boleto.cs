using System;
using System.Collections.Generic;
using Gtk;
//using Tabla;

namespace Tabla.Properties
{
    public class Boleto
    {
        private IList<Button> botones = new List<Button>();
        private Random random = new Random();
        //private uint rows = 10;
        //private uint columns = 9;
        private int val;

        public Boleto(VBox vBox, int val, uint rows, uint columns)
        {

            this.val = val;

            int index;
            Table tabla = new Table(rows, columns, true);
            for (uint row = 0; row < rows; row++)
                for (uint col = 0; col < columns; col++)
                {
                    Button but = new Button();
                    botones.Add(but);
                    index = random.Next(1, 90);
                    tabla.Attach(but, col, col + 1, row, row + 1);
                    but.Label = (index).ToString();
                }

            vBox.Add(tabla);
            tabla.ShowAll();
        }
        public void Marcar(int num)
        {
            botones[num - 1].ModifyBg(StateType.Normal, new Gdk.Color(200, 200, 200));
        }
        public void Reset()
        {
            for (int i = 0; i < val; i++)
            {
                botones[i].ModifyBg(StateType.Normal, new Gdk.Color(250, 250, 250));
            }
        }
    }
}
