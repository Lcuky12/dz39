using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConvertRubToUsd = "1";
            const string CommandConvertUsdToRub = "2";
            const string CommandConvertEurToRub = "3";
            const string CommandConvertRubToEur = "4";
            const string CommandConvertUsdToEuro = "5";
            const string CommandConvertEurToUsd = "6";

            int rubToUsd = 76;
            int usdToRub = 75;
            int euroToRub = 80;
            int rubToEur = 81;
            int usdToEur = 2;
            int euroTousd = 1;
            float rubleBalance;
            float dollarBalance;
            float eurBalance;
            string userInput;
            string stopWord = "exit";
            bool canExamination = true;
            float currencyCount;

            Console.WriteLine(" Добро пожаловать в обменник валют, здесь вы можете обменять рубли на доллары, доллары на рубли, рубли на евро и евро на рубли ");

            Console.Write(" Введите баланс рублей ");
            rubleBalance = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс долларов ");
            dollarBalance = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс евро ");
            eurBalance = Convert.ToInt32(Console.ReadLine());

            while (canExamination)
            {
                Console.WriteLine(CommandConvertRubToUsd + " - обмен рублей на доллары ");
                Console.WriteLine(CommandConvertUsdToRub + " - обмен долларов на рубли ");
                Console.WriteLine(CommandConvertEurToRub + " - обмен рублей на евро ");
                Console.WriteLine(CommandConvertRubToEur + " - обмен евро на рубли ");
                Console.WriteLine(CommandConvertUsdToEuro + " - обмен долларов на рубли ");
                Console.WriteLine(CommandConvertEurToUsd + " - обмен евро на доллары ");
                userInput = Console.ReadLine();
              
                switch (userInput)
                                  
                {                  
                    case CommandConvertRubToUsd:
                        Console.WriteLine(" Обмен рублей на доллары ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (rubleBalance >= currencyCount)
                        {
                            rubleBalance -= currencyCount;
                            dollarBalance += currencyCount * rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;

                    case CommandConvertUsdToRub:
                        Console.WriteLine(" Обмен долларов на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (dollarBalance >= currencyCount)
                        {
                            dollarBalance -= currencyCount;
                            rubleBalance += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов ");
                        }
                        break;

                    case CommandConvertEurToRub:
                        Console.WriteLine(" Обмен рублей на евро ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (rubleBalance >= currencyCount)
                        {
                            rubleBalance -= currencyCount;
                            eurBalance += currencyCount * rubToEur;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;

                    case CommandConvertRubToEur:
                        Console.WriteLine(" Обмен Евро на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (eurBalance >= currencyCount)
                        {
                            eurBalance -= currencyCount;
                            rubleBalance += currencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во евро ");
                        }
                        break;

                    case CommandConvertUsdToEuro:
                        Console.WriteLine(" Обмен доллары на евро ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (dollarBalance >= currencyCount)
                        {
                            dollarBalance -= currencyCount;
                            eurBalance += currencyCount * usdToEur;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов ");
                        }
                        break;

                    case CommandConvertEurToUsd:
                        Console.WriteLine(" Обмен евро на доллары ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());

                        if (eurBalance >= currencyCount)
                        {
                            eurBalance -= currencyCount;
                            dollarBalance += currencyCount * euroTousd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во евро ");
                        }
                        break;
                }
                if (userInput == stopWord)
                {
                    canExamination = false;
                }

                Console.WriteLine(" Ваш баланс рублей " + rubleBalance + " баланс долларов " + dollarBalance + " баланс евро " + eurBalance);
            }
        }
    }
}