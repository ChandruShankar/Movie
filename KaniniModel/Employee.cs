using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApi.KaniniModel
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empsalary { get; set; }
        public DateTime? DataofJioin { get; set; }
    }
}
