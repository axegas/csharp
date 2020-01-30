using System;
using Gtk;
using Tabla;

namespace Tabla
{
    public class Panel
    {
        public Button[] buttons = new Button[90];
        public Panel(VBox vBox)
        {
            int index = 0;


            Table table = new Table(9, 10, true);
            for (uint row = 0; row < 9; row++)
                for (uint col = 0; col < 10; col++)
                {
                   
                   buttons[index] = new Button();
                   table.Attach(buttons[index], col, col + 1, row, row + 1);

                    // button.Add(button);
                    // buttons[index].Label = index + "";
                    buttons[index].Add(buttons[index]);
                    buttons[index].Label = (index+1).ToString();
                    index++;


                }
            vBox.Add(table);
            table.ShowAll();
        }

    }
}
