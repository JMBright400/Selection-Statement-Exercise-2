using System.IO.Pipes;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())

            { 
                case "math":
                    Console.WriteLine("Math is great! Computers such as myself also enjoy working with numbers.");
                    break;

                case "history":
                    Console.WriteLine("History is great! It allows humanity to look into the past.");
                    break;

                case "science":
                    Console.WriteLine("Science is incredible! We can study the world and all life within it thanks to science.");
                    break;

                case "music":
                    Console.WriteLine("Music is beautiful! It is very soothing and allows the composer so much freedom to create.");
                    break;

                case "english":
                    Console.WriteLine("English is excellent. It is required for communication as well as the ability to read literature.");
                    break;

                default:
                    Console.WriteLine("Oooh! That is an awesome subject. I think it is my favorite as well.");
                    break;
            }
        }   

    }
}