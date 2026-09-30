using System.Security.Cryptography.X509Certificates;
namespace fedyushkin
{
    using System;
    //using Colorful.Console;
    public class Program
    {

        static void Main(string[] args)
        {
            //задание 3
            int count_texts;
            float  V_srednem_slov;

            float tokenov_na_sovo;


            cout("введите колличество текстов:");

            count_texts = Convert.ToInt32(Console.ReadLine());


            cout("введите  среднее колличество слов на текст:");


            V_srednem_slov = Convert.ToSingle(Console.ReadLine());

            cout("введите колличество токенов на 1 слово:");

            tokenov_na_sovo = Convert.ToSingle(Console.ReadLine());


            float words = count_texts * V_srednem_slov;

            float Tokens = words * tokenov_na_sovo;

            coutln($"всего слов {words}.");

            coutln($"всего токенов {Tokens}.");

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