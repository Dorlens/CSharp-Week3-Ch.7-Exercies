using static System.Console;

//Write a program named CountVowelsModularized that passes a string to a method that returns the number of vowels in the string.



class CountVowelsModularized
{
    static void Main()
    {

        string vowels = "AEIOU";

        numOfVowels(vowels);

    }

        static void numOfVowels(string vowels)
        {

            int vowelsCount = 0;

            foreach(char i in vowels)
            {
                if(vowels.Contains(i))
                {
                        vowelsCount++;
                }
            }
            
                WriteLine("Number of vowels: " + vowelsCount);

        }

}