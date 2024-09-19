using static System.Console;

// Create a program named FortuneTeller whose Main() method contains an array of at least six strings with fortune-telling 
// phrases such as I see a tall, dark stranger in your future. The program randomly selects two different fortunes and 
// passes them to a method that displays them.
class FortuneTeller
{

    static void Main()
    {

            string [] fortuneTelling = {"I see a tall, dark stranger in your future."," The stars align in your favor" ,
             " The past holds lessons the future holds possibilities.", "A journey of a thousand miles begins with a single step.",
             "Every ending is a new beginning.", " Every ending is a new beginning."};

             Random random = new Random();
             int Random1 = random.Next(fortuneTelling.Length);
             int Random2 = random.Next(fortuneTelling.Length);



            
             do{
                    Random2 = random.Next(fortuneTelling.Length);

             }while(Random2==Random1);

             displayFortune(fortuneTelling[Random1],fortuneTelling[Random2]);


    }
    static void displayFortune(string fortune1, string  fortune2)
    {
        WriteLine("Your Fortunes");
        WriteLine(fortune1);
        WriteLine(fortune2);
        

    }
}