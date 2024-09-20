using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => { Console.WriteLine("This is factory method"); });

            Task Action = new Task(new Action(UsingAction));
            Action.Start();
            Action.Wait(1000);

            Task del = new Task(delegate { UsingDelegate(); });
            del.Start();
            del.Wait(1000);
            Task lamd = new Task(() => UsinglemdhaANdNamed());
            lamd.Start();
            lamd.Wait(1000);
            Task Annon = new Task(() => { LamdhaANdAnnonymous(); });
            Annon.Start();
            Annon.Wait(1000);
            Async();
            Console.WriteLine("Give 1st Number =");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give 2nd Number =");
            int num2 = int.Parse(Console.ReadLine());
            SolveMath(num1, num2);
            Console.Read();
        }
        private static void UsingAction()
        {
            Console.WriteLine("This is a Action Method");
        }
        private static void UsingDelegate()
        {
            Console.WriteLine("This Is a Delegate Method");
        }
        private static void UsinglemdhaANdNamed()
        {
            Console.WriteLine("This is a lemdha and Named");
        }
        private static void LamdhaANdAnnonymous()
        {
            Console.WriteLine("This is A lemdha and Annonymous");
        }
        private static void AsyncAwait()
        {
            Console.WriteLine("This is Async ");
        }
        private static async void Async()
        {
            await Task.Run(() => AsyncAwait());
        }
        private static int Sum(int a, int b)
        {
            return a + b;
        }
        private static async void SolveMath(int num1, int num2)
        {
            int result = await Task.FromResult(Sum(num1, num2));
            await Task.Delay(1000);
            Console.WriteLine("Result= " + result.ToString());
        }

    }
}
