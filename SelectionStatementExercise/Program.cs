namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 rng
            var r = new Random();
            var fav = r.Next(1, 1000);
            
            //User input
            Console.WriteLine("I'm thinking of a number 1 - 1000, can you guess what it is?");
            var userInput = int.Parse(Console.ReadLine());

            bool guess = false;

            while (guess == false)
            {
                if (userInput > fav)
                {
                    Console.WriteLine("Too high, guess again: ");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput < fav)
                {
                    Console.WriteLine("Too low, guess again: ");
                    userInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Congratulations, you got it!");
                    guess = true;
                }
            }
        }
    }
}
