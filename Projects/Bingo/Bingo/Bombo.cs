using System;
using System.Collections.Generic;
using Gtk;
using Bingo;

namespace Bingo
{
    public class Bombo
    {
        private IList<int> bolas = new List<int>();
        private Random random = new Random();

        public Bombo(int val)
        {
            inicia(val);
        }
        public int sacarBola()
        {
            if (bolas.Count==0)
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
        public void inicia(int val)
        {
            bolas.Clear();
            for (int bola = 1; bola <= val; bola++)
            {
                bolas.Add(bola);
            }
        }
    }
}
