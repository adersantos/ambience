using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambience
{
    public class Uteis
    {
        public Double CalcularMedia(int a, int b)
        {
            return (a + b) / 2;
        }

        public Boolean NumerosPrimos(int qtde)
        {
            var retorno = false;

            try
            {
                for (int i = 1; i < qtde; i++)
                {
                    var resto = qtde % i;

                    if (resto == 0)
                    {
                        i = qtde + 1;
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return retorno;
        }

        public double RetornarValor()
        {
            double retorno = 1.0;
            var nota = 7.0;

            if (nota >= 7.0) { retorno = nota; };

            return retorno;
        }

    }
}
