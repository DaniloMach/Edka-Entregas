using System;
using System.Collections.Generic;
using System.Linq;

namespace Edka.Sa04
{
    internal class Program
    {
        public static List<Despesa> despesa = new List<Despesa>
        {
            new Despesa{Descricao = "internet", Valor= 89 ,
                Vencimento=new DateTime (2022,11,15) },
            new Despesa{Descricao = "Luz", Valor= 200 ,
                Vencimento=new DateTime (2022,11,17) },
            new Despesa{Descricao = "Agua", Valor= 100 ,
                Vencimento=new DateTime (2022,11,02) },
            new Despesa{Descricao="Gasolina", Valor=230 ,
                Vencimento=new DateTime (2022 , 11,11)},
            new Despesa{Descricao="Roupas", Valor= 300, 
            Vencimento=new DateTime (2022 , 11 , 28)}
 };
        static void Main(string[] args)
        {
            var despesaAbaixodeCem = from d in despesa
                                     where d.Valor<300
                                     orderby d.Vencimento
                                     select d;
            foreach (var item in despesaAbaixodeCem)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();  
        }
    }
}
