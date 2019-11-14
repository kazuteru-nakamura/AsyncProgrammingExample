using System;
using System.Threading;

namespace Breakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            // 朝食の準備を開始する
            Console.WriteLine("Start!");

            // コーヒーを注ぐ
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            // 卵を焼き始める
            Console.WriteLine("egg fry start");
            Egg eggs = FryEggs();
            Console.WriteLine("eggs are ready");

            // ベーコンを焼き始める
            Console.WriteLine("bacon fry start");
            Bacon bacon = FryBacon();
            Console.WriteLine("bacon is ready");

            // パンを焼き始める
            Toast toast = ToastBread();

            // 焼き終わったパンにバターとジャムを塗る
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            // オレンジジュースを注ぐ
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            // 朝食できた！
            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Thread.Sleep(1000);
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Thread.Sleep(1000);
        }

        private static void ApplyButter(Toast toast)
        {
            Thread.Sleep(1000);
        }

        private static Toast ToastBread()
        {
            Thread.Sleep(10000);
            return new Toast();
        }

        private static Bacon FryBacon()
        {
            Thread.Sleep(5000);
            return new Bacon();
        }

        private static Egg FryEggs()
        {
            Thread.Sleep(15000);
            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Thread.Sleep(1000);
            return new Coffee();
        }
    }

    internal class Juice
    {
    }

    internal class Toast
    {
    }

    internal class Bacon
    {
    }

    internal class Egg
    {
    }

    internal class Coffee
    {
    }
}
