using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        // Metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidade em estoque é: " + this.Estoque);
        }
    }
}
