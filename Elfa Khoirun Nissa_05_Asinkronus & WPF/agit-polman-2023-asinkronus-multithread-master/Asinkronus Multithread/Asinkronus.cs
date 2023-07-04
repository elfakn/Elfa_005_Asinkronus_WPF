using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asinkronus_Multithread
{
    internal class Asinkronus
    {
        public static async Task FirstAsync()
        {
            //Console.WriteLine("First Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(4000);
            Console.WriteLine("First Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task SecondAsync()
        {
            //Console.WriteLine("Second Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(2000);
            Console.WriteLine("Second Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task ThirdAsync()
        {
            //Console.WriteLine("Third Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Third Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task FourthAsycn()
        {
            await Task.Delay(6000);
            Console.WriteLine("Saya Elfa Khoirun Nissa | Id : " + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task FiveAsycn()
        {
            await Task.Delay(5000);
            Console.WriteLine("Saya dari prodi MI | Id : " + Thread.CurrentThread.ManagedThreadId);
        }

        public static async Task ExecuteAsyncFunctions()
        {
            var firstAsync = FirstAsync();
            var secondAsync = SecondAsync();
            var thirdAsync = ThirdAsync();
            var fourthAsycn = FourthAsycn();
            var fiveAsycn = FiveAsycn();
            await Task.WhenAll(firstAsync, secondAsync, thirdAsync, fourthAsycn, fiveAsycn);
        }
    }
}
