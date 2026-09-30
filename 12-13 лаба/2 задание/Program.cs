using System.Security.Cryptography.X509Certificates;
namespace fedyushkin
{
    using System;
    //using Colorful.Console;
    public class Program
    {

        static void Main(string[] args)
        {


            float num_1 = Convert.ToSingle(Console.ReadLine());
            float num_2 = Convert.ToSingle(Console.ReadLine());
            float num_3 = Convert.ToSingle(Console.ReadLine());

            if ((num_1 > num_2 && num_1 < num_3)|| (num_1 < num_2 && num_1 > num_3)) { cout(num_1.ToString()); }
            else if ((num_2 > num_1 && num_2 < num_3) || (num_2 < num_1 && num_2 > num_3)) { cout(num_2.ToString()); }
            else { cout(num_3.ToString()); }




        }//-----------------------------------------------------------------------------------
        static void cout(string text , int sleep = 0){
            Random random = new Random();
            foreach (var i in text){
            byte g = (byte)random.Next(20, 70);
            byte b = (byte)random.Next(70, 240);
                if (sleep > 0) { Thread.Sleep(sleep); }
            Console.Write("\x1b[38;2;255;" + (b-g) + ";" + b + "m" + $"{i}\x1b[39m");
            }
        }
        static void coutln(string text, int sleep = 0) {cout(text , sleep);Console.WriteLine();}

        static public int svo() { return 200; }


    }

}
/*  Metka:

            Console.ForegroundColor = ConsoleColor.Gray;
            

            

                //delegate shkibidi_toilet = func;

                float result = func(num_1, num_2, input);

                

            goto Metka;*/