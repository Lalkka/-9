using System;
using System.Diagnostics.Eventing.Reader;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tДобро пожаловать в Практическая работа 5, Одномерные массивы!\n\t           Нажмите что-бы продолжить");
            Console.ReadLine();
            Console.Clear();
            bool programm = true;
            while (programm)
            {

                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine("1. Два массива.\n2. Снежный ком.\n3. Свой среди чужих, чужой среди своих.\n4. Сын маминой подруги.\n5. Массовый ульт.\n6. У вас продаётся славянский шкаф?\n7. Я уже Смешарик или ещё нет?\n8. Сапёр ошибается один раз.\n\n0. ВЫХОД");
                var key = Console.ReadKey().KeyChar;
                Console.Clear();
                Random gen = new Random();
                switch (key)
                {
                    case '1':
                        Console.WriteLine("Даны два массива A и B. Определить которых из них имеет больший диапазон, т.е. разницу между самым большим и самым меньшим значением. ");
                        Console.Write("\nВведите размер массива А:");
                        var mA0 = Console.ReadLine();
                        Console.Write("\nВведите размер массива B:");
                        var mB0 = Console.ReadLine();

                        if (int.TryParse(mA0, out int mA) && int.TryParse(mB0, out int mB) && mA > 0 && mB > 0)
                        {
                            int[] A = new int[mA];
                            int[] B = new int[mB];
                            int Amax = 0, Amin = 100, Bmax = 0, Bmin = 100;
                            for (int i = 0; i < A.Length; i++)
                            {
                                A[i] = gen.Next(0, 101);
                            }
                            for (int i = 0; i < B.Length; i++)
                            {
                                B[i] = gen.Next(0, 101);
                            }
                            for (int i = 0; i < A.Length; i++)
                            {
                                if (A[i] >= Amax) Amax = A[i];
                            }
                            for (int i = 0; i < B.Length; i++)
                            {
                                if (B[i] >= Bmax) Bmax = B[i];
                            }
                            for (int i = 0; i < A.Length; i++)
                            {
                                if (A[i] <= Amin) Amin = A[i];
                            }
                            for (int i = 0; i < B.Length; i++)
                            {
                                if (B[i] <= Bmin) Bmin = B[i];
                            }
                            int aA = Amax - Amin, aB = Bmax - Bmin;
                            Console.WriteLine($"Диапозон массива A [{Amin} - {Amax}] составил {aA}");
                            Console.WriteLine($"Диапозон массива B [{Bmin} - {Bmax}] составил {aB}");
                            if (aB > aA)
                            {
                                aA = aB - aA;
                                Console.WriteLine($"Диапазон массива B оказался больше и составил {aA}");
                            }
                            else if (aA > aB)
                            {
                                aB = aA - aB;
                                Console.WriteLine($"Диапазон массива A оказался больше и составил {aB}");
                            }
                            else Console.WriteLine("Диапазон массивов A и B оказался одинаковым");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        Console.Clear();

                        break;
                    case '3':
                        Console.Clear();

                        break;
                    case '4':
                        Console.Clear();

                        break;
                    case '5':
                        Console.Clear();

                        break;
                    case '6':
                        Console.Clear();

                        break;
                    case '7':
                        Console.Clear();

                        break;
                    case '8':
                        Console.Clear();

                        break;
                    case '0':
                        Console.Clear();
                        programm = false;
                        break;

                }
                Console.Clear();
            }
        }
    }
}