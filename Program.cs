using System;

namespace OPERATORLER
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama            

            Console.WriteLine(" ******Atama Ve İşlemli Atama Operatörleri****** ");
            int x = 3;
            int y = 5;
            y = y + 2;
            System.Console.WriteLine(y);
            y += 2;
            System.Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);


            // Mantıksal Operatörler => ||, &&, !
            Console.WriteLine(" ******Mantıksal Operatörler****** ");
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // İlişkisel Operatörler => <, >, <=, >=, ==, !=
            Console.WriteLine(" ******İlişkisel Operatörler****** ");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler => +, -, *, /
            Console.WriteLine(" ******Aritmetik Operatörler****** ");
            int sayı1 = 5;
            int sayı2 = 8;
            int sonuc1 = sayı1 / sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1 + sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1 * sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);


            Console.ReadLine();

        }
    }
}