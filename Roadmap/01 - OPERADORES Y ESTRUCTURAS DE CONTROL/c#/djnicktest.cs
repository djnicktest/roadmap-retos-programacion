// Operadores Aritmeticos //

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 3, b = 10;
        int suma = a + b; // suma

        int c = 15, d = 5;
        int Resta = c - d; // Resta

        int e = 8, f = 30;
        int Multi = e * f; // Multiplicacion

        int g = 250, h = 6;
        int div = g / h; // Division

        int i = 12, j = 4;
        int mod = i % j; // Modulo o resto

        // Operadores de Asignacion //

        int y = 500; // Asignacion de valor a una variable 

        int aa = 20;
        int aa += 12;// suma el valor de la derecha a la variable de la izquierda y asigna el resultado a esa variabe aa = 32 

        int bb = 30;
        int bb -= 15; // resta el valor de la derecha a la variable de la izquierda y asigna el resultado a esa variable bb = 15 

        int cc = 6;
        int cc *= 3; // multiplica el valor de la derecha a la variable de la izquierda y asigna el resultado a esa variable cc = 18 

        int dd = 8;
        int dd /= 4; // divide el valor de la derecha a la variable de la izquierda y asigna el resultado a esa variable dd = 2
     // ------------------------------------------------------------------------------------------------------------------------------------ //
                     // Operadores de Comparacion // 

        // operador de igual que  (==) // 
        int xx = 30;
        int yy = 20;
        bool resultadoIgualdad = xx == yy;
        Console.Write(resultadoIgualdad); // deberia imprimir false ya que 30 no es igual a 20 //

        // Operador Distinto que (!=) // 
        int jj = 15, ll = 17;
        bool resultadodistinto = jj != ll;
        Console.Write(resultadodistinto); // deberia imprimir verdadero ya que 15 es distinto a 17 //

        // Operador Mayor que (>) // 
        int gg = 37, kk = 40;
        bool resultadoMayorQue = gg > kk;
        Console.Wirite(resultadoMayorQue); // deberia imprimir false ya que 37 no es mayor que 40 //

        // Operador Menor Que (<) //
        bool resultadoMenorQue = yy < xx; 
        Console.Write ( resultadoMenorQue); // deberia imprimir Verdadero ya que 20 m es menor que 30//

        // Operador Mayor o Igual Que (>=) //
        bool resMayorIgual = jj >= 15;
        Console.Write ( resMayorIgual ); // deberia imprimir verdadero ya que  15 es igual que jj // 

        // Operador Menor o Igual Que (<=) // 
        bool resMenorIgual = kk <= gg;
        Console.Write ( resMenorIgual ); // deberia  imprimir falso ya que 40 no es menor ni igual a 37 // 
// --------------------------------------------------------------------------------------------------------------------------// 
                    // Operadores Logicos // 
       // Operador "Y" (&&), Operador "O" (||), Operador "negacion" (!) //
        bool Valor1 = true;
        bool Valor2 = false;

        Console.Wirite ("a && b:" + (a && b));// las condiciones deben ser verdaderas para que sea verdadera
        Console.Wirite ("a || b:" + (a || b));// por lo menos una de las condiciones debe ser verdadera para que sea verdadera
        Console.Wirite ("!a:" + (!a));// si una condicion utiliza negacion la transforma en lo conterario, si es verdadera pasaria a ser alsa

        Console.Readline();
//-------------------------------------------------------------------------------------------------------------------------------//

        //Tipos de estructuras de Control// 

        // if-else// 

        int yearBirth, currentYear = 2024, age;
        Console.WriteLine ("Please enter your year of brith: ");
        yearBirth = int.Parse (Console.Readline ());
        age = currentYear - yearBirth;
        
        if (age >= 18)
        {
            Console.WriteLine ("he's older");
        }
        else
            Console.WriteLine ("is not of legal age");

        


    }
}