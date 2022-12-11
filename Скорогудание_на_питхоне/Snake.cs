using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Скорогудание_на_питхоне
{
    internal class Snake
    {
        public static List<bsnake> fsnake;
        static Snake()
        {
            bsnake p1 = new bsnake(new int[] { 21, 10 });
            bsnake p2 = new bsnake(new int[] { 21, 8 });
            bsnake p3 = new bsnake(new int[] { 21, 6 });
            fsnake = new List<bsnake>();
            fsnake.Add(p1);
            fsnake.Add(p2);
            fsnake.Add(p3);
        }
        public static void move()
        {
            Thread thr1 = new Thread(_ =>
            {
                Random rnd = new Random();
                int valueX = (2*rnd.Next(1, 20)-1);
                int valueY = rnd.Next(3, 21);
                Console.SetCursorPosition(valueX, valueY);
                Console.WriteLine("X");
                int a = 0;
                int count = 0;
                int getlonger = 0;
                int b = 200;
                while (true)
                {
                    if (Snake.fsnake.Last().pos[0] == valueX && Snake.fsnake.Last().pos[1] == valueY)
                    {
                        Console.SetCursorPosition(valueX, valueY);
                        Console.WriteLine("@");
                        valueX = (2 * rnd.Next(1, 20) - 1);
                        valueY = rnd.Next(2, 21);
                        count++;
                        Console.SetCursorPosition(valueX, valueY);
                        Console.WriteLine("X");
                        getlonger = 1;
                    }
                    Console.SetCursorPosition(1, 25);
                    Console.Write("Счет: ");
                    Console.Write(count);
                    a++;
                    if (var.key.Key == ConsoleKey.RightArrow)
                    {
                        if (a == 1)
                        {
                            foreach (bsnake row in Snake.fsnake)
                            {

                                if (row.pos[1] >= Convert.ToInt32(maxes.Right))
                                {
                                    break;
                                }
                                row.pos[1] += 2;
                                Console.SetCursorPosition(row.pos[1], row.pos[0]);
                                Console.WriteLine("@");
                            }
                            Console.Clear();
                        }
                        else
                        {
                            if (getlonger == 0)
                            {
                                Console.SetCursorPosition(Snake.fsnake.First().pos[0], Snake.fsnake.First().pos[1]);
                                Console.WriteLine(" ");
                                Snake.fsnake.RemoveAt(0);
                            }
                            bsnake new1 = new bsnake(new int[] { Snake.fsnake.Last().pos[0] + 2, Snake.fsnake.Last().pos[1] });
                            bool iscrashed1 = Snake.fsnake.Any(x => x.pos[0] == new1.pos[0]);
                            bool iscrashed2 = Snake.fsnake.Any(x => x.pos[1] == new1.pos[1]);
                            if (iscrashed1 && iscrashed2)
                            {
                                Console.Clear();
                                break;
                            }
                            Snake.fsnake.Add(new1);
                            if (Snake.fsnake.Last().pos[0] >= Convert.ToInt32(maxes.Right))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.SetCursorPosition(Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1]);
                            Console.WriteLine("@");
                        }
                        Thread.Sleep(b);
                    }
                    if (var.key.Key == ConsoleKey.LeftArrow)
                    {
                        if (a == 1)
                        {
                            foreach (bsnake row in Snake.fsnake)
                            {
                                row.pos[1] -= 2;
                                Console.SetCursorPosition(row.pos[1], row.pos[0]);
                                Console.WriteLine("@");
                            }
                        }
                        else
                        {
                            if (getlonger == 0)
                            {
                                Console.SetCursorPosition(Snake.fsnake.First().pos[0], Snake.fsnake.First().pos[1]);
                                Console.WriteLine(" ");
                                Snake.fsnake.RemoveAt(0);
                            }
                            bsnake new1 = new bsnake(new int[] { Snake.fsnake.Last().pos[0] - 2, Snake.fsnake.Last().pos[1] });
                            bool iscrashed1 = Snake.fsnake.Any(x => x.pos[0] == new1.pos[0]);
                            bool iscrashed2 = Snake.fsnake.Any(x => x.pos[1] == new1.pos[1]);
                            if (iscrashed1 && iscrashed2)
                            {
                                Console.Clear();
                                break;
                            }
                            Snake.fsnake.Add(new1);
                            if (Snake.fsnake.Last().pos[1] <= Convert.ToInt32(maxes.Left))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.SetCursorPosition(Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1]);
                            Console.WriteLine("@");
                        }
                        Thread.Sleep(b);
                    }
                    if (var.key.Key == ConsoleKey.UpArrow)
                    {
                        if (a == 1)
                        {
                            foreach (bsnake row in Snake.fsnake)
                            {
                                row.pos[0] -= 2;
                                Console.SetCursorPosition(row.pos[1], row.pos[0]);
                                Console.WriteLine("@");
                            }
                        }
                        else
                        {
                            if (getlonger == 0)
                            {
                                Console.SetCursorPosition(Snake.fsnake.First().pos[0], Snake.fsnake.First().pos[1]);
                                Console.WriteLine(" ");
                                Snake.fsnake.RemoveAt(0);
                            }
                            bsnake new1 = new bsnake(new int[] { Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1] - 1 });
                            bool iscrashed1 = Snake.fsnake.Any(x => x.pos[0] == new1.pos[0]);
                            bool iscrashed2 = Snake.fsnake.Any(x => x.pos[1] == new1.pos[1]);
                            if (iscrashed1 && iscrashed2)
                            {
                                Console.Clear();
                                break;
                            }
                            Snake.fsnake.Add(new1);
                            if (Snake.fsnake.Last().pos[1] == Convert.ToInt32(maxes.Up))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.SetCursorPosition(Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1]);
                            Console.WriteLine("@");
                        }
                        Thread.Sleep(b);
                    }
                    if (var.key.Key == ConsoleKey.DownArrow)
                    {
                        if (a == 1)
                        {
                            foreach (bsnake row in Snake.fsnake)
                            {
                                if (row.pos[0] >= Convert.ToInt32(maxes.Down))
                                {
                                    break;
                                }
                                row.pos[0] += 2;
                                Console.SetCursorPosition(row.pos[1], row.pos[0]);
                                Console.WriteLine("@");
                            }
                        }
                        else
                        {
                            if (getlonger == 0)
                            {
                                Console.SetCursorPosition(Snake.fsnake.First().pos[0], Snake.fsnake.First().pos[1]);
                                Console.WriteLine(" ");
                                Snake.fsnake.RemoveAt(0);
                            }
                            bsnake new1 = new bsnake(new int[] { Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1] + 1 });
                            bool iscrashed1 = Snake.fsnake.Any(x => x.pos[0] == new1.pos[0]);
                            bool iscrashed2 = Snake.fsnake.Any(x => x.pos[1] == new1.pos[1]);
                            if (iscrashed1 && iscrashed2)
                            {
                                Console.Clear();
                                break;
                            }
                            Snake.fsnake.Add(new1);
                            if (Snake.fsnake.Last().pos[1] >= Convert.ToInt32(maxes.Down))
                            {
                                Console.Clear();
                                break;
                            }
                            Console.SetCursorPosition(Snake.fsnake.Last().pos[0], Snake.fsnake.Last().pos[1]);
                            Console.WriteLine("@");
                        }
                        Thread.Sleep(b);
                    }
                    getlonger = 0;
                }
            });
            thr1.Start();
            while (true)
            {
                var.key = Console.ReadKey();
            }
        }
    }
}