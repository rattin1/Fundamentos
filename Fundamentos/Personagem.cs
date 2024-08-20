using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        // Atributos
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }
        // Métodos
        public virtual void apresentarSe() { }
        public virtual void evoluir()
        {
            this.Nivel += 1;
        }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + this.Forca + this.Nivel + this.Agilidade + this.Vida) / 5;
            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Vida + this.Agilidade + this.Nivel + this.Inteligencia + this.Forca) / 5;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
                Console.WriteLine("================================================");

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O Personagem " + p.Nome + " Venceu!");
                    vencedor = true;
                }

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O Personagem " + this.Nome + " Venceu!");
                    vencedor = true;
                }
            }



        }
    }
}
