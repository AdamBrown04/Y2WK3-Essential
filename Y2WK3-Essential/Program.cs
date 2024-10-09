Console.WriteLine("What porgram do you want to run? \n1)Username with underscore \n2)Check if number is between 0 and 256");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        List<string> usernames = new List<string>();

        Console.WriteLine("Enter END when you want the program to stop");
        while (true)
        {
            Console.Write("Enter a username: ");
            string usernameInput = Console.ReadLine();

            if (usernameInput.ToUpper() == "END")
            {
                break;
            }
            else
            {
                usernames.Add(usernameInput);
            }
        }

        IEnumerable<string> usersWithUnderscore = usernames.Where(username => username.Contains("_"));
        foreach (string username in usersWithUnderscore)
        {
            Console.WriteLine(username); 
        }
        break;
    case 2:
        List<int> listOfNumbers = new List<int>();

        Console.WriteLine("Enter END when you want the program to stop");
        while (true)
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();

            if(numberInput.ToUpper() == "END")
            {
                break;
            }
            else
            {
                listOfNumbers.Add(Convert.ToInt32(numberInput));
            }
        }

        bool withinRange = listOfNumbers.All(n => n < 256 && n > 0);
        if (withinRange)
        {
            Console.WriteLine("All numbers are within range");
        }
        else
        {
            Console.WriteLine("Not all numbers are within range");
        }
        break;
}