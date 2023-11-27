using ICP;

public class MainClass
{
    public static void Main(string[] args)
    {
        //ICP.Student var1 = new Student();
        //ICP.Admin var2 = new Admin();
        //ICP.Staff var3 = new Staff();
        //var1.StudentName = "vamsha";
        //Console.WriteLine(var1.StudentName);
        /*Herald.Staff var3 = new Herald.Staff();
        var3.StaffName= "funky";
        Console.WriteLine(var3.StaffName);

        Console.WriteLine("\n\n");
        ICP.Student stu1 = new Student();
        //stu1.PrintString();

        stu1.SetStudentName(stu1.FixedArr[0]);

        ICP.Student stu2 = new Student();
        stu2.SetStudentName(args[0]);
        Console.WriteLine($"the student name of stu2 is: {stu2.getStudentName()}");
        Console.WriteLine($"the student name of stu1 is: {stu1.getStudentName()}");*/

        //Student a = new Student();
        //AskForMarks(a);

        Staff b = new Staff();
        Ask4Staff(b);
        NewStaffDetail(b);

        Student s1 = new Student();
        s1.SetMyDetail("S 1",1,1);
        Student s2 = new Student();
        s1.SetMyDetail("S 2", 2, 2);
    }

    public static void NewStaffDetail(Staff s)
    {
        Console.WriteLine("\nEnter the Subject to print Detail for: ");
        string str = Console.ReadLine();
        try
        {
            s.PrintSubjectDetails(str);
        }
        catch (Exception e)
        {
            Console.WriteLine($"The subject {str} is not taught. \n{e.Message}");
            //throw;
        }
        s.SetMyDetails("Nefoli", "1234567890");
        Staff s2 = new Staff();
        s2.SetMyDetails("Staff 2 ", "0987654321");
        s.PrintDetail();
        s2.PrintDetail();
    }

    private static void Ask4Staff(Staff b)
    {
        Console.WriteLine("Enter number of modules: ");
        string? _Num = Console.ReadLine();
        int _ModuleNum;
        try
        {
            _ModuleNum = int.Parse(_Num);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Got exception of {e.GetType()} with msg of {e.Message}");
            do
            {
                Console.WriteLine("Enter Year: ");
                _Num = Console.ReadLine();
            } while (!int.TryParse(_Num, out _ModuleNum));
        }
        String[] _Modules = new string[_ModuleNum];
        for (int i = 0; i < _ModuleNum; i++)
        {
            Console.WriteLine($"Enter name of module {i + 1}: ");
            _Modules[i] = Console.ReadLine();
        }

        //Console.WriteLine(string.Join(",", _Modules));
        Console.WriteLine("now");
        _Modules.ToList().ForEach(Console.Write);
        b.AddModule(_Modules);
        int salary;
        foreach (string module in _Modules)
        {
            Console.WriteLine($"Enter salary for {module} module: ");
            try
            {
                salary = int.Parse(Console.ReadLine());
                b.CalculateSalary(salary);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Got exception of {e.GetType()} with msg of {e.Message}");
                do
                {
                    Console.WriteLine("Enter Year: ");
                    //CurrentYear = Console.ReadLine();
                } while (!int.TryParse(Console.ReadLine(), out salary));
            }
        }

        Console.WriteLine($"Modules = {b.getModuleList()}");
        Console.WriteLine("total salary is : " + b.TotalSalary);
    }

    private static void AskForMarks(Student a)
    {
        Console.WriteLine("Enter student current year: ");
        string? CurrentYear = Console.ReadLine();
        int year;

        try
        {
            year = int.Parse(CurrentYear);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Got exception of {e.GetType()} with msg of {e.Message}");
            do
            {
                Console.WriteLine("Enter Year: ");
                CurrentYear = Console.ReadLine();
            } while (!int.TryParse(CurrentYear, out year));
        }
        if (year == 1)
        {
            Console.WriteLine("==1st Year==");
            Console.WriteLine("Enter python marks: ");

            int pythonMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Information System marks: ");
            int isMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Java marks:");
            int javaMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Logic marks: ");
            int logicMarks = Convert.ToInt32(Console.ReadLine());

            a.SetYearMarks(new int[] { pythonMarks, isMarks, javaMarks, logicMarks });
        }
        a.HasPaid1YearFee = true;
        a.CheckAndPromptToNextYear();
    }
}