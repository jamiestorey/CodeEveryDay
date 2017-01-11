using System;
using System.IO;

class Program
{
    static string directory1;
    static string usersDirectory;
    static string userFileExtension;
    
    static void Main(string[] args)
    {
        userFileExtension = ".txt";
        directory1 = Directory.GetCurrentDirectory();
        if (!Directory.Exists(directory1 + "/users/"))
        {
            Directory.CreateDirectory(directory1 + "/users/");
        }
        usersDirectory = directory1 + "/users/";
        Console.WriteLine(Directory.Exists(usersDirectory));
        Console.WriteLine("usersDirectory = {0}", usersDirectory);
        Console.WriteLine(usersDirectory);
        AddAccount("John Smith", "42","103", "200");
        AddAccount("Betsy Smith", "38", "70", "67");
        Menu();
        
    }

   
    public static void Menu()
    {
        string command = "";
        //Don't display the menu if the command is 0 because command 0 closes the program.
        while (command != "0")
        {
            DisplayMenu();
            command = GetCommand();
            ExecuteCommand(command);
        }
    }
   
    private static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Enter number denoting action to perform:");
        Console.WriteLine("Add an Account \t\t[1]");
        Console.WriteLine("Display All UserNames\t[2]");
        Console.WriteLine("Display User Details\t[3]");
        Console.WriteLine("Display All User Details[4]");
        Console.WriteLine("Quit\t\t\t[0]");
        Console.WriteLine();
    }

    private static string GetCommand()
    {
        Console.WriteLine("Enter a command from the list above:");
        return Console.ReadLine();
    }
    /// <summary>
    /// Checks the command the user entered matches an available command. If it does then it executes that command.
    /// If not then a message will inform the user that the command can't be found.
    /// </summary>
    /// <param name="command">The command to execute</param>
    private static void ExecuteCommand(string command)
    {
        if (command.Equals("0") || command.Equals("exit"))
        {
            Exit();
        }
        else if (command.Equals("1"))
        {
            AddAccount();
        }
        else if (command.Equals("2"))
        {
            DisplayUsers();
        }
        else if (command.Equals("3"))
        {
            Console.WriteLine("Enter the UserName to find.");
            GetUser(Console.ReadLine());
        }
        else if (command.Equals("4") || command.Equals("help"))
        {
            GetAllUser();
        }
        else
        {
            Console.WriteLine("Unkown Command");
        }
    }

    private static void DisplayUsers()
    {
        foreach (var userFile in Directory.GetFiles(usersDirectory))
        {
            Console.WriteLine(userFile);
        }
    }

    private static void Exit()
    {
        Console.WriteLine("Exiting program. Press enter to close the application.");
        Console.Read();
        Environment.Exit(0);
    }

    private static void GetUser(string userName)
    {
        string userFile = usersDirectory + userName + userFileExtension;
        if (File.Exists(userFile))
        {
            string[] details = ParseUserDetails(userFile);

            Console.WriteLine("Age = {0}", details[3]);
            Console.WriteLine("Height = {0}", details[5]);
            Console.WriteLine("Weight = {0}", details[7]);
        }
        else
        {
            Console.WriteLine("Error user [{0}] does not exist.", userName);
        }
    }

    private static void GetAllUser()
    {

        foreach (var user in Directory.GetFiles(usersDirectory))
        {
            string[] details = ParseUserDetails(user);

            Console.WriteLine(details[1]);
            Console.WriteLine("Age = {0}", details[3]);
            Console.WriteLine("Height = {0}", details[5]);
            Console.WriteLine("Weight = {0}", details[7]);
            Console.WriteLine();
        }
        
            
        
    }

    private static void AddAccount()
    {
        string userName = "";
        string age = "";
        string height = "";
        string weight = "";
        Console.WriteLine("Enter a username:");
        userName = Console.ReadLine();
        string userFile = usersDirectory + userName + userFileExtension;


        if (!File.Exists(usersDirectory +  userName + userFileExtension))
        {
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            Console.WriteLine("How tall are you in cm? Example 173");
            height = Console.ReadLine();

            Console.WriteLine("What is your weight in killograms (kg)? Example 180");
            weight = Console.ReadLine();

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(userFile))
            {
                sw.WriteLine("username:" + userName);
                sw.WriteLine("age:" + age);
                sw.WriteLine("height:" + height);
                sw.WriteLine("weight:" + weight);
            }
            Console.WriteLine("User [{0}] was created" ,userName);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("User [{0}] already exists.", userName);
        }
    }

    private static void AddAccount(string userName, string age, string height, string weight)
    {
        string userFile = usersDirectory + userName + userFileExtension;
        if (!File.Exists(userFile))
        {
            using (StreamWriter sw = File.CreateText(userFile))
            {
                sw.WriteLine("username:" + userName);
                sw.WriteLine("age:" + age);
                sw.WriteLine("height:" + height);
                sw.WriteLine("weight:" + weight);
            }
            Console.WriteLine();
            Console.WriteLine("User [{0}] was created", userName);
        }
        else
        {
            Console.WriteLine("User [{0}] already exists.", userName);
        }
    }

    private static string[] ParseUserDetails(string fileName)
    {
        string fileContent = File.ReadAllText(fileName);

        string[] integerStrings = fileContent.Split(new char[] { ':', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        //int[] attributes = new int[integerStrings.Length];

        //Console.WriteLine(attributes);
        return integerStrings;
    }
}