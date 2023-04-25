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
            res.RG = Console.ReadLine();

            Console.WriteLine($"Digite sua media final? (1 a 10)");
            res.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine($"Bolsista? (s / n)");
            string bolsa = Console.ReadLine().ToLower();
            res.bolsista = bolsa == "s" ? true : false;

            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"===============================");

            Console.WriteLine(res.nome);
            Console.WriteLine(res.curso);
            Console.WriteLine(res.idade);
            Console.WriteLine(res.RG);
            Console.WriteLine(res.bolsista);
            res.VerMediaFinal();
            Console.WriteLine($"{res.VerMensaildade()}");

            Console.WriteLine($"===============================");
            Console.ResetColor();

            break;
        case "0":
            Console.WriteLine($"Ate mais!");
            concluido = true;
            break;
        default:
            concluido = true;
            break;
    }
} while (concluido == false);