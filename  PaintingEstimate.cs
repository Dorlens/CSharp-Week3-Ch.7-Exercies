using static System.Console;

//  Create a program named PaintingEstimate whose Main() method prompts a user for length and width of a room in feet. 
// Create a method that accepts the values and then computes the cost of painting the room, 
// assuming the room is rectangular and has four full walls and 9-foot ceilings. The price of the job is $6 per square foot. 
// Return the price to the Main() method, and display it.

class  PaintingEstimate
{

    static void Main()
    {
        paintEstimator();
    }


        static  void paintEstimator()
        {
            WriteLine("Enter the Length");
            int Length = Convert.ToInt32(ReadLine());

            WriteLine("Enter the width");
            int width = Convert.ToInt32(ReadLine());


            int total = (Length *9 +width *9)*2;

            int totalCost  = total *9;
            WriteLine(totalCost);
        }
}