using System;
using System.Collections.Generic;
using Gtk;

namespace Bingo
{
    public partial class Carton : Gtk.Window
    {
        private Button[] botones;
        private IList<int> bolas = new List<int>();
        int val;
        private Random random = new Random();
        public int[] valores;

        public Carton(int val, uint rows, uint columns, int id) :
                base(Gtk.WindowType.Toplevel)
        {
            int k = 0;
            this.val = val;
            valores = new int[rows * columns];

            botones = new Button[val];
            for (int bola = 1; bola <= val; bola++)
            {
                bolas.Add(bola);
                botones[bola - 1] = new Button();
            }

            int index = 0;
            Table tabla = new Table(rows+1, columns, true);
            Label label = new Label();
            label.Text = "Cartón nº :" + id.ToString();
            tabla.Attach(label, 0, 1, 0, 1);


  

                    
                    for (uint row = 1; row < rows; row++)
                        for (uint col = 0; col < columns; col++)
                        {

                            Button but = new Button();
                            index = sacarBola();
                            botones[index - 1] = but;
                            tabla.Attach(botones[index - 1], col, col + 1, row, row + 1);
                            botones[index - 1].Label = (index).ToString();
                            valores[k] = index;
                            k++;

                        }

            
                    
                    this.Add(tabla);
            tabla.ShowAll();



            this.Build();
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
