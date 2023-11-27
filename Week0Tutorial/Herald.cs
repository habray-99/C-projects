namespace Herald
{
    public class Student
    {
        public String? StudentName { get; set; }
        public int? Uid { get; set; }
        public int? Sem { get; set; }
    }

    public class Staff
    {
        //private String? _staffName { get; set; }

        public String? StaffName { get; set; }

        //private String? _Module { get; set; }
        private String? _Module;

        private String? _phoneNumber { get; set; }
    }

    public class Admin
    {
        private String? _adminName { get; set; }
        private String? _phoneNumber { get; set; }
    }
}