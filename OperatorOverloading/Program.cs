﻿namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }

        // Overload unary operators ++ and -- 
        // Code goes here
        public static Calculator operator ++(Calculator obj)
        {
            //obj.number++;
            ++obj.number;
            
            return obj;
        }
        public static Calculator operator --(Calculator obj)
        {
            //obj.number--;
            --obj.number;
            
            return obj;
        }

        // Overload Comparison Operators > and <
        // Code goes here

        // Overloading of  ">" operator
        public static bool operator >(Calculator left, Calculator right)
        {
            bool larger = false;
            if (left.number > right.number)
                larger = true;
            return larger;
        }
        // Overloading of  "<" operator
        public static bool operator <(Calculator left, Calculator right)
        {
            bool smaller = false;
            if (left.number < right.number)
                smaller = true;
            return smaller;
        }

        // Overload Binary Operators + and -

        // Overloading of  "+" operator
        public static Calculator operator +(Calculator obj1, Calculator obj2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = obj1.number + obj2.number;
            return Calc3;
        }

        public static Calculator operator -(Calculator obj1, Calculator obj2)
        {
            Calculator Calc4 = new Calculator();
            Calc4.number = obj1.number - obj2.number;
            return Calc4;
        }


        // Code goes here

        static void Main(string[] args)
        {
            Random r = new Random();
            // create object array
            Calculator[] numbers = new Calculator[10];
            // place random numbers into array and print values
            Console.Write("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); // creates the object
                numbers[i].number = r.Next(1, 100);  // places a value in the object
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();
            // if divisible by 2, add 1 to value using operator ++ method
            // otherwise subtract 1 from value using operator -- method
            Console.Write("New Numbers +1 or -1= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    // Code goes here
                    numbers[i]++;
                }
                else
                {
                    // Code goes here
                    numbers[i]--;
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object to add
            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
            // Using operator +, add numToAdd.number to each element in the array
            // Print the results
            Console.Write($"Numbers + {numToAdd.number} = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += numToAdd;
                Console.Write(" " + numbers[i].number);

            }
                // Code goes here

                Console.WriteLine();

            // random Calculator object to subtract
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            // Using operator -, subtract numToSub.number from each element in the array
            // Print the results
            Console.Write($"Numbers - {numToSub.number}= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= numToSub;
                Console.Write(" " + numbers[i].number);

            }
            // Code goes here

            Console.WriteLine();

            // random Calculator object for comparison
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            // Using operator > and operator <, compare each element to numToCompare.number
            // print if the element is higher, lower or equal to the number you are comparing to
            Console.WriteLine($"Numbers above or below {numToCompare.number}");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numToCompare)
                    Console.WriteLine(numbers[i].number + " is greater.");
                else if (numbers[i]<numToCompare)
                    Console.WriteLine(numbers[i].number + " is lesser.");
                else
                    Console.Write(numbers[i].number + " is the same number.");

            }
            // Code goes here
        }
    }
}
