// The business logic file for my application

using System;

// creating a namespace to store all of my business logic classes, so I can choose to use anyone of them in mu UI logic file
// we added Models to the name because 'Models' is the stanndard ame in C# for Business Logic
namespace PasswordDeterminer.Models
{
    // I need a constructor that will be a format on how users create accounts(with usernames and passwords that are both in strings) 
    // don't forget that a constructor is like a format on how to create instances(examples) of a specific class ---in our shapetracker app, the triangle costuctors purpose was to create a formt that will help in creating instances(examples) of a Triangle object(and that triangle objects needed 3 sides)
    // But before a constructor we need a class; as constructors are the formats for creating instances of a class and a C# constructor is actually created inside the class itself

    public class UserAccount{
        // adding C# fields now to our class(don't forget we need 2 string fields in our object; one for username and one for password)
        // also with the naming convention: underscore and lower camel casing we know we are creating a private field that cannot be altered by external methods we call on our class in our UserInterface logic
        public string _username;
        public string _password;
        // the 2 string fields above are very descriptive and can be easily understood

        // ADDING A CONSTRUCTOR
        // we want to add a custom constructor that sets the values for the username and password when the UserAccount is created
        // Another definition of a constructor is a method that is called when a new instance of a class is create. Any information regarding the initial setup of a new object(the initial format for creating a new object) can be included in a constructor

        public UserAccount(string myUsersname, string myUsersPassword)
        {
            _username = myUsersname;
            _password = myUsersPassword;


        // a brief overview on how a C# constructor is created:
        // ---> To create a constructor, we simply define a method of the SAME NAME of the class
        // ---> and we add our access modifier public which is an access modifier that ensures our method is available anywhere in our application
        // ---> our constructor can take none or multiple parameters and here we gave it 2 string parameters(myUsersname and myUsersPassword)
        // ---> and between the body of our constructor(the curly braces) we add in any code we want to execute 
        // and the code we want to execute is to equate each of our parameters(myUsersname and myUsersPassword) to the fields a UserAccount object should have which are: Username and Password
        }

         // Note that the class's fields are in Pascal case while the constructor's Parameters are lowerCamelCase.Thats because they are variables

        // Now its time to make use of my getters and setters to get and set information and to ensure that an external method like the DeterminePassword method can have access to my private fields

        // First a Getter() methods for my DeterminePassword method
        // don't forget; a getter helps us get information 

        public string GetUserName(){
            return _username;
        }

        public string GetUserPassword(){
            return _password;
        }

        // for the setter method now
        // a setter helps us set informaton
        public string SetUserName(string newUserName)
        {
            _username = newUserName;   
        }
        public string SetUserPassword(string newUserPassword)
        {
            _password = newUserPassword;
        }
        

        // Having written ny setter and getter method that ensures my method can access a private field(_username and _password) its time to write my 
        // DeterminePassword method

        public string DeterminePassword()
        {
            // App to be continued later---------
        }


    }
    
}