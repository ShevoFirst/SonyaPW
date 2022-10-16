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
            double numPract = double.Parse(Console.ReadLine());
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
                case 10.1:
                    //задание 1
                    Console.WriteLine("введите количество значений Y: ");
                    int Y =int.Parse( Console.ReadLine());
                    int[] mass = new int[Y];
                    Random random = new Random();
                    double sred=0;
                    uint kol=0;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = random.Next(-10,20);
                        Console.Write(mass[i]+ " ");
                    }
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (mass[i]%2==0 && mass[i]>0)
                        {
                            sred += mass[i];
                        }
                        if (mass[i]<0)
                        {
                            kol++;
                        }
                    }
                    Console.WriteLine("среднее арифметоческое положительных чисел равно: {0}", sred/Y);
                    Console.WriteLine("количество отрицательных чисел равно {0}", kol) ;
                    

                    break;
                case 10.2:
                    //задание 2
                    Console.WriteLine("введите нат. число W");
                    int W = int.Parse(Console.ReadLine());
                    int per = W;
                    int suma = 0;
                    int digit;
                    while (W>0)
                    {
                        digit = W % 10;
                        if (digit%3==0)
                        {
                            suma += digit;
                        }
                        W = W / 10;
                    }
                    char[] arr = per.ToString().ToCharArray();
                    Console.WriteLine("сумма кратным трем чисел равна:{0}",suma);
                    Console.WriteLine("первая цифра равна {0}, последняя равна {1}",arr[0],arr[arr.Length-1]);
                    break;
                case 10.3:
                    Console.WriteLine("введите количество значений mass: ");
                    int yep = int.Parse(Console.ReadLine());
                    int[] mass1 = new int[yep];
                    Random random1 = new Random();
                    int pros=1;
                    for (int i = 0; i < mass1.Length; i++)
                    {
                        mass1[i] = random1.Next(-10, 20);
                        Console.Write(mass1[i] + " ");
                    }
                    for (int i = 0; i < mass1.Length; i++)
                    {
                        if (mass1[i]%2==0 && mass1[i]%5==0)
                        {
                            pros *= mass1[i];
                        }
                    }
                    if (pros !=1)
                    {
                        Console.WriteLine("произведение членов кратных 2 и 5 равно {0}", pros);

                    }
                    else
                    {
                        Console.WriteLine("таких чисел нету)");
                    }
                    break;
                case 11:
                    Console.WriteLine("введите количество значений mass: ");
                    int yep1 = int.Parse(Console.ReadLine());
                    int[] mass2 = new int[yep1];
                    Random random2 = new Random();
                    uint col=0;
                    for (int i = 0; i < mass2.Length; i++)
                    {
                        mass2[i] = random2.Next(-20, 20);
                        Console.Write(mass2[i] + " ");
                    }
                    for (int i = 0; i < mass2.Length; i++)
                    {
                        if (mass2[i] % 5 == 0 && mass2[i]<0)
                        {
                            col++;
                        }
                    }
                    Console.WriteLine("количество отрицательных элементов кратных 5 равно: {0}", col);
                    break;
                case 12:

                    int[] massi = new int[12];
                    for (int i = 0; i < massi.Length; i++)
                    {
                        Console.WriteLine("Введите значение элементу {0}", i);
                        massi[i] = int.Parse(Console.ReadLine());
                    }
                    int min=50;
                    int minNum=0;
                    int summ=0;
                    for (int i = 0; i < massi.Length; i++)
                    {
                        if (massi[i]<=min)
                        {
                            min = massi[i];
                            minNum = i;
                        }
                    }
                    Console.WriteLine("3232323");
                    for (int i = minNum; i < massi.Length; i++)
                    {
                        summ += massi[i];
                    }
                    Console.WriteLine("2323");
                    Console.WriteLine("сумма чисел после минимального элемента равна: {0}",summ-1);
                    break;
                case 13.1:
                    Console.WriteLine("введите количество значений mass: ");
                    int yep2 = int.Parse(Console.ReadLine());
                    int[] mass3 = new int[yep2];
                    Random random3 = new Random();
                    uint numbZero=0;
                    uint numbPlus=0;
                    int prost;
                    for (int i = 0; i < mass3.Length; i++)
                    {
                        mass3[i] = random3.Next(-20, 20);
                        if (mass3[i]==0)
                        {
                            numbZero++;
                        }
                        if (mass3[i]>0)
                        {
                            numbPlus++;
                        }
                        Console.Write(mass3[i] + " ");
                    }
                    prost = mass3[3];
                    mass3[3] = mass3[10];
                    mass3[10]=prost;
                    for (int i = 0; i < mass3.Length; i++)
                    {
                        Console.Write(mass3[i]+" ");
                    }
                    Console.WriteLine("количество элементов равных нулю {0}, количество отрицательных элементов {1}",numbZero,numbPlus);
                    break;
                case 13.2:
                    Console.WriteLine("введите количество значений mass: ");
                    int yepe = int.Parse(Console.ReadLine());
                    int[] mass23 = new int[yepe];
                    Random rando = new Random();
                    for (int i = 0; i < mass23.Length; i++)
                    {
                        mass23[i] = rando.Next(-20, 20);
                        Console.Write(mass23[i] + " ");
                    }
                    Console.Write("введите число C : ");
                    int C = int.Parse(Console.ReadLine());
                    for (int i = 0; i < mass23.Length; i++)
                    {
                        if (mass23[i]>C)
                        {
                            mass23[i] = 0;
                        }
                    }
                    for (int i = 0; i < mass23.Length; i++)
                    {
                        Console.Write(mass23[i] + " ");
                    }

                    break;
            }
        }
    }
}
