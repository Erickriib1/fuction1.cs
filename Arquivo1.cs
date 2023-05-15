// See https://aka.ms/new-console-template for more information

int menu()
{
    string entrada;
    int op = 0;

    do
    {
        Console.WriteLine("1 - Calcular media entre dois numeros");
        Console.WriteLine("2- calcular fatoria de um numero");
        Console.WriteLine("3- calcular o exponencial");
        Console.WriteLine("4- calcular o seno");
        Console.WriteLine("5- Calcular o coseno");
        Console.WriteLine("6- Calcular a raiz quadrada");
        Console.WriteLine("7- calcular o logaritmo");
        Console.WriteLine(" digite X para sair");

        entrada = Console.ReadLine();

        // try parse aceita qualquer digito feito pelo usuario
        int.TryParse(entrada, out op);
    } while (entrada[0] != 'x' && (op < 1 || op > 7));
    return op;
}

int media(int n1, int n2)
{
    int med = 0;

    med = (n1 + n2) / 2;

    return med;
}

int fatorial(int n1)
{
    int fat = 1;

    for (int i = 2; i <= n1; i++)
    {
        fat *= i;
    }
    return fat;
}

double exponencial(int n1, int n2)
{
    double exp = Math.Pow(n1, n2);

    return exp;
}

double seno(int n1)
{
    double radianos = n1 * Math.PI / 180;

    double resseno = Math.Sin(radianos);

    return resseno;
}

double coseno(int n1)
{
    double radianos = n1 * Math.PI / 180;

    double rescos = Math.Cos(radianos);

    return rescos;
}

double raiz(int n1)
{
    double rai = Math.Sqrt(n1);

    return rai;
}

double logaritmo(int n1)
{
    double log = Math.Log(n1);

    return log;
}

int opcao = 0;



do
{
    opcao = menu();

    switch (opcao)
    {
        case 1:

            Console.WriteLine("Digite dois valor para obter a media do mesmo");
            int resmed = int.Parse(Console.ReadLine());
            int resmed2 = int.Parse(Console.ReadLine());

            int res1 = media(resmed, resmed2);

            Console.WriteLine($"A media do número informado é {res1}");

            break;

        case 2:

            Console.WriteLine("Digite um numero para obter o fatorial");
            int resfat = int.Parse(Console.ReadLine());

            int res2 = fatorial(resfat);

            Console.WriteLine($"O fatorial do numero é {res2}");

            break;

        case 3:

            Console.WriteLine("Digite o primeiro numero e o segundo o elevado para obter o exponencial");
            int resexp = int.Parse(Console.ReadLine());
            int resexp2 = int.Parse(Console.ReadLine());

            double res3 = exponencial(resexp, resexp2);

            Console.WriteLine($"O exponencial do numero é {res3}");

            break;

        case 4:

            Console.WriteLine("Digite o valor em graus para obter o seno");
            int ressen = int.Parse(Console.ReadLine());

            double resp4 = seno(ressen);

            Console.WriteLine($"O coseno do numero é {resp4.ToString("0.0000")}");

            break;

        case 5:

            Console.WriteLine("Digite o valor em graus para obter o coseno");
            int rescos = int.Parse(Console.ReadLine());

            double resp5 = coseno(rescos);

            Console.WriteLine($"O coseno do numero é {resp5.ToString("0.0000")}");

            break;

        case 6:

            Console.WriteLine("Digite o valor  para obter a raiz quadrada");
            int resraiz = int.Parse(Console.ReadLine());

            double resp6 = raiz(resraiz);

            Console.WriteLine($"A raiz quadrada é {resp6}");

            break;

        case 7:

            Console.WriteLine("Digite o valor  para obter o logaritmo do mesmo");
            int reslog = int.Parse(Console.ReadLine());

            double resp7 = logaritmo(reslog);

            Console.WriteLine($"O logaritimo do numerom  é {resp7}");

            break;


    }
} while (opcao != 0);
