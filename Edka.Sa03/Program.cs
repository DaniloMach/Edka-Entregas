using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/1.fonte de dados (vetor, matriz, collections, .xls(arquivo execel),
             * .xml,.txt,.Csv,.Dat)
             */
            int[] votos = new int[10]
            {
                1,2,3, 4, 5, 6, 7,5,5,7
            };
            //2. COnsulta: query sintax . linq
            var consulta = from voto in votos
                           select voto;
            // 3. Executando Consulta.
           //listando com "foreach" 
            foreach (int voto in consulta)
            {
                Console.WriteLine(voto);

            }
            //lidtando com tolist
           /*var votosFiltradors= consulta.ToList ();
            Console.WriteLine($"votos filtrando: {votosFiltradors} ");*/
            Console.ReadLine();
        }
    }
}
