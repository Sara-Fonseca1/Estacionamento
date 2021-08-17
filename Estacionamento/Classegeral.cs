using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Classegeral
    {
        // METODO PARA RETIRAR ACENTOS DA STRING
        public static string removerAcentos(string texto)
        {

            const string StrComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç'";
            const string StrSemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc ";
            int i = 0;

            foreach (Char c in StrComAcentos)
            {
                texto = texto.Replace(c.ToString().Trim(), StrSemAcentos[i].ToString().Trim());
                i++;
            }

            return texto;

        }
    }
}
