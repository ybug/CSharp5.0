using System;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minue(int a, int b)
        {
            return a - b;
        }
    }

    delegate int Compare<T>(T a, T b);
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHapped;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if ((temp != 0) && (temp % 3 == 0))
            {
                SomethingHapped(string.Format("{0} : 짝", number));
            }
        }
    }


    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }

                    Print<T>(DataSet);
                }

            }
        }

        static void Print<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            Console.WriteLine();
        }

        static void Delegate()
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minue);
            Console.WriteLine(Callback(7, 5));
        }

        static void GenericDelegate()
        {
            int[] array = { 3, 7, 4, 2, 10 };
            BubbleSort<int>(array, new Compare<int>(AscendCompare));
        }

        static void Main(string[] args)
        {
            //Delegate();
            //GenericDelegate();
            EventTest();
        }


        private static void EventTest()
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHapped += new EventHandler(MyHandler);
        }

        private static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
    }
}
