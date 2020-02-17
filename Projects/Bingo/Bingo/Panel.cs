using System;
using System.Collections.Generic;
using Gtk;
using Bingo;

namespace Bingo
{
    public class Panel
    {
        private IList<Button> botones = new List<Button>();

        //private uint rows = 10;
        //private uint columns = 9;
        private int val;

        public Panel(VBox vBox, int val, uint rows, uint columns)
        {

            this.val = val;

            int index = 0;
            Table tabla = new Table(rows, columns, true);
            for (uint row = 0; row < rows; row++)
                for (uint col = 0; col < columns; col++)
                {

                    Button but = new Button();
                    botones.Add(but);
                    //index = random.Next(bolas.Count)
                    tabla.Attach(but, col, col + 1, row, row + 1);
                    but.Label = (index+1).ToString();

                    index++;
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
        /*  public void Reset()
          {
               for (int i = 0; i < val ; i++)
               {
                   botones[i].ModifyBg(StateType.Normal, new Gdk.Color(250, 250, 250));
               } 


                      buttons[index] = new Button();
                      table.Attach(buttons[index], col, col + 1, row, row + 1);

                      buttons[index].Add(buttons[index]);
                      buttons[index].Label = (index + 1).ToString();
                      index++;

                  }
              vBox.Add(table);
              table.ShowAll();

          }*/
    }
}
