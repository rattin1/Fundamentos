using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Animal
    {
        // Declaração de Atributo
        public string Especie { get; set; }
        public string Nome { get; set; }
        // Declaracao de um Metodo
        public abstract void emitirSom();

    }
}
