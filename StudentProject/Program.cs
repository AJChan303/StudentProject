using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {
            Student brailee = new Student();
            brailee.SetStatus("CURRENT");
            Console.WriteLine($"Brailee status is {brailee.Status}");
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student("Jesse", "Kyle"); // added firstname lastname from the constructor we made
            jesse.SetStatus("past");
            Console.WriteLine($"Jess: {jesse.FirstName} {jesse.LastName}");
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
            titus.SetCreditScore(900);
            Console.WriteLine($"Titus' Credit score is {titus.CreditScore}");


            



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
        public int CreditScore { get; private set; }

        public void  SetCreditScore(int score) {
            if (score >= 400
                && score <= 900) {
                this.CreditScore = score;
            }
            else {
                Console.WriteLine("Credit score must be between 400 and 900");
            }
        }
        public void SetStatus(string status) {
            if ((status == "CURRENT") 
                || (status == "PAST") 
                || (status == "FUTURE")) {
                this.Status = status;
            }else {
                Console.WriteLine("Status must be CURRENT PAST OR FUTURE");
            }
        }
        public Student(string FirstName, string LastName) {
            this.FirstName = FirstName;//this - points to this instance you are creating
            this.LastName = LastName;
        }
        public Student(){// Default constructor
           
        }
    }
}
