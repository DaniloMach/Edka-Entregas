using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdkaSa05;

namespace EdkaSa05
{
    internal class Program
    {
        public static List<Disciplinas> disciplinas = new List<Disciplinas>
        {
             new Disciplinas { Disciplina = "Neurociência e aprendizagem",
                Inicio = new DateTime(08/08/2022),
                Termino = new DateTime(12/09/2022) },
             new Disciplinas { Disciplina = "Habilidades Socio Emocionais",
                Inicio = new DateTime(10/08/2022),
                Termino = new DateTime(24/08/2022) },
             new Disciplinas { Disciplina = "Felicidade",
                Inicio = new DateTime(31/08/2022),
                Termino = new DateTime(14/09/2022) },
             new Disciplinas { Disciplina = "Teoria do desenvolvimento humano e da aprendizagem",
                Inicio = new DateTime(19/09/2022),
                Termino = new DateTime(24/10/2022) },
             new Disciplinas { Disciplina = "Planejamento Pedagogico",
                Inicio = new DateTime(27/08/ 2022),
                Termino = new DateTime(23/10/2022) },
             new Disciplinas { Disciplina = "Educação inclusiva e Cidadania",
                Inicio = new DateTime(21/09/2022),
                Termino = new DateTime(09/11/2022) },
             new Disciplinas { Disciplina = "Gestão da Sala de Aula",
                Inicio = new DateTime(16/11/2022),
                Termino = new DateTime(30/012/2022) },
             new Disciplinas { Disciplina = "Met.Dinâmicas e inovativas",
                Inicio = new DateTime(31/10/2022),
                Termino = new DateTime(14/11/2022) },
             new Disciplinas { Disciplina = "Projeto Integrador",
                Inicio = new DateTime(21/11/2022),
                Termino = new DateTime(05/12/2022) },
             new Disciplinas { Disciplina = "Avaliação Por Competências",
                Inicio = new DateTime(01/01/2023),
                Termino = new DateTime(02/01/2023) },
             new Disciplinas { Disciplina = "Apreindizagem Por Competências",
                Inicio = new DateTime(02/01/2023),
                Termino = new DateTime(03/01/2023) },
             new Disciplinas { Disciplina = "Pratica Docente à Distância",
                Inicio = new DateTime(02/01/2023),
                Termino = new DateTime(03/01/2023) },
             new Disciplinas { Disciplina = "Legislação e diretrizes da Educação Profissional e tecnologica",
                Inicio = new DateTime(04/01/2023),
                Termino = new DateTime(05/01/2023) },
             new Disciplinas { Disciplina = "Ambientes de Aprendizagem Inovativos",
                Inicio = new DateTime(05/01/2023),
                Termino = new DateTime(06/01/2023) },
        };


        static void Main(string[] args)
        {
            var OrdemIncio = from d in disciplinas                            
                              orderby d.Termino ascending
                              select d;
            foreach (var d in OrdemIncio)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
                
            
        }
    }
}
