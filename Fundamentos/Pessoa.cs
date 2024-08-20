using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void InfoIdade()
        {
            Console.WriteLine("A pessoa " + this.Nome + " tem " + this.Idade + " anos.");
        }
        public void Envelhecer(int anos)
        {
            this.Idade += anos;
            Console.WriteLine("O tempo passou, agora " + this.Nome + " tem " + this.Idade + " anos.");
        }

    }
}
