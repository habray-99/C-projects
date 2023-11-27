namespace ICP
{
    public class Student
    {
        private String? StudentName;

        public void SetStudentName(string _name)
        {
            this.StudentName = _name;
        }

        public string? getStudentName()
        {
            return StudentName;
        }

        public int? Uid { get; set; }
        public int? Sem { get; set; }

        public bool HasPassed1Year, HasPassed2Year, HasPassed3Year = false;
        public bool HasPaid1YearFee, HasPaid2YearFee, HasPaid3YearFee = false;
        private int CurrentYear = 1;

        public void PrintString()
        {
            Console.WriteLine("this is normal \\ and \"");
            Console.WriteLine(@"this is verbrated string "" \\  ");
            Console.WriteLine($"this is interpolation {Sem}");
            Console.WriteLine("is concatenated: " + "now ");
        }

        public String[] Students = new string[5];  // pre-allocation of fixed size
        public String[] FixedArr = { "honda", "kawasaki" };
        public List<string> StudentsList = new List<string>();

        private int[] FirstYearMarks, SecondYearMarks, ThirdYearMarks = new int[4];

        private List<String> SubjectsOf1stYear = new List<String> { };

        public Student(bool hasPassed1Year)
        {
            HasPassed1Year = hasPassed1Year;
        }

        public Student()
        {
            //throw new NotImplementedException();
            
        }

        public void SetYearMarks(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                FirstYearMarks[i] = marks[i];
            }
        }

        private bool CheckIfYearPassed(int year)
        {
            Console.WriteLine("Checking if student has passed...");
            if (year == 1)
            {
                foreach (var mark in FirstYearMarks)
                {
                    if (mark < 40)
                    {
                        return false;
                    }
                }
                return true;
            }
            if (year == 2)
            {
                foreach (var mark in FirstYearMarks)
                {
                    if (mark < 40)
                    {
                        return false;
                    }
                }
                return true;
            }
            if (year == 3)
            {
                foreach (var mark in FirstYearMarks)
                {
                    if (mark < 40)
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        public void CheckAndPromptToNextYear()
        {
            if (CurrentYear == 1)
            {
                if (HasPaid1YearFee && CheckIfYearPassed(1))
                {
                    CurrentYear++;
                    Console.WriteLine($"Student has been Promoted to year {CurrentYear}");
                }
            }
            if (CurrentYear == 2)
            {
                if (HasPaid2YearFee && CheckIfYearPassed(2))
                {
                    CurrentYear++;
                    Console.WriteLine($"Student has been Promoted to year {CurrentYear}");
                }
            }
            if (CurrentYear == 3)
            {
                if (HasPaid3YearFee && CheckIfYearPassed(3))
                {
                    CurrentYear++;
                    Console.WriteLine($"Student has been Promoted to year {CurrentYear}");
                }
            }

            Console.WriteLine("Student couldn't be promoted to next year.");
        }

        public void SetMyDetail(string name, int uid, int sem)
        {
            StudentName = name;
            Uid = uid;
            Sem = sem;
        }
    }

    public class Staff
    {
        private String? _staffName { get; set; }
        private String? _Module { get; set; }
        private String? _phoneNumber { get; set; }

        public int NoOfModules { get; set; }
        private List<String> modulesList = new List<String>();

        public List<String> getModuleList()
        {
            return this.modulesList;
        }

        public void AddModule(string[] _modulesList)
        {
            //Console.WriteLine(_modulesList.ToString());
            Console.WriteLine(string.Join(",", _modulesList));
            /*foreach (var _M in _modulesList)
            {
                modulesList.Add((_M));
            }*/
            this.modulesList = _modulesList.ToList();
        }

        public int TotalSalary { get; set; }

        public void CalculateSalary(int _Sum)
        {
            TotalSalary += _Sum;
        }

        public void
            PrintSubjectDetails(string sub)
        {
            if (!modulesList.Contains(sub))
            {
                throw new Exception("I don't teach this subject");          //NotImplementedException;
            }
            else
            {
                int index = modulesList.IndexOf(sub);
                Console.WriteLine($"The subject is {sub}");
            }
        }

        public void SetMyDetails(string Name, string honeNumber)
        {
            _staffName = Name;
            _phoneNumber = honeNumber;
        }

        public void PrintDetail()
        {
            Console.WriteLine($"My name is {_staffName}");
            Console.WriteLine($"i teach {_Module}");
            Console.WriteLine($"My number is {_phoneNumber}");
        }
    }

    public class Admin
    {
        private String? _adminName { get; set; }
        private String? _phoneNumber { get; set; }
    }
}