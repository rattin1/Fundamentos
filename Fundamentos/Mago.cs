using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Meu nome é " + this.Nome + ", sou um mago de nível " + this.Nivel + ". Meus atributos são: \n" + this.Forca + " de força, \n" + this.Agilidade + " de agilidade, \n" + this.Inteligencia + " de Inteligência e \n" + this.Vida + " de vida.");
        }
    }
}
