
// Global Variables
string name = "";
List<Student> students = new List<Student>();

while(1==1)
{
    Console.WriteLine("****************************************");
    Console.WriteLine("           TEACHER PANEL LOGIN          ");
    Console.WriteLine("****************************************");
    Console.WriteLine("- Please Enter the login informations!");

    Console.Write("Teacher Name: ");
    name = Console.ReadLine();

    Console.Write("Teacher Password: ");
    string password = Console.ReadLine();


    if (name == "Ali" & password == "07080708a")
    {
        break;
    } else
    {
        Console.WriteLine("Name or Password is not correct! Please try again.");
    }
}

while (1 == 1)
{
    Console.WriteLine("****************************************");
    Console.WriteLine("              TEACHER PANEL             ");
    Console.WriteLine("****************************************");
    Console.WriteLine("- 1 - Show students.");
    Console.WriteLine("- 2 - Add student.");
    Console.WriteLine("- 3 - Remove student.");
    Console.WriteLine("- 4 - Add exam result.");
    Console.WriteLine("- q/Q - Exit.");

    Console.Write(" : ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("--------------------------------------");
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine(
        $"[{i + 1}] -> {students[i].Name} -> {students[i].Point} -> [{(students[i].Point > 50 ? "A" : "F")}]"
            );
        }
        Console.WriteLine("--------------------------------------");
    } else if (choice == "2")
    {
        Console.Write("Enter the student name : ");
        string st_name = Console.ReadLine();

        if (st_name.Length > 1 & !students.Any(student => student.Name == st_name)) 
        {
        students.Add(new Student {Name = st_name, Point = 0 });

        Console.WriteLine($"Student {st_name} successfully added!");
        } else
        {
            Console.WriteLine("Please enter a valid student name or check the same name try to numarate them!s");
        }
    } else if (choice == "3")
    {
        Console.Write("Enter the student name : ");
        string st_name = Console.ReadLine();

        students.RemoveAll(student => student.Name == st_name);
        Console.WriteLine($"Student {st_name} successfully removed!");
    } else if (choice == "4")
    {
        Console.Write("Enter the student name : ");
        string st_name = Console.ReadLine();

        Console.Write("Enter the student exam result : ");
        double st_point = Convert.ToDouble(Console.ReadLine());
        
        if (students.Any(student => student.Name == st_name))
        {
        Student? student = students.FirstOrDefault(student => student.Name == st_name);

        student.Point = st_point;

        Console.WriteLine($"Student {st_name} successfully changed!");
        } else
        {
            Console.WriteLine($"{st_name} could not find!");
        }
    } else if (choice == "q" | choice == "Q")
    {
        Console.WriteLine($"Goodbye {name}!");
        break;
    }
}



class Student
{
    public string Name;
    public double Point;
}
