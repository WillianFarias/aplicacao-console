using System;

namespace revisao_cshap
{
  class Program
  {
    static void Main(string[] args)
    {

    Aluno[] alunos = new Aluno[5];
    string opcaoUsuario = obterOpcaoUsuario();
    var indiceAluno = 0;

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine("Informe o nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");            
            if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                aluno.Nota = nota;
            } else {
                throw new ArgumentException("Valor de nota deve ser decimal");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;
            break;

          case "2":
            //TODO: listar alunos
            break;

          case "3":
            //TODO: calcular média geral
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        Console.WriteLine();
        opcaoUsuario = obterOpcaoUsuario();
      }
    }

    private static string obterOpcaoUsuario()
    {
      Console.WriteLine("Informe a opção desejava: ");
      Console.WriteLine("1 - Inserir novo aluno: ");
      Console.WriteLine("2 - Listar alunos: ");
      Console.WriteLine("3 - Calcular média geral: ");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      return opcaoUsuario;
    }
  }
}
