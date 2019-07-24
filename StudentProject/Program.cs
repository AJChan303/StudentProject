using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student();
            jesse.FirstName = "Jess";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.IsPaid = true;
            alex.Birthdate = new DateTime(1991, 04, 03);
            alex.LastName = "Chan";
            alex.Phone = "5135605531";
            alex.State = "OH";
            alex.City = "Cincinnati";

            Student titus = new Student();
            titus.FirstName = "Titus";
            titus.IsPaid = true;
            titus.Birthdate = new DateTime(2000, 01, 01);

            string name = jesse.FirstName



        }
    }
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string BootCamp { get; set; }
        public string Status { get; set; } //current, future, Past
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }
    }
}
