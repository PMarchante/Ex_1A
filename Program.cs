using System;

namespace Ex_1A
{
    /*
     * Pedro Marchante
     * MSSA Exercise 1A
     */
    class Program
    {
        private int num;

        public double calculateCircumference(double input)
        {
            double answer = (2 * Math.PI * input);

            return answer;
        }

        public double areaCircle(double input)
        {
            double answer = Math.PI * Math.Pow(input, 2);

            return answer;
        }

        public double volumeSphere(double input)
        {

            double answer = (4 * Math.PI * (Math.Pow(input, 3))) / 3;

            return answer;

        }

        public double areaOfTriangle(int s1, int s2, int s3)
        {

            int halfCircumference = ((s1 + s2 + s3) / 2);
            int tmp = (halfCircumference * ((halfCircumference - s1)) * (halfCircumference - s2) * (halfCircumference - s3));
            double answer = Convert.ToDouble(tmp);
            double area = Math.Sqrt(answer);

            return area;
        }

        public double quadratic(int a, int b, int c)
        {

            double tmp = Math.Pow(b, 2) - (4 * a * c);

            if (tmp < 0)
            {
                Console.WriteLine("cannot take the square root of a negative number");
                return 0;
            }

            else
            {
                double x1;
                double x2;

                x1 = (-b + Math.Sqrt(tmp)) / (2 * a);
                x2 = (-b - Math.Sqrt(tmp)) / (2 * a);

                //cannot return both values for x, so i willreturn the highest value of x
                int compare = x1.CompareTo(x2);

                if (compare >= 1)
                {
                    return x1;
                }

                if (compare <= 1)
                {
                    return x2;
                }


            }
            return 0;
        }

        static void Main(string[] args)
        {

            Program test = new Program();

            string input;

            do
            {
                Console.WriteLine("Welcome to Mathbot\n");
                Console.WriteLine("I can perform these operations\n");
                Console.WriteLine("1: calculate circumference of a circle");
                Console.WriteLine("2: calculate area of a circle");
                Console.WriteLine("3: calculate volume of a sphere");
                Console.WriteLine("4: calculate area of triangle");
                Console.WriteLine("5: solve a quadratic formula");
                Console.WriteLine("input the corresponding number to perform that operation. type n to exit");

                input = Console.ReadLine();

                int condition = Convert.ToInt32(input);
                switch (condition)
                {

                    case 1:
                        Console.WriteLine("What is the radius of the circle?");
                        input = Console.ReadLine();
                        double result = test.calculateCircumference(Convert.ToDouble(input));
                        Console.WriteLine(result);
                        Console.WriteLine("Do you want to perform another math function? y = yes, n= exit");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("What is the radius of the circle?");
                        input = Console.ReadLine();
                        double result1 = test.areaCircle(Convert.ToDouble(input));
                        Console.WriteLine(result1);
                        Console.WriteLine("Do you want to perform another math function? y = yes, n= exit");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine("What is the radius of the sphere?");
                        input = Console.ReadLine();
                        double result2 = test.volumeSphere(Convert.ToDouble(input));
                        Console.WriteLine(result2);
                        Console.WriteLine("Do you want to perform another math function? y = yes, n= exit");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("What is the length of side 1");
                        input = Console.ReadLine();
                        int side1 = Convert.ToInt32(input);

                        Console.WriteLine("What is the length of side 2");
                        input = Console.ReadLine();
                        int side2 = Convert.ToInt32(input);

                        Console.WriteLine("What is the length of side 3");
                        input = Console.ReadLine();
                        int side3 = Convert.ToInt32(input);

                        double result3 = test.areaOfTriangle(side1, side2, side3);
                        Console.WriteLine(result3);
                        Console.WriteLine("Do you want to perform another math function? y = yes, n= exit");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        Console.WriteLine("For quadratic formula we require the values is a,b and c and will return the highest value of x");
                        Console.WriteLine("What is the value of a?");
                        input = Console.ReadLine();
                        int a = Convert.ToInt32(input);

                        Console.WriteLine("What is the value of b?");
                        input = Console.ReadLine();
                        int b = Convert.ToInt32(input);

                        Console.WriteLine("What is the value of c?");
                        input = Console.ReadLine();
                        int c = Convert.ToInt32(input);

                        double result4 = test.quadratic(a, b, c);
                        Console.WriteLine(result4);
                        Console.WriteLine("Do you want to perform another math function? y = yes, n= exit");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        break;
                }
            } while (!input.Equals("n"));


        }
    }
}
