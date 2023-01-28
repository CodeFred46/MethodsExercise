namespace MethodsExercise
{
    public class Program
    {


        public static int Sum(int num1, int num2)
        {
            
            var answer = num1 + num2;
            return answer = num1 + num2;



        }



        public static int Multiply(int x, int y)
        {

            var answer = x * y;
            return answer = x * y;

        }



        static void Main(string[] args)

        {   //Add Exercise--------------------------------------

            Console.WriteLine("Type a number?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type another number?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is {sum}");





            //Multiply Exercise-------------------------------------

            Console.WriteLine("Type a number?");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type another number to mutiply?");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"the sum is {product}");

             

            // Exercise 1------------------------------------------------------------------

            Console.WriteLine ("What is your first name on your birth certificate?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color to wear places?");
            string colorName = Console.ReadLine();

            Console.WriteLine("What is your most enjoyable animal in the world?");
            string animalName = Console.ReadLine();

            Console.WriteLine("What is your favorite band, you would pay to see?");
            string bandName = Console.ReadLine();


            Console.WriteLine($" {userName} is his name."); 
            Console.WriteLine($"His best color to wear is {colorName}.");
            Console.WriteLine($"His most enjoyable animal is a {animalName}.");
            Console.WriteLine($"he paid to see {bandName} in concert.");





            Console.ReadLine();

        }




        

       





        
    }
}
