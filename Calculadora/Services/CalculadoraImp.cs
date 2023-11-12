using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> historico;

        public CalculadoraImp()
        {
            historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            historico.Insert(0, "Res " + res);

            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            historico.Insert(0, "Res " + res);

            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            historico.Insert(0, "Res " + res);

            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            historico.Insert(0, "Res " + res);

            return num1 / num2;
        }

        public List<string> MostrarHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
