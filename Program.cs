ConsoleKeyInfo input;

do
{
    Console.WriteLine("Menu Estudos Plataforma Balta");
    Console.WriteLine("=============================");

    Console.WriteLine();

    Console.WriteLine("[A] Módulo de Estudos A");
    Console.WriteLine("[B] Módulo de Estudos B");
    Console.WriteLine("[C] Módulo de Estudos C");

    Console.WriteLine();
    Console.WriteLine("[Esc] para Sair");
    Console.WriteLine();

    input = Console.ReadKey();

    switch (input.Key)
    {
        case ConsoleKey.A:
            Console.WriteLine();
            Console.WriteLine(ModuloA.MetodoA());
            Console.WriteLine();
            break;

        case ConsoleKey.B:
            Console.WriteLine();
            Console.WriteLine(ModuloB.MetodoB());
            Console.WriteLine();
            break;

        case ConsoleKey.C:
            Console.WriteLine();
            Console.WriteLine(ModuloC.MetodoC());
            Console.WriteLine();
            break;

        case ConsoleKey.Escape:
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Opção inválida.");
            Console.WriteLine();
            break;
    }
} while (input.Key != ConsoleKey.Escape);