using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdkaSa05
{
    public class Disciplinas
    {
        public string Disciplina { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public override string ToString() => $" {Disciplina,-10} " +
            $"-------- {Inicio:dd/MM/yyyy}------{Termino:dd/MM:yyyy}";
       


    }
}
