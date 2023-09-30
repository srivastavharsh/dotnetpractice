﻿namespace website.Models
{
    public class Schooldata
    {
        public class Students
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Stream { get; set; }
            public string? teacher { get; set; }
            
        }

        public class StudentInfos
        {
            public int Id { get; set; }
            public int StdId { get; set; }
            public string? FatherName { get; set; }
            public string? Address { get; set; }
        }

        public class StudentViewModels {
         public Student? studentVm { get; set; }
         public StudentInfo? studentInfoVm { get; set; }
        }

    }
}
