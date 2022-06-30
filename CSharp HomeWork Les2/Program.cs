using System;

namespace CSharp_HomeWork_Les2
{
    class Program
    {
        //1.The user enters 2 numbers(A and B).
        //If A > B, result is A+B, if A=B, result is A* B, if A<B, result is A-B.
        static int СalculateNumbers(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        //2.The user enters 2 numbers(X and Y).
        //Determine which quarter the point with coordinates(X, Y) belongs to.
        static int DefineAQuarter(int x, int y)
        {
            if (x == 0 | y == 0)
            {
                return 0;
            }
            else if (x > 0 & y > 0)
            {
                return 1;
            }
            else if (x > 0 & y < 0)
            {
                return 2;
            }
            else if (x < 0 & y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        //3.The user enters 3 numbers(A, B and C). Print them to the console in ascending order.
        static string DetermineTheAscendingOrder(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
            {
                return $"";
            }
            else if (a < b & b < c)
            {
                return $"{a}, {b}, {c}";
            }
            else if (a < c & c < b)
            {
                return $"{a}, {c}, {b}";
            }
            else if (b < a & a < c)
            {
                return $"{b}, {a}, {c}";
            }
            else if (b < c & c < a)
            {
                return $"{b}, {c}, {a}";
            }
            else if (c < b & b < a)
            {
                return $"{c}, {b}, {a}";
            }
            else if (c < a & c <b)
            {
                return $"{c}, {a}, {b}";
            }
            else
            {
                return $"";
            }
        }
        
        //4.The user enters 3 numbers (A, B and C).
        //Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        static string SolveQuadraticEquation(int a, int b, int c)
        {
            int discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return "";
            }
            else if (discriminant == 0)
            {
                int x = ((-b) + (int)Math.Sqrt(discriminant)) / (2 * a);
                return $"{x}";
            }
            else if (discriminant > 0)
            {
                int x1 = ((-b) + (int)Math.Sqrt(discriminant)) / (2 * a);
                int x2 = ((-b) - (int)Math.Sqrt(discriminant)) / (2 * a);
                return $"{x1}, {x2}";
            }
            else if (a==0)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        //5.The user enters a two-digit number.
        //Print the capitalization of this number to the console.
        //For example, typing "25" will print "twenty-five" to the console.
        static void FormatNumberToString(int a)
        {
            if (a < 10 | a > 99)
            {
                Console.WriteLine("The number is not two digits");
            }
            else if (a >= 10 & a < 20)
            {
                switch (a)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 14:
                        Console.WriteLine("Fourteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;
                    case 16:
                        Console.WriteLine("Sixteen");
                        break;
                    case 17:
                        Console.WriteLine("Seventeen");
                        break;
                    case 18:
                        Console.WriteLine("Eighteen");
                        break;
                    case 19:
                        Console.WriteLine("Nineteen");
                        break;
                }
            }
            else if (a >= 20 & a <= 99)
            {
                int units = a % 10;
                int dozens = (a / 10);
                string capitalizeUnit = "";

                switch (units)
                {
                    case 1:
                        capitalizeUnit = "one";
                        break;
                    case 2:
                        capitalizeUnit = "two";
                        break;
                    case 3:
                        capitalizeUnit = "three";
                        break;
                    case 4:
                        capitalizeUnit = "four";
                        break;
                    case 5:
                        capitalizeUnit = "five";
                        break;
                    case 6:
                        capitalizeUnit = "six";
                        break;
                    case 7:
                        capitalizeUnit = "seven";
                        break;
                    case 8:
                        capitalizeUnit = "eight";
                        break;
                    case 9:
                        capitalizeUnit = "nine";
                        break;
                }
                switch (dozens)
                {
                    case 2:
                        Console.WriteLine("Twenty " + capitalizeUnit);
                        break;
                    case 3:
                        Console.WriteLine("Thirty " + capitalizeUnit);
                        break;
                    case 4:
                        Console.WriteLine("Fourty " + capitalizeUnit);
                        break;
                    case 5:
                        Console.WriteLine("Fifty " + capitalizeUnit);
                        break;
                    case 6:
                        Console.WriteLine("Sixty " + capitalizeUnit);
                        break;
                    case 7:
                        Console.WriteLine("Seventy " + capitalizeUnit);
                        break;
                    case 8:
                        Console.WriteLine("Eighty " + capitalizeUnit);
                        break;
                    case 9:
                        Console.WriteLine("Ninety " + capitalizeUnit);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(СalculateNumbers(5, 10));
            Console.WriteLine(СalculateNumbers(11, 8));
            Console.WriteLine(СalculateNumbers(3, 3));
            Console.WriteLine("");

            Console.WriteLine(DefineAQuarter(4, 6));
            Console.WriteLine(DefineAQuarter(4, -6));
            Console.WriteLine(DefineAQuarter(-4, -6));
            Console.WriteLine(DefineAQuarter(-4, 6));
            Console.WriteLine(DefineAQuarter(0, 6));
            Console.WriteLine(DefineAQuarter(4, 0));
            Console.WriteLine(DefineAQuarter(0, 0));
            Console.WriteLine("");

            Console.WriteLine(DetermineTheAscendingOrder(1, 1, 1));
            Console.WriteLine(DetermineTheAscendingOrder(1, 2, 3));
            Console.WriteLine(DetermineTheAscendingOrder(1, 3, 2));
            Console.WriteLine(DetermineTheAscendingOrder(2, 1, 3));
            Console.WriteLine(DetermineTheAscendingOrder(2, 3, 1));
            Console.WriteLine(DetermineTheAscendingOrder(3, 1, 2));
            Console.WriteLine(DetermineTheAscendingOrder(3, 2, 1));
            Console.WriteLine("");

            Console.WriteLine(SolveQuadraticEquation(0, 3, 4));
            Console.WriteLine(SolveQuadraticEquation(-1, 2, 3));
            Console.WriteLine(SolveQuadraticEquation(1, 2, 3));
            Console.WriteLine("");

            FormatNumberToString(5);
            FormatNumberToString(106);
            FormatNumberToString(16);
            FormatNumberToString(50);
            FormatNumberToString(56);
        }
    }
}