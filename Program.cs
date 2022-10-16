using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonyaPW_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер практической: ");
            uint numPract = uint.Parse(Console.ReadLine());
            switch (numPract)
            {
                case 1:
                    Console.WriteLine("Меня зовут Тутанина Соня Сергеевна, моих родителей: Анна и сергей");
                    break;
                case 2:
                    Console.WriteLine("n=j*p*43-7*a+5*y");
                    int n;
                    Console.Write("введите значение j:");
                    int j = int.Parse(Console.ReadLine());

                    Console.Write("введите значение p:");
                    int p = int.Parse(Console.ReadLine());

                    Console.Write("введите значение a:");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("введите значение y:");
                    int y = int.Parse(Console.ReadLine());

                    n = j * p * 43 - 7 * a + 5 * y;
                    Console.WriteLine("n равен={0}", n);
                    break;
                case 3:
                    Console.Write("введите значение a:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("введите значение b:");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("введите значение c:");
                    int c = int.Parse(Console.ReadLine());
                    double PI = 3.1416;
                    double E = 2.718;
                    Console.WriteLine("a/PI={0:#.####}",a1/PI);
                    Console.WriteLine("a+b+c= {0}", a1+b+c);
                    Console.WriteLine("c/E={0:#.###}",c/E);
                    break;
                case 4:
                    Console.Write("введите 4-х значное число:");
                    int a4 = int.Parse(Console.ReadLine());
                    int aFirst;
                    int aLast;
                    aFirst = a4 / 100;
                    aLast = a4 % 100;
                    Console.WriteLine("результат перестановки первых и двух последних цифр заданного числа: {0} ", aLast*100+aFirst);
                    break;
                case 5:
                    Console.Write("введите количество пальто которое нужно изготовить:");
                    int K = int.Parse(Console.ReadLine());
                    Console.Write("введите количество дней на изготовку");
                    int R = int.Parse(Console.ReadLine());
                    Console.Write("На какое количество делали больше пальто в день?");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine("Количество сшитых пальто равно: {0}", (K/R+N)*R);
                    break;
                case 6:
                    Console.Write("введите x:");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("введите x:");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.Write("введите b:");
                    int b2 = int.Parse(Console.ReadLine());

                    double y1 = Math.Sqrt(Math.Log(x / a2)+b2/2*x)/a2-3*b2*Math.Sqrt(x+5);
                    Console.WriteLine("y={0}", Math.Sqrt(Math.Log(x / a2) + b2 / 2 * x) / a2 - 3 * b2 * Math.Sqrt(x + 5));
                    break;

                case 7:
                    int x1 = 0;
                    Console.Write("введите x:");
                    x1 = int.Parse(Console.ReadLine());
                    double y3=0;
                    if (x1>=1 && x1<=2)
                    {
                        y3 = Math.Sqrt(Math.Abs(x1 + 1));
                    }
                    else if (x1==10)
                    {
                        y3 = 2*Math.Tan(Math.Pow(Math.E,x1))-Math.Sin(x1);
                    }
                    Console.WriteLine("y={0}", y3);
                    break;
                case 8:
                    Console.WriteLine("1-созвездие 'орион',2-созвение 'лебедь'");
                    Console.WriteLine("введите номер созвездия: ");
                    uint a5 = uint.Parse(Console.ReadLine());
                    switch (a5)
                    {
                        case 1:
                            Console.WriteLine("Орио́н — созвездие в области небесного экватора. " +
                                "Это одно из самых заметных и узнаваемых созвездий на ночном небе." +
                                " Его самые яркие звезды — красная Бетельгейзе и бело-голубой Ригель." +
                                " Названо в честь охотника Ориона из древнегреческой мифологии. ");
                            break;
                        case 2:
                            Console.WriteLine("созвездие северного полушария неба. " +
                                "Яркие звёзды образуют характерный крестообразный рисунок — астеризм Северный крест, вытянутый вдоль Млечного Пути." +
                                " У древних людей он ассоциировался с летящей птицей: вавилоняне называли созвездие «лесной птицей», арабы — курицей");
                            break;
                    }
                    break;
                case 9:
                    //1 способ
                    for (int i = 10; i < 100; i++)
                    {
                        if (i % 11 != 0)
                            Console.Write(";" + i);
                    }
                    //2 способ:
                    int an = 10;
                    Console.WriteLine();
                    while (an < 100)
                    {
                        if (an % 11 != 0)
                            Console.Write(";" + an);
                        an++;
                    }

                    //3 способ:
                    an = 10;
                    Console.WriteLine();
                    do
                    {
                        if (an % 11 != 0)
                            Console.Write(";" + an);
                        an++;
                    }
                    while (an < 100);

                    break;
            }
        }
    }
}
