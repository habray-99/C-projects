// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

class Student
{
    public String FullName { get; set; }
    public int Uid { get; set; }
    public String Sem { get; set; }
    public String PhoneNo { get; set; }

    public void SetData(string fullName, int uid, string sem, string phoneNo)
    {
        this.FullName = fullName;
        this.Uid = uid;
        this.Sem = sem;
        this.PhoneNo = phoneNo;
    }
    public void printInfo()
    {
        Console.WriteLine("Student Record: ");
        Console.WriteLine("\tName     : " + FullName);
        Console.WriteLine("\tUId   : " + Uid);
        Console.WriteLine("\tAge      : " + Sem);
        Console.WriteLine("\tPhone Number: " + PhoneNo);
        Console.WriteLine("\n\n");
    }
}

class Staff
{
    public String StaffName { get; set; }
    public int SId { get; set; }
    public String JoinYear { get; set; }
    public String Module { get; set; }

    public Staff(string staffName, int sId, string joinYear, string module)
    {
        this.StaffName = staffName;
        this.SId = sId;
        this.JoinYear = joinYear;
        this.Module = module;
    }
    public void PrintStaffInfo()
    {
        Console.WriteLine("-----------------Staff Record: ");
        Console.WriteLine("\tName     : " + StaffName);
        Console.WriteLine("\tSId   : " + SId);
        Console.WriteLine("\tyear      : " + JoinYear);
        Console.WriteLine("\tModule: " + Module);
        Console.WriteLine("\n\n");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[10];
        students[0] = new Student();
        students[1] = new Student();
        students[2] = new Student();
        students[3] = new Student();
        students[4] = new Student();
        students[5] = new Student();
        students[6] = new Student();
        students[7] = new Student();
        students[8] = new Student();
        students[9] = new Student();

        students[0].SetData("1",1,"1","1");
        students[1].SetData("2",2,"2","2");
        students[2].SetData("3",3,"3","3");
        students[3].SetData("4",4,"4","4");
        students[4].SetData("5",5,"5","5");
        students[5].SetData("6",6,"6","6");
        students[6].SetData("7",7,"7","7");
        students[7].SetData("8",7,"8","8");
        students[8].SetData("9",8,"9","9");
        students[9].SetData("10",9,"10","10");

        foreach (var i in students)
        {
            i.printInfo();
        }

        Console.WriteLine("\n\n--------------- STAFF DATAS: ---------------");
        List<Staff> staffs = new List<Staff>();
        for (int i = 0; i < 10; i++)
        {
            staffs.Add(new Staff($"Staff {i}", i, $"20{i}",$"1000{i}"));
        }
        foreach (var i in staffs)
        {
            i.PrintStaffInfo();
        }
    }
}