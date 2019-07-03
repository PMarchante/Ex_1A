using System;

namespace Ex_1A
{
    class Program
    {

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

            double answer = (4 / 3 * Math.PI * Math.Pow(input, 3) / 2);

            return answer;

        }

        public double areaOfTriangle(int s1, int s2, int s3)
        {

            int halfCircumference = ((s1 + s2 + s3) / 2);
            int tmp = (halfCircumference * (halfCircumference - s1)) * (halfCircumference - s2) * (halfCircumference - s3);
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

            //Console.WriteLine(test.areaCircle(7));
            //Console.WriteLine(test.quadratic(2, 5, -3));

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
            } while (!input.Equals("n"));


        }
    }
}
