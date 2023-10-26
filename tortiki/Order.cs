using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace tortiki
{
    internal class Order
    {



        public static void SpisokMenu()
        {
            Console.WriteLine("Добро пожаловать в заказ тортиков\n-----------");
            Console.WriteLine("  1.Форма");
            Console.WriteLine("  2.Размер");
            Console.WriteLine("  3.вкус");
            Console.WriteLine("  4.Количество");
            Console.WriteLine("  5.Глазурь");
            Console.WriteLine("  6.Декор");

        }
        

       public static void FirstMenu()
        {
            Console.Clear();
            Console.WriteLine("тортики v f.01");
            Console.WriteLine("  форма");
            Console.WriteLine("  размер");
            Console.WriteLine("  вкус коржей");
            Console.WriteLine("  кол-во в шт");
            Console.WriteLine("  глазурь");
            Console.WriteLine("  декор");
            Console.WriteLine("  конец заказа");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine(Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor);
            Console.WriteLine("Цена: " + Tort.price);
            SecondMenu();
        }

        private static void SecondMenu()
        {
            int pos = Strelki.strelki(1, 7);

            switch (pos)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("форма");
                Console.WriteLine("  1.овальный - 1000\n  2.круглый - 1200\n  3.полусфера - 2000");
                int position = Strelki.strelki(1, 3);
                if (position == 1)
                {
                    Tort.Form = " овальный ";
                    Tort.price += 1000;
                    FirstMenu();
                }
                if (position == 2)
                {
                    Tort.Form = " круглый ";
                    Tort.price += 1200;
                    FirstMenu();
                }
                if (position == 3)
                {
                    Tort.Form = " полусфера ";
                    Tort.price += 2000;
                    FirstMenu();
                }
                    break;

            case 2:
                Console.Clear();
                Console.WriteLine("размер");
                Console.WriteLine("  1.большой - 5000\n  2.средний - 2500\n  3.маленький - 1000");
                position = Strelki.strelki(1, 3);
                switch (position) {
                    case 1:
                    Tort.Size = " большой размер ";
                    Tort.price += 5000;
                    FirstMenu();
                        break;
               case 2:
                    Tort.Size = " средний размер ";
                    Tort.price += 2500;
                    FirstMenu();
                        break;
                    case 3:
                    Tort.Size = " маленький размер ";
                    Tort.price += 1000;
                    FirstMenu();
                        break;
                }
                    break;

                case 3:
                Console.Clear();
                Console.WriteLine("вкус торта");
                Console.WriteLine("  1.вкусный - 1000\n  2.сойдет - 700\n  3.закуска к балтике 9 - 50");
                 position = Strelki.strelki(1, 3);
                switch (position)
                {
                    case 1:
                        Tort.Vkus = " вкусно ";
                    Tort.price += 1000;
                    FirstMenu();
                        break;

                    case 2:
                    Tort.Vkus = " сойдет ";
                    Tort.price += 700;
                    FirstMenu();
                        break;
                    case 3:
                    Tort.Vkus = " закуска к балтике 9 ";
                    Tort.price += 50;
                    FirstMenu();
                        break;
                }
                    break; 
            
                case 4:
           
                Console.Clear();
                Console.WriteLine("сколько тортиков");
                Console.WriteLine("  1.много - 200\n  2.мало - 300\n  3.чуток - 100");
                 position = Strelki.strelki(1, 3);
                switch (position)
                {
                    case 1:
                        Tort.Count = "1";
                    Tort.price += 200;
                    FirstMenu();
                        break;
                    case 2:
                    Tort.Count = "2";
                    Tort.price += 300;
                    FirstMenu();
                        break;
                    case 3:
                    Tort.Count = "3";
                    Tort.price += 100;
                    FirstMenu();
                        break;
                }
                    break;
                case 5:
                Console.Clear();
                Console.WriteLine("глазурь");
                Console.WriteLine("  1.шоколад молочная - 300\n  2.шоколад белая - 400\n  3.темная шоколадка - 100");
                 position = Strelki.strelki(1, 3);
                switch (position) { 
                    case 1:
                    Tort.Glazur = " шоколад молочная ";
                    Tort.price += 300;
                    FirstMenu();
                        break;
                    case 2:
                    Tort.Glazur = " шоколад белая ";
                    Tort.price += 400;
                    FirstMenu();
                        break;
                        case 3:
                    Tort.Glazur = " темная шоколадка";
                    Tort.price += 100;
                    FirstMenu();
                        break;
                }
                    break;
                case 6:
                Console.Clear();
                Console.WriteLine("декор");
                Console.WriteLine("  1.базированный - 2500\n  2.кастом - 0\n  3.с пивом))))) - 100000");
                 position = Strelki.strelki(1, 3);
                switch (position) {
                    case 1:
                    Tort.Dekor = " авторский декор ";
                    Tort.price += 2500;
                    FirstMenu();
                        break;
                    case 2:
                    Tort.Dekor = " свой декор ";
                    Tort.price += 10;
                    FirstMenu();
                        break;
                    case 3:
                    Tort.Dekor = " базированный(со смурфиками) декор ";
                    Tort.price += 100000;
                    FirstMenu();
                        break;
                }
                    break;
                case 7:
                Console.Clear();
                Console.WriteLine("Составить счет");
                Console.WriteLine("цена: " + Tort.price);
                Console.WriteLine("вот какой получился торт:" + Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor);
                save();
                Console.WriteLine("\n\nЕсли вы хотите сделать еще один заказ, нажмите Enter, если хотите выйти из программы, нажмите Escape");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Tort.Form = " ";
                    Tort.Size = " ";
                    Tort.Vkus = " ";
                    Tort.Count = " ";
                    Tort.Glazur = " ";
                    Tort.Dekor = " ";
                    Tort.price = 0;
                    FirstMenu();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                    break;

            }
        }
            static void save()
            {
                DateTime date = DateTime.Now;
                File.WriteAllText("ЗаказнойТортик.txt", "\nзаказ от " + date + "\nДетали заказа: " + Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor + "\nЦена заказа: " + Tort.price);
            }
        }
    }
    