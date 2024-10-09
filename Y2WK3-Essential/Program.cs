Console.WriteLine("What porgram do you want to run? \n1)Username with underscore \n2)Check if number is between 0 and 256 \n3)Order car by year of production \n4)Student ID formatter");
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
    case 3:
        List<Car> cars = new List<Car>();

        Car newCar3 = new Car("Ford", "Cortina", "KJM 212K", 1972);
        Car newCar1 = new Car("Kia", "Cee'd", "PK10 RBO", 2010);
        Car newCar2 = new Car("Audi", "Quatro", "JLY 75IV", 1980);
        

        cars.Add(newCar1);
        cars.Add(newCar2);
        cars.Add(newCar3);

        IEnumerable<Car> orderedCars = cars.OrderBy(car => car.yearMade);

        foreach (Car car in orderedCars)
        {
            Console.WriteLine($"{car.make} {car.model}");
        }
        break;
    case 4:
        List<string> studentIDs = new List<string>();
        studentIDs.Add("a123456");
        studentIDs.Add("b654321");
        studentIDs.Add("c321456");

        IEnumerable<string> formattedStudentIDs = studentIDs.Select(ID => ID.Replace("A", "1"), ID.Replace("B", "2"));
        break;
}

class Car(string make, string model, string regPlate, int yearMade)
{
    public string make = make;
    public string model = model;
    public string regPlate = regPlate;
    public int yearMade = yearMade;
}
