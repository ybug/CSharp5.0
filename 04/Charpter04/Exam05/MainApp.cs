using System;

namespace Exam05
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    {
                        Exam01();
                    }
                    break;
                case "2":
                    {
                        Exam02();
                    }
                    break;
                case "3":
                    {
                        Exam03();
                    }
                    break;
                case "4":
                    {
                    }
                    break;

                default:
                    break;
            }
        }

        private static void Exam03()
        {
            int i = 0;

            while (i < 5)
            {
                int j = 0;

                while (true)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
            
            //throw new NotImplementedException();
        }

        private static void Exam02()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");

            }

            //throw new NotImplementedException();
        }

        private static void Exam01()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            //throw new NotImplementedException();
        }
    }
}
