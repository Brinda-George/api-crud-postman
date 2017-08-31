using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIExample.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }
        public Student() { } 
        public Student(int ID, string Name, double Marks)
        {
            this.ID = ID;
            this.Name = Name;
            this.Marks = Marks;
        }
    }
}