using System;

namespace Factory
{
    internal static class Program
    {
        private static void Main()
        {
            var hardBoyDev = new NormalAppCreator("Real developer");
            hardBoyDev.CreateApp();

            var lgbtDeveloper = new ShitAppCreator("LGBT piece of shit");
            lgbtDeveloper.CreateApp();
        }
    }

    internal abstract class Language
    {
    }

    internal class Java : Language
    {
        public Java()
        {
            try
            {
                throw new Exception("So... shit happens... this is Java...");
            }
            catch (Exception e)
            {
                Console.WriteLine($"[exception] => {e.Message}");
            }

            Console.WriteLine("App has been not created...");
        }
    }

    internal class Csharp : Language
    {
        public Csharp()
        {
            Console.WriteLine("Perfect C# app has been successfully created!");
        }
    }

    internal abstract class Developer
    {
        protected Developer(string name)
        {
            Console.WriteLine($"{name} is working...");
        }
        
        public abstract Language CreateApp();
    }

    internal class NormalAppCreator : Developer
    {
        public NormalAppCreator(string name) : base(name)
        {
        }

        public override Language CreateApp()
        {
            return new Csharp();
        }
    }

    internal class ShitAppCreator : Developer
    {
        public ShitAppCreator(string name) : base(name)
        {
        }

        public override Language CreateApp()
        {
            return new Java();
        }
    }
}