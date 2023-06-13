using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer.State
{
    internal class UserInput
    {
        private static UserInput userInput;
        private App app;
        private UserInput(App _app)
        {
            app = _app;
            StartUserInput();
        }
        public static UserInput GetUserInput(App _app)
        {
            if(userInput == null)
            {
                userInput = new UserInput(_app);
            }
            return userInput;
        }
        public void StartUserInput()
        {
            while (true)
            {
                
                switch (Console.ReadLine())
                {
                    case "1":
                        app.Btn1();
                        break;
                    case "2":
                        app.Btn2();
                        break;
                    case "3":
                        app.Btn3();
                        break;
                    case "4":
                        app.Btn4();
                        break;
                    case "5":
                        app.Btn5();
                        break;
                    case "6":
                        app.Btn6();
                        break;
                    case "7":
                        app.Btn7();
                        break;
                    case "8":
                        app.Btn8();
                        break;
                    case "9":
                        app.Btn9();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
