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
            string userSignupUserName = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string userSignupPassword = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            // Making use of my UserAccount constructor to create a new instance of a UnserAccount

            UserAccount newUserAccount = new UserAccount(userSignupUserName, userSignupPassword);

            Console.WriteLine($"You have successfully signed up into our app, Welcome {newUserAccount._username} your acount has been saved");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter 'L' to Logout of the App or 'K' to exit Application");

            string userLogOut = Console.ReadLine().ToUpper();

            if (userLogOut == "L")
            {
                Console.WriteLine("You have successfully logged out of the application");
                Console.WriteLine();
                Console.WriteLine("Enter 'P' to login again or 'X' to exit application");

                string loginAgain = Console.ReadLine().ToUpper();

                if (loginAgain == "P")
                {
                    Console.WriteLine("To Login into our app, enter your username");
                    Console.WriteLine("Please Note: you have only 3 trials to enter the correct username and password");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter you username");

                    string userLoginUserName = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("enter your password");
                    Console.WriteLine();

                    string userLoginPassword = Console.ReadLine();

                    // Now its time to get the already stored username and password in the UserAccount constructor with the aid of my Getter method

                    string alreadyStoredUserNameInMyConstructor = newUserAccount.GetUserName();
                    string alreadyStoredPasswordInMyConstructor = newUserAccount.GetUserPassword();

                    // A branch to determine if the newly enterred details match-up with the previously enterred details
                    if (userLoginUserName == alreadyStoredUserNameInMyConstructor && userLoginPassword == alreadyStoredPasswordInMyConstructor)
                    {
                        Console.WriteLine($"You have successfully Logged in into our App, Welcome {newUserAccount.GetUserName()}");
                    }
                    // a branch for if user inputs a username I have in my application but enters in a wrong password
                    else if (userLoginUserName == alreadyStoredUserNameInMyConstructor && userLoginPassword != alreadyStoredPasswordInMyConstructor)
                    {
                        Console.WriteLine($"The UserName you enterred; {userLoginUserName} exists in our app's database but you enterred a wrong password");
                        Console.WriteLine("You have two trials left, enter 'Y' to try again and 'N' to quit application");

                        string userLoginSecondTrial = Console.ReadLine().ToUpper();

                        if (userLoginSecondTrial == "Y")
                        {
                            Console.WriteLine("Please Note: you have only 2 trials left to enter the correct username and password");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter you username");

                            string secondTrialUserLoginUserName = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("enter your password");
                            Console.WriteLine();

                            string secondTrialUserLoginPassword = Console.ReadLine();

                            // running a branch to determine if user got it right the second time
                            if (secondTrialUserLoginUserName == alreadyStoredUserNameInMyConstructor && secondTrialUserLoginPassword == alreadyStoredPasswordInMyConstructor)
                            {
                                Console.WriteLine($"You have successfully Logged in into our App, Welcome {newUserAccount.GetUserName()}");
                            }
                            else if (secondTrialUserLoginUserName == alreadyStoredUserNameInMyConstructor && secondTrialUserLoginPassword != alreadyStoredPasswordInMyConstructor)
                            {
                                Console.WriteLine($"The UserName you enterred; {userLoginUserName} exists in our app's database but you enterred a wrong password");
                                Console.WriteLine("This is your last trial, enter 'Y' to try again and 'N' to quit application");

                                string userLoginThirdTrial = Console.ReadLine().ToUpper();


                                if (userLoginThirdTrial == "Y")
                                {
                                    Console.WriteLine("Please Note: you have only 2 trials left to enter the correct username and password");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter you username");

                                    string lastTrialUserLoginUserName = Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("enter your password");
                                    Console.WriteLine();

                                    string lastTrialUserLoginPassword = Console.ReadLine();

                                    if (secondTrialUserLoginUserName == alreadyStoredUserNameInMyConstructor && secondTrialUserLoginPassword == alreadyStoredPasswordInMyConstructor)
                                    {
                                        Console.WriteLine($"You have successfully Logged in into our App, Welcome {newUserAccount.GetUserName()}");
                                    }
                                    else if (secondTrialUserLoginUserName == alreadyStoredUserNameInMyConstructor && secondTrialUserLoginPassword != alreadyStoredPasswordInMyConstructor)
                                    {
                                        Console.WriteLine($"The UserName you enterred; {userLoginUserName} exists in our app's database but you enterred a wrong password");
                                        Console.WriteLine("That was your last trial, unfortunately we can't sign you in, Please signup for a new account");
                                        Main();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry we didn't get that, Please try again");
                                        Main();
                                    }


                                }
                                else if (userLoginThirdTrial == "N")
                                {
                                    Console.WriteLine("Goodbye My Dear User, unfortunately we couldn't sign you in :() ");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry we didn't get that, Please try again");
                                    Main();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Sorry we didn't get that, Please try again");
                                Main();
                            }
                        }

                        else if (userLoginSecondTrial == "N")
                        {
                            Console.WriteLine("Goodbye My Dear User, unfortunately we couldn't sign you in :( ");
                        }
                        // to ensure application doesn't break, I run a last else branch to start app again and this is just in case user enters in something my app doesn't understand
                        else
                        {
                            Console.WriteLine("Sorry we didn't get that, Please try again");
                            Main();
                        }
                    }


                    else if (userLoginUserName != alreadyStoredUserNameInMyConstructor && userLoginPassword != alreadyStoredPasswordInMyConstructor)
                    {
                        Console.WriteLine($" The UserName; {userLoginUserName} and password you enterred does not exists in our app's database");
                        Console.WriteLine();
                        Console.WriteLine("Please Try signing up and Logging in again");
                        Main();
                    }





                }
                else if (loginAgain == "X")
                {
                    Console.WriteLine("Goodbye My Dear User");
                }
                else
                {
                    Console.WriteLine("Sorry we didn't get that, Please try again");
                    Main();
                }


            }
            else if (userLogOut == "X")
            {
                Console.WriteLine($"Goodbye {newUserAccount}");

            }
            else
            {
                Console.WriteLine("Sorry we didn't get that, Please try again");
                Main();
            }

        }
        else if (startApp == "NO")
        {
            // my user isn't interested in signing in
            Console.WriteLine("Goodbye My Dear User");
        }
        else
        {
            // starting application from scratch again if user inputs in a wrong or an unexpected answer
            Console.WriteLine("Sorry we didn't get that, Please try again");
            Main();
        }
    }
}
