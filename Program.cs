using Orientando_Objetos;

Aluno res = new Aluno();
bool concluido = false;
do
{
Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@$"
========================================
| Seja bem vindo(a)                    |
|                                      |
| Escolha uma opcao:                   |
|                                      |
| 1) Cadastrar aluno                   |
| 2) Mostrar dados do aluno cadastrado |
| 0) Sair                              |
========================================
");
Console.ResetColor();

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Digite os seus dados a seguir");

            Console.WriteLine($"Nome:");
            res.nome = Console.ReadLine();

            Console.WriteLine($"Curso:");
            res.curso = Console.ReadLine();

            Console.WriteLine($"Idade:");
            res.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"RG");
            res.RG = int.Parse(Console.ReadLine());

            Console.WriteLine($"Bolsista? (s / n)");

            break;
        case "2":
            Console.WriteLine(res.nome);
            Console.WriteLine(res.curso);
            Console.WriteLine(res.idade);
            Console.WriteLine(res.RG);
            Console.WriteLine(res.bolsista);
            res.VerMedia();

            break;
        case "0":
            concluido = true;
            break;
        default:
            break;
    }
} while (concluido == false);