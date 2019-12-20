using System;

namespace CompitiVacanze1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //stampa 31 1 perche è il valore massimo che si può ottenere perchè l'ultimo bit viene utilizzato solamente per il segno
            Console.WriteLine(a + 1);// da errore perchè venendo utilizzato l'ultimo bit come segno il risultato  
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2)); 
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1; // not
            //value=value +1
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
        }
    }
}
