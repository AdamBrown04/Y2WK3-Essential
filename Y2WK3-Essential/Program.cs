using System.Security.Cryptography.X509Certificates;

Console.WriteLine("What porgram do you want to run? \n1)Username with underscore \n2)Check if number is between 0 and 256 \n3)Order car by year of production \n4)Student ID formatter \n5)Rectangle fun");
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

        IEnumerable<string> formattedA = studentIDs.Select(ID => ID.Replace("a", "1"));
        IEnumerable<string> formattedB = formattedA.Select(ID => ID.Replace("b", "2"));
        IEnumerable<string> finalFormat = formattedB.Select(ID => ID.Replace("c", "3"));

        foreach(string ID in finalFormat)
        {
            Console.WriteLine(ID);
        }
        break;
    case 5:
        Rectangle R1 = new Rectangle(15, 12);
        Rectangle R2 = new Rectangle(10, 22);
        Rectangle R3 = new Rectangle(9,7);
        Rectangle R4 = new Rectangle(18, 20);

        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(R1);
        rectangles.Add(R2);
        rectangles.Add(R3);
        rectangles.Add(R4);

        List<int> widths = new List<int>();
        foreach(Rectangle R in rectangles)
        {
            widths.Add(R.width);
        }

        List<int> heights = new List<int>();
        foreach(Rectangle R in rectangles)
        {
            heights.Add(R.height);
        }

        List<int> areas = new List<int>();
        foreach(Rectangle R in rectangles)
        {
            areas.Add(R.height * R.width);
        }

        int totalArea = areas.Sum();

        Console.WriteLine($"The highest width is: {widths.Max()} \nThe highest height is: {heights.Max()} \nThe total area is: {totalArea}");
        break;
        break;
}

class Car(string make, string model, string regPlate, int yearMade)
{
    public string make = make;
    public string model = model;
    public string regPlate = regPlate;
    public int yearMade = yearMade;
}

class Rectangle(int height, int width) 
{
    public int height = height;
    public int width = width;
}