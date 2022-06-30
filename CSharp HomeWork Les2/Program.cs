using System;

namespace CSharp_HomeWork_Les2
{
    class Program
    {
        //1.The user enters 2 numbers(A and B).
        //If A > B, result is A+B, if A=B, result is A* B, if A<B, result is A-B.
        static int СalculateNumbers(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
                Console.WriteLine("A + B = " + result);
            }
            else if (a == b)
            {
                result = a * b;
                Console.WriteLine("A * B = " + result);
            }
            else
            {
                result = a - b;
                Console.WriteLine("A - B = " + result);
            }
            return result;
        }

        //2.The user enters 2 numbers(X and Y).
        //Determine which quarter the point with coordinates(X, Y) belongs to.
        static int DefineAQuarter(int x, int y)
        {
            int result;

            if (x == 0 | y == 0)
            {
                result = 0;
                Console.WriteLine("The point lies on the coordinate axis");
            }
            else if (x > 0 & y > 0)
            {
                result = 1;
                Console.WriteLine("The dot is in a quarter " + result);
            }
            else if (x > 0 & y < 0)
            {
                result = 2;
                Console.WriteLine("The dot is in a quarter " + result);
            }
            else if (x < 0 & y < 0)
            {
                result = 3;
                Console.WriteLine("The dot is in a quarter " + result);
            }
            else
            {
                result = 4;
                Console.WriteLine("The dot is in a quarter " + result);
            }
            return result;
        }

        //3.The user enters 3 numbers(A, B and C). Print them to the console in ascending order.
        static void DetermineTheAscendingOrder(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Numbers equal");
            }
            else if (a < b & b < c)
            {
                Console.WriteLine($"{a}, {b}, {c}");
            }
            else if (a < c & c < b)
            {
                Console.WriteLine($"{a}, {c}, {b}");
            }
            else if (b < a & a < c)
            {
                Console.WriteLine($"{b}, {a}, {c}");
            }
            else if (b < c & c < a)
            {
                Console.WriteLine($"{b}, {c}, {a}");
            }
            else if (c < b & b < a)
            {
                Console.WriteLine($"{c}, {b}, {a}");
            }
            else
            {
                Console.WriteLine($"{c}, {a}, {b}");
            }
        }

        //4.The user enters 3 numbers (A, B and C).
        //Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        static void SolveQuadraticEquation(int a, int b, int c)
        {
            int discriminant;
            if (a == 0)
            {
                Console.WriteLine("The equation cannot be solved, because A equal zero.");
            }
            else
            {
                discriminant = b * b - 4 * a * c;
                if (discriminant < 0)
                {
                    Console.WriteLine("No roots, because the Discriminant equal zero.");
                }
                else if (discriminant == 0)
                {
                    double x = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Root equals {x}");
                }
                else
                {
                    double x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Roots equals {x1} and {x2}");
                }
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
            СalculateNumbers(5, 10);
            СalculateNumbers(11, 8);
            СalculateNumbers(3, 3);
            Console.WriteLine("");

            DefineAQuarter(4, 6);
            DefineAQuarter(4, -6);
            DefineAQuarter(-4, -6);
            DefineAQuarter(-4, 6);
            DefineAQuarter(0, 6);
            DefineAQuarter(4, 0);
            DefineAQuarter(0, 0);
            Console.WriteLine("");

            DetermineTheAscendingOrder(1, 1, 1);
            DetermineTheAscendingOrder(1, 2, 3);
            DetermineTheAscendingOrder(1, 3, 2);
            DetermineTheAscendingOrder(2, 1, 3);
            DetermineTheAscendingOrder(2, 3, 1);
            DetermineTheAscendingOrder(3, 1, 2);
            DetermineTheAscendingOrder(3, 2, 1);
            Console.WriteLine("");

            SolveQuadraticEquation(0, 3, 4);
            SolveQuadraticEquation(-1, 2, 3);
            SolveQuadraticEquation(1, 2, 3);
            Console.WriteLine("");

            FormatNumberToString(5);
            FormatNumberToString(106);
            FormatNumberToString(16);
            FormatNumberToString(50);
            FormatNumberToString(56);
        }
    }
}