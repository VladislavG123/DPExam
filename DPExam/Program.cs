using DPExam.Models;
using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{

    /*
     Использованы два паттерна проектирования: Decorator, Builder

        Классы и интерфейсы декоратора: Decorator, Computer, Processor, HDD, SSD и другие комплненты
            Этот паттерн испльзуется для подсчета стоимости комплектаций

         Классы и интерфейсы строителя: IComputerBuilder, Director, ComputerComplectation, Complectation
            Этот паттрен используется для создания комплектации
         
         */
    class Program
    {
        // Парсеры для ввода чисел
        public static int IntParser(int from, int to)
        {
            int result;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result) && result >= from && result <= to)
                {
                    return result;
                }
                Console.WriteLine("Неверный ввод!");
            }
        }

        public static int IntParser(int from)
        {
            int result;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result) && result >= from)
                {
                    return result;
                }
                Console.WriteLine("Неверный ввод!");
            }
        }

        // Вывод существующих компонентов и их цены
        public static void ShowComponentList()
        {
            Console.WriteLine("1 " + new Processor().ToString());
            Computer computer = new Processor();
            computer.Cost = 0;
            Console.WriteLine("2 " + new Body(computer).ToString());
            Console.WriteLine("3 " + new AudioCard(computer).ToString());
            Console.WriteLine("4 " + new HDD(computer).ToString());
            Console.WriteLine("5 " + new Keyboard(computer).ToString());
            Console.WriteLine("6 " + new MainCard(computer).ToString());
            Console.WriteLine("7 " + new Mouse(computer).ToString());
            Console.WriteLine("8 " + new NetworkCard(computer).ToString());
            Console.WriteLine("9 " + new SSD(computer).ToString());
            Console.WriteLine("10 " + new VideoCard(computer).ToString());
        }

        // Метод для создания, и в дальнейшем покупки, комплектации
        public static void CollectComplectation()
        {
            Computer computer = new Processor();
            ComputerComplectation complectation = new ComputerComplectation();

            ShowComponentList();

            Console.WriteLine("Введите номер компонента, которого вы хотите добавить в комплектацию");
            Console.WriteLine("Если Вы закончили выбирать нажмите 0");
            int chouse;
            while (true)
            {
                chouse = IntParser(0, 10);

                if (chouse == 0) break;

                switch (chouse)
                {
                    case 1:
                        Console.WriteLine("Процессор уже входит в комплектацию.");
                        break;
                    case 2:
                        complectation.BuildBody();
                        break;
                    case 3:
                        complectation.BuildAudioCard();
                        break;
                    case 4:
                        complectation.BuildHDD();
                        break;
                    case 5:
                        complectation.BuildKeyboard();
                        break;
                    case 6:
                        complectation.BuildMainCard();
                        break;
                    case 7:
                        complectation.BuildMainCard();
                        break;
                    case 8:
                        complectation.BuildNetworkCard();
                        break;
                    case 9:
                        complectation.BuildSSD();
                        break;
                    case 10:
                        complectation.BuildVideoCard();
                        break;
                }
            }
            Console.WriteLine("Ваша комплектация:");

            Console.WriteLine(complectation.GetComplectation().ListParts());

            Console.WriteLine("\n\t1 - Продолжить покупку");
            Console.WriteLine("\t2 - В главное меню");

            chouse = IntParser(1, 2);
            if (chouse == 1)
            {
                Console.WriteLine("\tТовар успешно куплен!");
                Console.WriteLine("\nНажмите на любую клавишу...");
                Console.Read();
            }
            Console.Clear();

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Вывести список компонентов");
                Console.WriteLine("2 - Купить готовый набор");
                Console.WriteLine("---Собрать свой ПК---");
                Console.WriteLine("3 - Собрать свою комплектацию");
                Console.WriteLine("4 - Выход");
                int chouse = IntParser(1, 4);

                switch (chouse)
                {
                    case 1:
                        ShowComponentList();
                        Console.WriteLine("\nНажмите на любую клавишу...");
                        Console.Read(); Console.Read();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("\t1 - Купить базовую комплектацию");
                        Console.WriteLine("\t2 - Купить полную комплектацию");
                        Console.WriteLine("\t3 - Назад");
                        chouse = IntParser(1, 3);
                        if (chouse == 1)
                        {
                            Director director = new Director();
                            ComputerComplectation computerComplectation = new ComputerComplectation();
                            director.Builder = computerComplectation;
                            director.Basic();
                            Console.WriteLine("\tВ комплектацию входит:");
                            Console.WriteLine(computerComplectation.GetComplectation().ListParts());

                            Computer computer = new Processor();
                            Body body = new Body(computer);
                            MainCard mainCard = new MainCard(body);
                            AudioCard audioCard = new AudioCard(mainCard);
                            NetworkCard networkCard = new NetworkCard(audioCard);
                            HDD hdd = new HDD(networkCard);

                            Console.WriteLine("\tОбщяя стоимость: " + hdd.GetCost());
                            Console.WriteLine("\n\t1 - Продолжить покупку");
                            Console.WriteLine("\t2 - В главное меню");
                            chouse = IntParser(1, 2);
                            if (chouse == 1)
                            {
                                Console.WriteLine("\tТовар успешно куплен!");
                                Console.WriteLine("\nНажмите на любую клавишу...");
                                Console.Read();
                                return;
                            }
                            Console.Clear();

                        }
                        else if (chouse == 2)
                        {
                            Director director = new Director();
                            ComputerComplectation computerComplectation = new ComputerComplectation();
                            director.Builder = computerComplectation;
                            director.Full();
                            Console.WriteLine("\tВ комплектацию входит:");
                            Console.WriteLine(computerComplectation.GetComplectation().ListParts());

                            Computer computer = new Processor();
                            Body body = new Body(computer);
                            MainCard mainCard = new MainCard(body);
                            AudioCard audioCard = new AudioCard(mainCard);
                            NetworkCard networkCard = new NetworkCard(audioCard);
                            HDD hdd = new HDD(networkCard);
                            VideoCard videoCard = new VideoCard(hdd);
                            SSD ssd = new SSD(videoCard);
                            Mouse mouse = new Mouse(ssd);
                            Keyboard keyboard = new Keyboard(mouse);

                            Console.WriteLine("\tОбщяя стоимость: " + keyboard.GetCost());
                            Console.WriteLine("\n\t1 - Продолжить покупку");
                            Console.WriteLine("\t2 - В главное меню");
                            chouse = IntParser(1, 2);
                            if (chouse == 1)
                            {
                                Console.WriteLine("\tТовар успешно куплен!");
                                Console.WriteLine("\nНажмите на любую клавишу...");
                                Console.Read();
                                return;
                            }
                            Console.Clear();
                        }

                        break;
                    case 3:
                        CollectComplectation();
                        break;
                    case 4:
                        return;
                }

            }

        }
    }
}
