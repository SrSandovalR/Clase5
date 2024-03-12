using System.Numerics;

static void suma()
{
    int num2, num1, resultado = 0;

    Console.WriteLine("Ingrese un numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}


static void numero()
{
    int num2, num1, resultado = 0;
    Console.WriteLine("Ingrese un numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    resultado = num2;
}

static string nombre()
{
    Console.WriteLine("Ingrese un nombre: ");
    string nombre = Console.ReadLine();

    return nombre;

}

static void año()
{

    int año_nacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - año_nacimiento;
    Console.WriteLine("su edad es: " + edad);

}



static void interfaz()
{
    int opc = 0;
    do
    {
        Console.WriteLine("1. Ejercicio que muestra cual es el numero mayor.");
        Console.WriteLine("2. Adivinar el numero.");
        Console.WriteLine("3. Contador de palabras.");
        Console.WriteLine("4. Polindromos.");
        Console.WriteLine("0. Salir del programa.");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:

                int numeropositivo = 0;
                int mayor = int.MinValue;
                int menor = int.MaxValue;

                do {

                    Console.WriteLine("Ingrese numeros positivos: ");
                    numeropositivo = Convert.ToInt32(Console.ReadLine());

                    if (numeropositivo > 0)
                    {
                        if (numeropositivo > mayor)
                        {
                            mayor = numeropositivo;
                        }

                        if (numeropositivo < menor)
                        {
                            menor = numeropositivo;
                        }
                    }


                } while (numeropositivo != 0);



                
                Console.WriteLine("El numero mayor es: "+ mayor );
                Console.WriteLine("El numero menor es: " + menor);


                break;

        


                case 2: 
                    
                   
                Console.Clear();

                Console.WriteLine("Ingrese un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplique el numero por 2: ");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sumele 8 al numero: ");
                int sumale8 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplique el numero por 5: ");
                int Multi5 = Convert.ToInt32(Console.ReadLine());

                int resultado = numero * x2;
                resultado = resultado + sumale8;
                resultado = resultado * Multi5;

                Console.Clear() ;

                Console.WriteLine("EL resultado es : " + resultado);
                resultado = resultado / 10;
                resultado = resultado - 4;
                Console.WriteLine("El numero que pensaste es: " + resultado);

                

                    break;


                case 3:

                    Console.WriteLine("Escribe una palabra: ");
                    string palabras = Console.ReadLine();
                    int numerodepalabras = palabras.Length;

                    
                    
                    int numerodevocales = 0;
                
                for (int i = 0; i < palabras.Length; i++)
                {

                    Char letra = char.ToLower(palabras[i]);
                  if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                                    {
                                        numerodevocales++;
                                    }

                }
                    

                Console.WriteLine("El numero de Vocales es: " + numerodevocales);
                Console.WriteLine("El numero de palabras es: " + numerodepalabras);
                
                
                break;
                case 4:

                Console.Write("ingrese una palabra: ");
                string palabra = Console.ReadLine();

                bool esPalindromo = true;
                for (int i = 0; i < palabra.Length / 2; i++)
                {
                    if (palabra[i] != palabra[palabra.Length - 1 - i])
                    {
                        esPalindromo = false;
                        break;
                    }
                }


                if (esPalindromo)
                {
                    Console.WriteLine("La palabra es un palíndromo.");
                }
                else
                {
                    Console.WriteLine("La palabra no es un palíndromo.");
                }


                break;
        }
        return;

    } while (opc <= 0);

}




static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado = (num1 + num2 + num3);
    return resultado;


}




string datos = nombre();
int promedio = sumatoria(20, 25, 40) / 3;
Console.WriteLine("promedio: " + promedio);



static void nummayor()
{

    int num, max, mini;
    int pc = 0;
    do
    {


        Console.WriteLine("Escribre un numero: ");
        num = Convert.ToInt32(Console.ReadLine());
        max = 0;
        mini = 100;

        if (num > max)
        {
            max = mini;
            break;
        }


    } while (pc <= 1);


    Console.WriteLine(max);

}








