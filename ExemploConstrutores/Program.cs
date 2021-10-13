using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            // ******** - Exemplo construtor - ********
            Pessoa p1 = new Pessoa();
            p1.Apresentar();

            Aluno a1 = new Aluno("Leonardo", "Buta", "Teste");
            a1.Apresentar();

            // ******** - Exemplo construtor privado e padrão singleton - ********
            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

            // ******** - Exemplo Get e Set e propriedades - ********
            Data data = new Data();
            data.SetMes(20);

            data.Mes = 20;
            System.Console.WriteLine(data.Mes);

            data.ApresentarMes();

            // ******** - Exemplo de constante - ********
            const double pi = 3.14;
            System.Console.WriteLine(pi);

            // ******** - Exemplo de Delegate - ********
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair; // <-- Multi cast

            // Chamando um delegate
            op.Invoke(10, 10);

            //Operacao op = Calculadora.Somar; <-- Também é uma maneira válida de passar um delegate
            //op(10, 10); <-- Também é uma maneira válida de chamar um delegate

            // ******** - Exemplo de Evento - ********
            Matematica m = new Matematica(10, 20);
            m.Somar();
        }
    }
}
