using System;
using System.Collections.Generic;
using Gtk;
using Tabla;
namespace Tabla
{
    public class Bolet
    {

        private int[][] matriz = new int[3][6];
        private Button[] botones;
        private IList<int> bolas = new List<int>();
        int val;
        private Random random = new Random();
     

        public Bolet(VBox vBox, int val, uint rows, uint columns)
        {
            this.val = val;
            botones = new Button[val];
            for (int bola = 1; bola <= val; bola++)
            {
                bolas.Add(bola);
                botones[bola - 1] = new Button();
            }

            int index = 0;
            Table tabla = new Table(rows, columns, true);
            for (uint row = 0; row < rows; row++)
                for (uint col = 0; col < columns; col++)
                {

                    Button but = new Button();
                    index = sacarBola();
                    botones[index-1] = but;
                    tabla.Attach(botones[index-1], col, col + 1, row, row + 1);
                    botones[index-1].Label = (index).ToString();
                    matriz[row][col] = index;
                }

            vBox.Add(tabla);
            tabla.ShowAll();
        }
        public void Marcar(int num)
        {
            
            botones[num-1].ModifyBg(StateType.Normal, new Gdk.Color(200, 200, 200));
        }
        public void Reset()
        {
            for (int i = 0; i < val; i++)
            {
                botones[i].ModifyBg(StateType.Normal, new Gdk.Color(250, 250, 250));
            }
        }
        public int sacarBola()
        {

            if (bolas.Count == 0)
            {
                return -1;
            }
            else
            {
                int indexAleatorio = random.Next(bolas.Count);
                int bola = bolas[indexAleatorio];
                bolas.RemoveAt(indexAleatorio);
                return bola;
            }
        }

    }

}
