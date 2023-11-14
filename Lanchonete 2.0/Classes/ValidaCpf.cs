using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_2._0.Classes
{
    internal class ValidaCpf
    {
        public bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            if (cpf.Length == 11)
            {

                int[] multiplicador = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma1 = 0;

                for (int i = 0; i < multiplicador.Length; i++)
                {
                    soma1 += multiplicador[i] * (cpf[i] - '0');
                }

                int digito = soma1 % 11;
                if (digito < 2)
                {
                    digito = 0;
                }
                else
                {
                    digito = 11 - digito;
                }

                if (Convert.ToInt32(cpf[9].ToString()) != digito)
                {
                    return false;
                }

                multiplicador = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma2 = 0;

                for (int i = 0; i < multiplicador.Length; i++)
                {
                    soma2 += multiplicador[i] * (cpf[i] - '0');
                }

                int digito2 = soma2 % 11;

                if (digito2 < 2)
                {
                    digito2 = 0;
                }
                else
                {
                    digito2 = 11 - digito2;
                }

                if (Convert.ToInt32(cpf[10].ToString()) != digito2)
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
