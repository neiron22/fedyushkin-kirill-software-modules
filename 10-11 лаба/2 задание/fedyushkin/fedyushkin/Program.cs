using System.Security.Cryptography.X509Certificates;
namespace fedyushkin
{
    using System;
    //using Colorful.Console;
    public class Program
    {

        static void Main(string[] args)
        {
            //задание 2

            double num1 , num2 , num3 , num4;


            coutln("введите 4 числа");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());

            double m = (num1 + num2 + num3 + num4) / 4.0d;

            coutln($"их срежнее значение :{m}");

            double dispers = (pow_2(num1 - m) + pow_2(num2 - m) + pow_2(num3 - m) + pow_2(num4 - m)) / 4;

            coutln($"их дисперсия :{dispers}");

            double standart_otkl = Math.Sqrt(dispers);

            coutln($"их стандартное отклонение :{standart_otkl}");

        }

        //-----------------------------------------------------------------------------------

        static public double pow_2(double x){
            return Math.Pow(x , 2);
        }


        static public void CALKULATE(){
            float num_1 , num_2;
            string? input;
                coutln("Введите 1 число :");
                input = Console.ReadLine();
                num_1 = Convert.ToInt32(input);
                Console.WriteLine("\n");

                cout("Ведите 2 число :");
                input = Console.ReadLine();
                num_2 = Convert.ToInt32(input);
                bool flag = num_2 != 0.0f;
                Console.WriteLine("\n");

                cout("Ведите операцию (+ , - , / , * , % , ^) :");
                input = Console.ReadLine();
                Console.WriteLine("\n");
            float result = 0.0f;

                  if (input == "/" && num_2 == 0.0f) { Console.WriteLine("На ноль делить нельзя!"); }
                else { result = input switch
                {
                    "+" => num_1 + num_2
                    , "-" => num_1 - num_2
                    , "*" => num_1 * num_2
                    , "/" => num_1 / num_2
                    , "%" => num_1 % num_2
                    , "^" => (float)Math.Pow(num_1 , num_2)
                    , _ => 67
                };}

            cout("Ответ :");
            coutln(result.ToString());
            if (result == 67.0f) { Console.WriteLine("AAAA Сикс севен!!!"); }
            else if (result == 1488.0f) { Console.WriteLine("Посхалко , включаем вентиляторы!!!"); }
            coutln("\n");}
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