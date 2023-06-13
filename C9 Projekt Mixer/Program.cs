using C9_Projekt_Mixer.State;
using System.Security.Cryptography.X509Certificates;

namespace C9_Projekt_Mixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siema, Ziemia!");

            //TestClass.Test();

            //Console.ReadKey();

            App app = App.GetApp();
            UserInput userInput = UserInput.GetUserInput(app);

        }
    }
}