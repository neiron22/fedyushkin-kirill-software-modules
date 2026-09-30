using System.Security.Cryptography.X509Certificates;
namespace fedyushkin
{
    using System;
    //using Colorful.Console;
    public class Program
    {

        static void Main(string[] args)
        {
            double[] vec_1 = { 0, 0, 0 }, vec_2 = { 0, 0, 0 };

            coutln("введите первый рёхмерный вектор:" , 1);
            for (int i = 0; i < 3; i++)
            { vec_1[i] = Convert.ToDouble(Console.ReadLine());}
            coutln("введите второй рёхмерный вектор:", 1);
            for(int i = 0;i< 3; i ++)
            {vec_2[i] = Convert.ToDouble(Console.ReadLine()); }




            double len_vector_1 = Math.Sqrt(((vec_1[0] * vec_1[0]) + ( vec_1[1] * vec_1[1]) + (vec_1[2] * vec_1[2])));

            double len_vector_2 = Math.Sqrt(((vec_2[0] * vec_2[0]) + (vec_2[1] * vec_2[1]) + (vec_2[2] * vec_2[2])));
            
            coutln($"их длины :{len_vector_1} и {len_vector_2}");


            len_vector_1 = Math.Abs(len_vector_1);

            len_vector_2 = Math.Abs(len_vector_2);

            double[] normal_vec_1 = { vec_1[0]* len_vector_1, vec_1[1] * len_vector_1, vec_1[2] * len_vector_1 } ;

            double[] normal_vec_2 = { vec_2[0] * len_vector_2, vec_2[1] * len_vector_2, vec_2[2] * len_vector_2 };

            coutln("их нормализованные версии :");
            for(int i = 0; i < 3; i++)
            {
                cout("  " + normal_vec_1[i].ToString());
            }coutln("\n");
            for (int i = 0; i < 3; i++)
            {
                cout("  " + normal_vec_2[i].ToString());
            }
            coutln("\n");


            double[] skalar_sun_vec = {0,0,0};

            for(int i = 0; i < 3; i++){

                skalar_sun_vec[i] = normal_vec_1[i] + normal_vec_2[i];
            }
            coutln("скалярное произведение нормализованных ерсий трёхмерных векторов:");
            for (int i = 0; i < 3; i++) { cout("  " + skalar_sun_vec[i].ToString()); }
        }

        //-----------------------------------------------------------------------------------




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
   



    }

}
/*  Metka:

            Console.ForegroundColor = ConsoleColor.Gray;
            

            

                //delegate shkibidi_toilet = func;

                float result = func(num_1, num_2, input);

                

            goto Metka;*/