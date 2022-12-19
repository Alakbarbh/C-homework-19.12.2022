#region Homework(Calculator)
//using ConsoleApp1;

//Calculate();
//static void Calculate()
//{
//    Calculator calculator = new();

//    Console.WriteLine("Add first number :");

//Number1: string number1 = Console.ReadLine();
//    int checkednumber1;
//    bool isParseNum1 = int.TryParse(number1, out checkednumber1);

//    if (!isParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 1");
//        Console.ResetColor();
//        goto Number1;
//    }



//    Console.WriteLine("Add operation :");
//    string operation = Console.ReadLine();


//    Console.WriteLine("Add second number :");

//Number2: string number2 = Console.ReadLine();
//    int checkednumber2;
//    bool isParseNum2 = int.TryParse(number2, out checkednumber2);


//    if (!isParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 2");
//        Console.ResetColor();
//        goto Number2;

//    }


//    if (checkednumber2 == 0 && operation == "/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please a dont add 0");
//        Console.ResetColor();
//        goto Number2;


//    }



//    var result = calculator.Calculation(checkednumber1, checkednumber2, operation);



//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();

}
#endregion

#region Homework(Doctor)
//using ConsoleApp1;


//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 15);

//GetDoctorsByBirthday(startDate, endDate);

//static void GetDoctorsByBirthday(DateTime startDate, DateTime endDate)
//{
//    var doctors = GetDoctors();

//    foreach (var doctor in doctors)
//    {
//        if (doctor.Birthday > startDate && doctor.Birthday < endDate)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} {doctor.Birthday}");
//        }
//    }



//}








//static Doctor[] GetDoctors()
//{
//    Doctor doctor1 = new Doctor
//    {
//        Name = "Eycahan",
//        Surname = "Qurbanov",
//        Address = "Ehmedli",
//        Birthday = new DateTime(1994,10,05)

//    };

//    Doctor doctor2 = new Doctor
//    {
//        Name = "Shaig",
//        Surname = "Kazimov",
//        Address = "Sedmoy",
//        Birthday = new DateTime(2000, 10, 05)

//    };


//    Doctor doctor3 = new Doctor
//    {
//        Name = "Cavid",
//        Surname = "Ismayilzade",
//        Address = "Sulutepe",
//        Birthday = new DateTime(2000, 10, 05)

//    };

//    Doctor doctor4 = new Doctor
//    {
//        Name = "Pervin",
//        Surname = "Rehimli",
//        Address = "Sumqayit",
//        Birthday = new DateTime(2003, 10, 05)

//    };

//    Doctor doctor5 = new Doctor
//    {
//        Name = "Ferid",
//        Surname = "Abdullayev",
//        Address = "Hecyer",
//        Birthday = new DateTime(2005, 10, 05)

//    };



//    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };

//    return doctors;


//}
#endregion

#region Task.Order
//using ConsoleApp1;

//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order(new DateTime(2022, 12, 19), 200);
//    var order4 = new Order(new DateTime(2022, 12, 120), 1500);
//    var order5 = new Order(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order(new DateTime(2022, 12, 28), 500);

//    return new Order[] {order1,order2,order3,order4,order5,order6 };
//}

//DateTime filteredDate = DateTime.Now.AddDays(1);

//double filteredPrice = 200;

//GetFilteredOrders(filteredDate, filteredPrice);




//static void GetFilteredOrders(DateTime date, double price)
//{
//    var orders = GetOrders();

//    foreach (var item in orders)
//    {
//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date.ToString("MM-dd-yyyy") + ":" + item.Price);
//        }


//    }

//}
#endregion

#region Task.Person
//using ConsoleApp1;
//using System.Net.Cache;

//Person person = new Person();

//static Person[] Persons()
//{

//    Person person1 = new Person();

//    person1.Name = "Konul";
//    person1.Surname = "Ibrahimova";
//    person1.Age = 26;
//    person1.IsMarried = true;



//    Person person2 = new Person();

//    person2.Name = "Shaig";
//    person2.Surname = "Kazimov";
//    person2.Age = 25;
//    person2.IsMarried = false;


//    Person person3 = new Person();



//    person3.Name = "Roya";
//    person3.Surname = "Maharramova";
//    person3.Age = 26;
//    person3.IsMarried = true;


//    Person person4 = new Person();



//    person4.Name = "Eycahan";
//    person4.Surname = "Qurbanov";
//    person4.Age = 19;
//    person4.IsMarried = false;


//    Person[] persons = { person1, person2, person3, person4 };


//    return persons;

//}

//PersonIsMarried(12);


//static void PersonIsMarried(int Age)
//{
//    int count = 0;
//    var result = Persons();
//    foreach (var item in result)
//    {
//        if (item.Age > Age && item.IsMarried)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}
#endregion






