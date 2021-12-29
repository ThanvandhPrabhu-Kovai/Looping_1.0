using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_1
{
    class Program
    {
        static void Main(string[] args)
        {
            showFirst10NaturalNumbers();
            showSumOfFirstTenNaturalNumbers();
            showNTermsOfNaturalNumbersAndTheirSum();
            read10NumbersGetSumAndAverage();
            showTheCubeOfNumberUptoAGivenInteger();
            showMultiplicationTableOfAGivenInteger();
            showMultiplicationTableVerticallyFrom1ToN();
            showNTermsOfOddNumbersAndTheirSum();
            showRightAngleTrianglePatternWithAsteriskUptoNRows();
            showRightAngleTriangleWithNumber();
            Console.ReadLine();
        }

        //program to display the first 10 natural numbers
        static void showFirst10NaturalNumbers() {
            Console.Write("\n\nDisplay first ten natural numbers :");
            Console.Write("\n\n----------------------");
            Console.Write("\n\nThe first ten natural numbers\n\n");
            for (int i = 1; i<=10; i++) {
                Console.WriteLine("{0}", i);
            }
        }

        //program to find the sum of first 10 natural numbers
        static void showSumOfFirstTenNaturalNumbers() {
            int sum = 0;
            Console.Write("\n\nFind the sum of first 10 natural numbers : ");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nThe first ten natural numbers are : \n\n");
            for (int i = 1; i<=10; i++) {
                Console.WriteLine("{0}", i);
                sum += i;
            }
            Console.Write("\n\nThe sum of first 10 natural numbers is : {0}", sum);
        }

        //program to display n terms of natural number and their sum
        static void showNTermsOfNaturalNumbersAndTheirSum()
        {
            int sum = 0;
            Console.Write("\n\nDisplay N terms of natural numbers and their sum : ");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nInput value of terms : \n\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nThe first {0} natural numbers are : ", n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
                sum += i;
            }
            Console.Write("\n\nThe sum of {0} natural numbers is : {1}", n, sum);
        }

        //program to read 10 numbers from keyboard and find their sum and average
        static void read10NumbersGetSumAndAverage() {
            Console.Write("\n\nInput the 10 numbers : \n\n");
            int sum = 0;
            for (int i = 1; i<= 10; i++) {
                Console.WriteLine("Number-{0} :", i);
                int input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }
            int average = sum / 10;
            Console.Write("\n\nThe sum of 10 no is : {0}", sum);
            Console.Write("\n\nThe average is : {0}", average);
        }


        //program to display the cube of the number upto given an integer
        static void showTheCubeOfNumberUptoAGivenInteger() {
            Console.Write("\n\nInput number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (int number=1; number<=n;number++) {
                int cubeOfTheNumber = (number*number*number);
                Console.WriteLine("Number is : {0} and the cube of the {0} is {1}", number, cubeOfTheNumber);
            }
        }

        //program to display the multiplication table of a given integer
        static void showMultiplicationTableOfAGivenInteger() {
            Console.Write("\n\nInput the number (Table to be calculated) : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (int i = 1; i<=10; i++) {
                int product = number * i;
                Console.Write("{0} X {1} = {2}", number, i, product);
            }
        }

        //program to display the multiplication table vertically from 1 to n
        static void showMultiplicationTableVerticallyFrom1ToN() {
            Console.Write("\n\nInput upto the table number starting from 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int number=1; number<=n; number++) {
                Console.Write("\nTable - {0}\n", number);
                for (int multiplier = 1; multiplier <= 10; multiplier++) {
                    int product = multiplier * number;
                    Console.WriteLine("{0} X {1} = {2}", number, multiplier, product);
                }
            }
        }

        //program to display the n terms of odd natural number and their sum
        static void showNTermsOfOddNumbersAndTheirSum() {
            Console.Write("\n\nInput number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int doubleTheN = n * 2;
            List<int> numbers = new List<int>();
            int sum = 0;
            for (int i = 0; i<=doubleTheN; i++) {
                bool isOdd = (i % 2 == 1);
                if (isOdd)
                {
                    numbers.Add(i);
                    sum += i;
                }
                else {
                    continue;
                }
            }
            String arrayConvertedToString = String.Join(" ", numbers.ToArray());
            Console.Write("\n\nThe odd numbers are : {0}", arrayConvertedToString);
            Console.Write("\n\nThe sum of odd natural numbers upto {0} terms : {1}", n, sum);
        }

        //program to display the pattern like right angle triangle using an asterisk
        static void showRightAngleTrianglePatternWithAsteriskUptoNRows() {
            Console.Write("\n\nDisplay the pattern like right angle using asterisk : ");
            Console.Write("\n\n---------------------------");
            Console.Write("\n\nInput the number of rows : ");
            Console.Write("\n\n");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=rows; i++) {
                for (int j = 1; j<= i; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        //program to display the pattern like right angle triangle with a number
        static void showRightAngleTriangleWithNumber() {
            Console.Write("\n\nDisplay pattern as right angle triangle using number : ");
            Console.Write("\n\n-----------------------");
            Console.Write("\n\nInput number of rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=rows; i++) {
                for (int j = 1; j<= i; j++) {
                    Console.Write("{0}", j);
                }
                Console.Write("\n");
            }
        }
    }
}
