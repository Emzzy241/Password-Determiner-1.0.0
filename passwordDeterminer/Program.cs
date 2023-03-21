using System;
using System.Collections.Generic; // This is the enamespace that gives me access to usng Dictionaries, Lists, e.t.c
using System.Linq; // This is the namespace that gives me access to the .ElementAt() property which Is used when looping through dictionaries
using PasswordDeterminer.Models; // Importing the namespace that is housing all of my business logic classes --> this ensures I can create a new instance of my UserAccount class right here in my UI logic file




// don't forget the Main() method is our Entry point method and we added void to it to ensure the method returns nothing 
class Program
{
    static void Main()
    {
        // // creating my empty Dictionary that would be storing the username(in string) and the password(in string also)
        // Dictionary<string, string> passwordDictionary = new Dictionary<string, string>(){};





        Console.WriteLine("Welcome To the Password Determiner App");
        Console.WriteLine("Please Enter your login Details");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Enter 'Yes' to continue and 'No' to exit App");
        string startApp = Console.ReadLine().ToUpper();
        //  made use of the .ToUpper() method to turn the entire value of my user to uppercase so my code doesn't break
        
        if (startApp == "YES")
        {
            // now I know my user would like to sign up
            Console.WriteLine("Please Enter your details");
            Console.WriteLine();
            Console.WriteLine("Enter your Username:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            // Making use of my UserAccount constructor to create a new instance of a UnserAccount

            UserAccount newUserAccount = new UserAccount(userName, password);

            Console.WriteLine($"You have successfully signed up into our app, Welcome {newUserAccount._username} your acount has been saved");
        
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter 'L' to Logout of the App or 'K' to exit Application");

            string userLogOut = Console.ReadLine();

            if (userLogOut == 'L')
            {
                Console.WriteLine("You have successfully logged out of the application");
                Console.WriteLine();
                Console.WriteLine("Enter 'P' to login again or 'X' to exit application");
            }
            else if(userLogOut == 'K')
            {
                Console.WriteLine($"Goodbye {newUserAccount}");

            }
        
        }
        else if(startApp == "NO"){
            // my user isn't interested in signing in
            Console.WriteLine("Goodbye My Dear User");
        }
        else{
            // starting application from scratch again if user inputs in a wrong or an unexpected answer
            Main();
        }


    }
}