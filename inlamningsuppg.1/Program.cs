using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, sum;
            char operand1, operand2;
            bool run = true;

            List<int> array = new List<int>();

            string less, equal, more, tryAgain, bye;
            less = "The sum is less then a hundred!";
            equal = "Cool, now you have a hundred, clap clap!";
            more = "The sum is more then a hundred!";
            tryAgain = "Try again? Press ENTER to try again or press any key to exit.";
            bye = "Thank you for playing. The sum of all round is ";

            do
            {
                Console.Title = "INLÄMNINGSUPPGIFT 1";
                Console.WriteLine("Enter first operator: ");
                operand1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter second operator: ");
                operand2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter first value: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second value: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter third value: ");
                z = Convert.ToInt32(Console.ReadLine());

                if (operand1 == '+')
                {
                    if (operand2 == '+')
                    {
                        sum = (x + y) + z;
                        array.Add(sum);
                        Console.WriteLine($"{x} + {y} + {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '-')
                    {
                        sum = (x + y) - z;
                        array.Add(sum);
                        Console.WriteLine($"{x} + {y} - {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '/')
                    {
                        sum = (x + y) / z;
                        array.Add(sum);
                        Console.WriteLine($"{x} + {y} / {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if ((operand2 == '*') || (operand2 == 'x'))
                    {
                        sum = (x + y) * z;
                        array.Add(sum);
                        Console.WriteLine($"{x} + {y} x {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                }
                else if (operand1 == '-')
                {
                    if (operand2 == '+')
                    {
                        sum = (x - y) + z;
                        array.Add(sum);
                        Console.WriteLine($"{x} - {y} + {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '-')
                    {
                        sum = (x - y) - z;
                        array.Add(sum);
                        Console.WriteLine($"{x} - {y} - {z} = {sum}");
                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '/')/////////////////////////////////////////////////////////////////////////////////////////
                    {
                        sum = (x - y) / z;
                        array.Add(sum);
                        Console.WriteLine($"{x} - {y} / {z} = {sum}"); ;

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if ((operand2 == '*') || (operand2 == 'x'))
                    {
                        sum = (x - y) * z;
                        array.Add(sum);
                        Console.WriteLine($"{x} - {y} x {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                }
                else if (operand1 == '/')
                {
                    if (operand2 == '+')
                    {
                        sum = (x / y) + z;
                        array.Add(sum);
                        Console.WriteLine($"{x} / {y} + {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '-')
                    {
                        sum = (x / y) - z;
                        array.Add(sum);
                        Console.WriteLine($"{x} / {y} - {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '/')
                    {
                        sum = (x / y) / z;
                        array.Add(sum);
                        Console.WriteLine($"{x} / {y} / {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if ((operand2 == '*') || (operand2 == 'x'))
                    {
                        sum = (x / y) * z;
                        array.Add(sum);
                        Console.WriteLine($"{x} / {y} x {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                }

                else if ((operand1 == '*') || (operand1 == 'x'))
                {
                    if (operand2 == '+')
                    {
                        sum = (x * y) + z;
                        array.Add(sum);
                        Console.WriteLine($"{x} x {y} + {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '-')
                    {
                        sum = (x * y) - z;
                        array.Add(sum);
                        Console.WriteLine($"{x} x {y} - {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if (operand2 == '/')
                    {
                        sum = (x * y) / z;
                        array.Add(sum);
                        Console.WriteLine($"{x} x {y} / {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                    else if ((operand2 == '*') || (operand2 == 'x'))
                    {
                        sum = (x * y) * z;
                        array.Add(sum);
                        Console.WriteLine($"{x} x {y} x {z} = {sum}");

                        if (sum < 100)
                        {
                            Console.WriteLine(less);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine(equal);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine(more);
                            Console.WriteLine(tryAgain);

                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                run = true;
                            }
                            else
                            {
                                int total = array.Sum();
                                Console.WriteLine(bye + total);
                                run = false;
                            }
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Wrong character!");
                }
            } while (run);
            Console.ReadKey();
        }
    }
}
