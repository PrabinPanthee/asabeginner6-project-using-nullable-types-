using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("First Name : ");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Last Name :");
        string LastName = Console.ReadLine();
        bool? AreYouMajor = null;
        Console.WriteLine("Are you a Major (Y/N) : ");
       String areyoumajor =  Console.ReadLine();
        if (areyoumajor == "Y")
        {
            AreYouMajor = true;
            Console.WriteLine("User is Major");
        }
        else if (areyoumajor == "N")
        {
            AreYouMajor = false;
            Console.WriteLine("User is not Major");


        }
        else
        {
            Console.WriteLine("User did not  answer");
        }
        Console.WriteLine("First Name : {0}",FirstName);
        Console.WriteLine("Last Name : {0}",LastName);
        Console.WriteLine("{0}",AreYouMajor);



    }
}