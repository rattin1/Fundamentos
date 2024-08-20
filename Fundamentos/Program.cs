using Fundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        // Exemplo de comentario em uma linha

        /*
         * Comentarios de Bloco
         */

        /*
        Livro livro1 = new Livro();

        livro1.Titulo = "As vantagens de ser invisível";
        livro1.Autor = "Stephen Chbosky";
        livro1.Editora = "Rocco";
        livro1.AnoLancamento = 2001;

        Livro livro2 = new Livro();
        livro2.Titulo = "Programando em C#";
        livro2.Editora = "Editora Nova";
        livro2.AnoLancamento = 1982;
        livro2.Autor = "Gustavo Castello";

        Livro livro3 = new Livro();
        livro3.Titulo = "Pai Rico Pai Pobre";
        livro3.Editora = "Minha Editora";
        livro3.AnoLancamento = 2000;
        livro3.Autor = "Cristiano de Paula";
        */


        // Alunos

        //// Instanciar um objeto do Tipo Aluno
        //Aluno aluno1 = new Aluno();

        //// Preencher os atributos do objeto
        //aluno1.Nome = "Ryan Rattini Ribeiro";
        //aluno1.RM = "4797";
        //aluno1.Email = "ryan.rattini2@portalsesisp.org.br";
        //aluno1.Nascimento = new DateOnly(2008, 02, 03);

        //Aluno aluno2 = new Aluno();

        //aluno2.Nome = "Thiago Mazzi";
        //aluno2.RM = "4368";
        //aluno2.Email = "thiago.mazzi@portalsesisp.org.br";
        //aluno2.Nascimento = new DateOnly(2007, 07, 31);

        //Aluno aluno3 = new Aluno();

        //aluno3.Nome = "Bruno Martins Alvez Junior";
        //aluno3.RM = "4382";
        //aluno3.Email = "bruno.martins@portalsesisp.org.br";
        //aluno3.Nascimento = new DateOnly(2007, 08, 28);


        //// Imprimir na Tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("Nome: " + aluno1.RM);
        //Console.WriteLine("Nome: " + aluno1.Email);
        //Console.WriteLine("Nome: " + aluno1.Nascimento);
        //Console.WriteLine("===================================================");

        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("Nome: " + aluno2.RM);
        //Console.WriteLine("Nome: " + aluno2.Email);
        //Console.WriteLine("Nome: " + aluno2.Nascimento);
        //Console.WriteLine("===================================================");

        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("Nome: " + aluno3.RM);
        //Console.WriteLine("Nome: " + aluno3.Email);
        //Console.WriteLine("Nome: " + aluno3.Nascimento);
        //Console.WriteLine("===================================================");


        // Instanciar um Objeto do Tipo Produto
        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;
        //// Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;
        //// Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //Console.WriteLine("===================================================");
        //Console.WriteLine();


        //// Instanciar um objeto do tipo Carro
        //Carro carro1 = new Carro();
        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();
        //Console.WriteLine("===================================================");
        //Console.WriteLine();


        //// Exercício 
        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.Nome = "Mauro";
        //pessoa1.Idade = 32;

        //pessoa1.InfoIdade();
        //pessoa1.Envelhecer(2);
        //Console.WriteLine("===================================================");

        //Pessoa pessoa2 = new Pessoa();
        //pessoa2.Nome = "Anitta";
        //pessoa2.Idade = 58;

        //pessoa2.InfoIdade();
        //pessoa2.Envelhecer(4);
        //Console.WriteLine("===================================================");

        //Pessoa pessoa3 = new Pessoa();
        //pessoa3.Nome = "Nick";
        //pessoa3.Idade = 41;

        //pessoa3.InfoIdade();
        //pessoa3.Envelhecer(5);
        //Console.WriteLine("===================================================");
        //Console.WriteLine();

        //Funcionario f1 = new Funcionario();
        //f1.Nome = "Luis Santos";
        //f1.Idade = 20;
        //f1.Cargo = "Aprendiz";
        //f1.Salario = 1400.00;

        //f1.ApresentarSe();
        //Console.WriteLine();

        //Console.WriteLine("===================================================");
        //Console.WriteLine("~                                                 ~");
        //Console.WriteLine("===================================================");

        ////Instanciar um Objeto
        //Animal animal1 = new Animal();

        ////Inserindo Dados no Atributo
        //animal1.Especie = "Cachorro";

        ////Chamando o Metodo do Objeto
        //animal1.emitirSom();

        ////Imprimindo a informação na tela
        //Console.WriteLine("O Animal " + animal1.Especie + " emitiu um som");

        //Gato gato1 = new Gato();
        //gato1.Nome = "Frajola";

        //Console.WriteLine(gato1.Nome);
        //gato1.emitirSom();
        //Console.WriteLine();

        //Porco Porco1 = new Porco();
        //Porco1.Nome = "Gaguinho";

        //Console.WriteLine(Porco1.Nome);
        //Porco1.emitirSom();
        //Console.WriteLine();

        //Galinha galinha1 = new Galinha();
        //galinha1.Nome = "Galinha";

        //Console.WriteLine(galinha1.Nome);
        //galinha1.emitirSom();
        //Console.WriteLine();

        Mago mago1 = new Mago();
        mago1.Nome = "Grande Mago";
        mago1.Nivel = 45;
        mago1.Forca = 47;
        mago1.Inteligencia = 76;
        mago1.Vida = 30;
        mago1.Agilidade = 53;
        mago1.apresentarSe();
        Console.WriteLine("==============================");

        Elfo elfo1 = new Elfo();
        elfo1.Nome = "Elfanderson";
        elfo1.Nivel = 40;
        elfo1.Forca = 67;
        elfo1.Inteligencia = 60;
        elfo1.Vida = 35;
        elfo1.Agilidade = 95;
        elfo1.apresentarSe();
        Console.WriteLine("==============================");

        elfo1.batalhar(mago1);




    }
}