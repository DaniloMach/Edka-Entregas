using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa04
{
    public class Despesa
    {
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString()=> $"{Descricao,-20}- - - - - " +
            $"{Valor} -{Vencimento:dd/MM/yyyy}";


    }
}
