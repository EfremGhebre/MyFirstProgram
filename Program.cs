namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Efrem Ghebre .Net23

            int x = 13; //a variable that stores a specific number 

            if (x > 10) //an if-statement that executes after checking the condition
            {
                Console.WriteLine("Talet är stort! ");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal! ");
            }
            
            Console.WriteLine("Vad heter du? "); //text display that asks the user name  
            var namn = Console.ReadLine();//retrieves the user´s input and stores it in a variable

            Console.WriteLine( $"Hej {namn}!");//prints out both Hej and the user´s name

            for (int i = 0; i <= x; i++) // a for-loop that displays the numbers from 0 upto 13  
            {
                Console.WriteLine(i);
            }
            
        }
    }
}