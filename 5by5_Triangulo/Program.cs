//  Faça um programa que leia os três lados de um triangulo e informe o tipo dele

float lado1, lado2, lado3;

int option;

do
{

    do
    {
        Console.WriteLine("Digite o primeiro lado:");
        lado1 = float.Parse(Console.ReadLine());

        if (lado1 <= 0 )
        {
            Console.WriteLine("\nO lado do triângulo deve ser maior que zero!\n");
        }
    } while (lado1 <= 0);

    do
    {
        Console.WriteLine("Digite o segundo lado:");
        lado2 = float.Parse(Console.ReadLine());

        if (lado2 <= 0)
        {
            Console.WriteLine("\nO lado do triângulo deve ser maior que zero!\n");
        }
    } while (lado2 <= 0);

    do
    {
        Console.WriteLine("Digite o terceiro lado:");
        lado3 = float.Parse(Console.ReadLine());

        if (lado3 <= 0)
        {
            Console.WriteLine("\nO lado do triângulo deve ser maior que zero!\n");
        }
    } while (lado3 <= 0);

    if(lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado1 + lado2))
    {
        if(lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("\nTriângulo equilátero\n");
        }else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
        {
            Console.WriteLine("\nTriângulo escaleno\n");
        }
        else
        {
            Console.WriteLine("\nTriângulo isósceles");
        }
    }
    else
    {
        Console.WriteLine("\nImpossível formar um triângulo com estes lados\n");
    }

    do
    {
        Console.WriteLine("\nDeseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);