using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Voditel
    {
        struct Voditel1
        {
            public string fio;
            public string spec;
            public string Contact;
            public double ZP;
            public void DisplayInfo()
            {
                Console.WriteLine("ФИО: {0}", this.fio);
                Console.WriteLine("Специальность: {0}", this.spec);
                Console.WriteLine("Контактные данные: {0}", this.Contact);
                Console.WriteLine("Зарплата: {0}\n", this.ZP);
            }
        }

        internal void Ar()
        {
            Console.Clear();
            Voditel1[] arr = new Voditel1[6];
            arr[0] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
            arr[1] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
            arr[2] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
            arr[3] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
            arr[4] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
            arr[5] = new Voditel1 { fio = "Введите данные", spec = "Введите данные", Contact = "Введите данные", ZP = 0 };
                do
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Изменить/Добавить");
                Console.WriteLine("2 - Показать");
                Console.WriteLine("4 - Сброс");
                Console.WriteLine("5 - Назад");
                Console.Write("Команда: ");
                int v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Введите номер сотрудника: (1-5) для редактирования или добавления информации. ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Random rnd = new Random();
                    if (rnd.Next(2) == 0)
                        A(ref arr[n - 1]);
                    else
                        arr[n - 1] = A1(arr[n - 1]);

                }
                if (v == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    foreach (var Voditel1 in arr)
                        Voditel1.DisplayInfo();
                }
                if (v == 4)
                {
                    Console.Clear();

                }
                if (v == 5)
                {
                    Console.Clear();
                    Program.Main();
                }
                if (v >= 6)
                {
                    Console.Clear();
                    Program.Error("Такой вариант отсутствует, проверьте правильность ввода");
                }
            } while (true);
        }

        static void A(ref Voditel1 a)
        {
            Console.WriteLine("ФИО: {0}", a.fio);
            Console.Write("Новое ФИО: ");
            a.fio = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Специальность: {0}", a.spec);
            Console.Write("Новая специальность: ");
            a.spec = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Контактные данные: {0}", a.Contact);
            Console.Write("Новые контактные данные: ");
            a.Contact = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Зарплата: {0}", a.ZP);
            Console.Write("Новая зарплата: ");
            a.ZP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        static Voditel1 A1(Voditel1 a)
        {
            Console.WriteLine("ФИО: {0}", a.fio);
            Console.Write("Новый ФИО: ");
            a.fio = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Специальность: {0}", a.spec);
            Console.Write("Новая специальность: ");
            a.spec = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Контактные данные: {0}", a.Contact);
            Console.Write("Новые контактные данные: ");
            a.Contact = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Оклад: {0}", a.ZP);
            Console.Write("Новая зарплата: ");
            a.ZP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return a;
        }
    }
    class machine
    {
        struct machine1
        {
            public string marka;
            public string model;
            public string koll;
            public void DisplayInfo()
            {
                Console.WriteLine("Марка: {0}", this.marka);
                Console.WriteLine("Модель: {0}", this.model);
                Console.WriteLine("Колличество: {0}\n", this.koll);
            }
        }
        internal void Ar2()
        {
            Console.Clear();

            machine1[] arr = new machine1[4];
            arr[0] = new machine1 { marka = "Mercedes Benz", model = "Conecto", koll = "5" };
            arr[1] = new machine1 { marka = "Man", model = "MAN Lion’s Top Coach", koll = "5" };
            arr[2] = new machine1 { marka = "Setra", model = "Setra S415 GT; ", koll = "5" };
            arr[3] = new machine1 { marka = "Neoplan", model = "Neoplan Tourliner", koll = "5" };
            do
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Изменить");
                Console.WriteLine("2 - Показать");
                Console.WriteLine("4 - Назад");
                Console.WriteLine("5 - Сброс");

                int v = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (v == 1)
                {
                    Console.WriteLine();
                    Console.Write("Выберите марку автомобиля,чью информацию вы хотите изменить:\n 1-Mercedes Benz\n 2-Man\n 3-Setra\n 4-Neoplan\n" );
                    Console.Write("Команда: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Random rnd = new Random();
                    if (rnd.Next(2) == 0)
                        A(ref arr[n - 1]);
                    else
                        arr[n - 1] = A1(arr[n - 1]);

                }
                if (v == 2)
                {
                    Console.WriteLine();
                    foreach (var machine1 in arr)
                        machine1.DisplayInfo();
                }
                if (v == 4)
                {
                    Console.Clear();
                    Program.Main();
                }
                if (v == 5)
                {
                    Console.Clear();

                }
                if (v >= 6)
                {
                    Program.Error("Такой вариант отсутствует");
                }

            } while (true);
        }
        static void A(ref machine1 a)
        {
            Console.WriteLine("Марка: {0}", a.marka);
            Console.Write("Новая марка: ");
            a.marka = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Модель: {0}", a.model);
            Console.Write("Новая модель: ");
            a.model = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Колличество: {0}", a.koll);
            Console.Write("Колличество: ");
            a.koll = Console.ReadLine();
            Console.WriteLine("");

        }


        static machine1 A1(machine1 a)
        {
            Console.WriteLine("Марка: {0}", a.marka);
            Console.Write("Новая марка: ");
            a.marka = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Модель: {0}", a.model);
            Console.Write("Новая модель: ");
            a.model = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Колличество: {0}", a.koll);
            Console.Write("Колличество: ");
            a.koll = Console.ReadLine();
            Console.WriteLine("");

            return a;
        }
    }
    class Marshrut
    {
        internal void Ar1()
        {
            Marshrut post = new Marshrut();
            Console.Clear();
            do
            {
                Console.WriteLine("Выберите нужный маршрут");
                Console.WriteLine("1 - Тирасполь-Дубоссары");
                Console.WriteLine("2 - Тирасполь-Григориополь");
                Console.WriteLine("3 - Тирасполь-Рыбница");
                Console.WriteLine("4 - Тирасполь-Бендеры");
                Console.WriteLine("5 - назад");
                Console.WriteLine("6 - очистить");
                int v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                {
                    int p = 1000;
                    int p1 = 1000;
                    int p2 = 1000;
                    int p3 = 1000;
                    Console.WriteLine("\nВыберите время для поездки: ");
                    Console.WriteLine("1) 09:00: " + p + " руб");
                    Console.WriteLine("2) 13:00: " + p1 + " руб.");
                    Console.WriteLine("3) 15:00: " + p2 + " руб.");
                    Console.WriteLine("4) 17:00: " + p3 + " руб.");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    switch (v1)
                    {
                        case 1:
                            Console.Write("\n09:00 укажите колличество билетов: ");
                            int g = Convert.ToInt32(Console.ReadLine());
                            int r = g * p;
                            Console.Write("Стоимость: " + r + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 2:
                            Console.Write("\n13:00 укажите колличество билетов: ");
                            int g1 = Convert.ToInt32(Console.ReadLine());
                            int r1 = g1 * p1;
                            Console.Write("Стоимость: " + r1 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 3:
                            Console.Write("\n15:00 укажите колличество билетов: ");
                            int g2 = Convert.ToInt32(Console.ReadLine());
                            int r2 = g2 * p2;
                            Console.Write("Стоимость: " + r2 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 4:
                            Console.Write("\n17:00 укажите колличество билетов: ");
                            int g3 = Convert.ToInt32(Console.ReadLine());
                            int r3 = g3 * p3;
                            Console.Write("Стоимость: " + r3 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        default:
                            break;
                    }
                }
                if (v == 2)
                {
                    int p = 700;
                    int p1 = 700;
                    int p2 = 700;
                    int p3 = 700;
                    int p4 = 700;
                    Console.WriteLine("\nВыберите время для поездки: ");
                    Console.WriteLine("1) 07:00: " + p + " руб.");
                    Console.WriteLine("2) 09:00: " + p1 + " руб.");
                    Console.WriteLine("3) 12:00: " + p2 + " руб.");
                    Console.WriteLine("4) 14:00: " + p3 + " руб.");
                    Console.WriteLine("5) 17:00: " + p3 + " руб.");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    switch (v1)
                    {
                        case 1:
                            Console.Write("\n07:00 укажите колличество билетов: ");
                            int g = Convert.ToInt32(Console.ReadLine());
                            int r = g * p;
                            Console.Write("Стоимость: " + r + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 2:
                            Console.Write("\n09:00 укажите колличество билетов: ");
                            int g1 = Convert.ToInt32(Console.ReadLine());
                            int r1 = g1 * p1;
                            Console.Write("Стоимость: " + r1 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 3:
                            Console.Write("\n12:00 укажите колличество билетов: ");
                            int g2 = Convert.ToInt32(Console.ReadLine());
                            int r2 = g2 * p2;
                            Console.Write("Стоимость: " + r2 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 4:
                            Console.Write("\n14:00 укажите колличество билетов: ");
                            int g3 = Convert.ToInt32(Console.ReadLine());
                            int r3 = g3 * p3;
                            Console.Write("Стоимость: " + r3 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 5:
                            Console.Write("\n17:00 укажите колличество билетов: ");
                            int g4 = Convert.ToInt32(Console.ReadLine());
                            int r4 = g4 * p4;
                            Console.Write("Стоимость: " + r4 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        default:
                            break;
                    }
                }
                if (v == 3)
                {
                    int p = 3000;
                    int p1 = 3000;
                    int p2 = 3000;
                    int p3 = 3000;
                    int p4 = 3000;
                    Console.WriteLine("\nВыберите время для поездки: ");
                    Console.WriteLine("1) 10:00: " + p + " руб.");
                    Console.WriteLine("2) 13:00: " + p1 + " руб.");
                    Console.WriteLine("3) 15:00: " + p2 + " руб.");
                    Console.WriteLine("4) 17:00: " + p3 + " руб.");
                    Console.WriteLine("5) 19:00: " + p4 + " руб.");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    switch (v1)
                    {
                        case 1:
                            Console.Write("\n10:00 укажите колличество билетов: ");
                            int g = Convert.ToInt32(Console.ReadLine());
                            int r = g * p;
                            Console.Write("Стоимость: " + r + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 2:
                            Console.Write("\n13:00 укажите колличество билетов: ");
                            int g1 = Convert.ToInt32(Console.ReadLine());
                            int r1 = g1 * p1;
                            Console.Write("Стоимость: " + r1 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 3:
                            Console.Write("\n15:00 укажите колличество билетов: ");
                            int g2 = Convert.ToInt32(Console.ReadLine());
                            int r2 = g2 * p2;
                            Console.Write("Стоимость: " + r2 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 4:
                            Console.Write("\n17:00 укажите колличество билетов: ");
                            int g3 = Convert.ToInt32(Console.ReadLine());
                            int r3 = g3 * p3;
                            Console.Write("Стоимость: " + r3 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 5:
                            Console.Write("\n19:00 укажите колличество билетов: ");
                            int g4 = Convert.ToInt32(Console.ReadLine());
                            int r4 = g4 * p4;
                            Console.Write("Стоимость: " + r4 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        default:
                            break;
                    }
                }
                if (v == 4)
                {
                    int p = 500;
                    int p1 = 500;
                    int p2 = 500;
                    int p3 = 500;
                    int p4 = 500;
                    Console.WriteLine("\nВыберите время для поездки: ");
                    Console.WriteLine("1) 10:00: " + p + " руб.");
                    Console.WriteLine("2) 12:00: " + p1 + " руб.");
                    Console.WriteLine("3) 14:00: " + p2 + " руб.");
                    Console.WriteLine("4) 16:00: " + p3 + " руб.");
                    Console.WriteLine("5) 18:00: " + p4 + " руб.");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    switch (v1)
                    {
                        case 1:
                            Console.Write("\n10:00 укажите колличество билетов: ");
                            int g = Convert.ToInt32(Console.ReadLine());
                            int r = g * p;
                            Console.Write("Стоимость: " + r + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 2:
                            Console.Write("\n12:00 укажите колличество билетов: ");
                            int g1 = Convert.ToInt32(Console.ReadLine());
                            int r1 = g1 * p1;
                            Console.Write("Стоимость: " + r1 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 3:
                            Console.Write("\n14:00 укажите колличество билетов: ");
                            int g2 = Convert.ToInt32(Console.ReadLine());
                            int r2 = g2 * p2;
                            Console.Write("Стоимость: " + r2 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 4:
                            Console.Write("\n16:00 укажите колличество билетов: ");
                            int g3 = Convert.ToInt32(Console.ReadLine());
                            int r3 = g3 * p3;
                            Console.Write("Стоимость: " + r3 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        case 5:
                            Console.Write("\n18:00 укажите колличество билетов: ");
                            int g4 = Convert.ToInt32(Console.ReadLine());
                            int r4 = g4 * p4;
                            Console.Write("Стоимость: " + r4 + " руб.\n");
                            Sale.S("Заказ оформлен!\n");
                            break;
                        default:
                            break;
                    }
                }
                if (v == 5)
                {

                    Console.Clear();
                    Program.Main();
                }
                if (v >= 6)
                {
                    Console.Clear();
                }
                if (v >= 7)
                {
                    Program.Error("Такой вариант отсутсвует");
                }
            } while (true);
        }
    }

    class Sale
    {
        internal void Ar2()
        {
            Console.Clear();
            Sale sal = new Sale();
        }
        public static void S(string info)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(info);
            Console.ResetColor();
        }
    }

    class Program
    {
        public static void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        internal static void Main()
        {
            Voditel mast = new Voditel();
            Marshrut post = new Marshrut();
            Sale sal = new Sale();
            machine mach = new machine();

            int variant = 0;

            do
            {
                Console.WriteLine("Вас приветствует автопарк Etherial");
                Console.WriteLine("1) Работники\n2) Продажа билетов\n3) Машины в автопарке\n4) Сброс\n5) Выход");
                Console.Write("Команда: ");

                variant = Int32.Parse(Console.ReadLine());

                switch (variant)
                {
                    case 1:
                        mast.Ar();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        post.Ar1();
                        break;
                    case 3:
                        mach.Ar2();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Program.Error("Такой вариант отсутствует");
                        break;
                }

            } while (true);
        }
    }
}