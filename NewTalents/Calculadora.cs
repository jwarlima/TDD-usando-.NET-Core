using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public List<String> Historico()
        {
            return listaHistorico.Take(3).ToList();
        }
    }
}
