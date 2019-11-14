using System;
using System.Threading.Tasks;

namespace BreakfastAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 朝食の準備を開始する
            Console.WriteLine("Start!");

            // 卵を焼き始める
            Console.WriteLine("egg fry start");
            Task<Egg> eggTask = FryEggs();
  
            // ベーコンを焼き始める
            Console.WriteLine("bacon fry start");
            Task<Bacon> baconTask = FryBacon();

            // パンを焼き始める
            Console.WriteLine("toast start");
            Task<Toast> toastTask = ToastBread();

            // パンが焼き終わるのを待つ
            //Toast toast = await toastTask;
            Toast toast = toastTask.Result;

            // 焼き終わったパンにバターとジャムを塗る
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            // オレンジジュースを注ぐ
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            // コーヒーを注ぐ
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            // 卵が焼き終わるのを待つ
            //Egg eggs = await eggTask;
            Egg egg = eggTask.Result;
            Console.WriteLine("eggs are ready");

            // ベーコンが焼き終わるのを待つ
            //Bacon bacon = await baconTask;
            Bacon bacon = baconTask.Result;
            Console.WriteLine("bacon is ready");

            // 朝食できた！
            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            System.Threading.Thread.Sleep(1000);
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            System.Threading.Thread.Sleep(1000);
        }

        private static void ApplyButter(Toast toast)
        {
            System.Threading.Thread.Sleep(1000);
        }

        private async static Task<Toast> ToastBread()
        {
            await Task.Delay(10000);
            return new Toast();
        }

        private async static Task<Bacon> FryBacon()
        {
            await Task.Delay(5000);
            return new Bacon();
        }

        private async static Task<Egg> FryEggs()
        {
            await Task.Delay(15000);
            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            System.Threading.Thread.Sleep(1000);
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