using static System.Console;

// Create an application for a library and name it FineForOverdueBooks. The Main() method asks the user to input the number of books 
// checked out and the number of days they are overdue. Pass those values to a method that displays the library 
// fine, which is 10 cents per book per day for the first seven days a book is overdue, then
// 20 cents per book per day for each additional day.

class FineForOverdueBooks
{

    static void Main()
    {

            Write("Enter the number of books checked out: ");
           int checkedOutBooks = Convert.ToInt32(ReadLine());

           Write("Enter number of days the books overdue: ");
           int daysOverDue = Convert.ToInt32(ReadLine());

            LibraryFines(checkedOutBooks,daysOverDue);
    }
    static void LibraryFines(int checkedOutBooks, int daysOverDue )
    {

        double total =0;

       if(daysOverDue <=7)
          {
            double fine = checkedOutBooks * daysOverDue * 0.10;
            WriteLine("Your Total is: {0} ", fine);
          }
        else
           {
             double first7Days = checkedOutBooks * 7 * 0.10;
             double moreDays = checkedOutBooks *(daysOverDue-7) * 0.20;
             total = total+ first7Days + moreDays;

            
           }
            WriteLine("Your Total is: {0:F2} ", total);
           
          
    }

}