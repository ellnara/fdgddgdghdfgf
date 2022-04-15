using System;
using System.Collections.Generic;
using System.Text;
using StudentApp.Enum;

namespace StudentApp
{
    class Student
    {
        public List<string> AllStudents;
        public string FullName { get; set; }
        public Group GroupNo { get; set; }
        public bool Type { get; set; }
        public Student()
        {

        }
        public Student(string fullname, Group groupno, bool type)
        {
            GroupNo = groupno;
            Type = type;
            FullName = fullname;
            AllStudents.Add(fullname);
        }
        public override string ToString()
        {
            var result = Type ? "zemanetli" : "zemanetsiz";
            return $"Full Name: {FullName}  Group No :{GroupNo} Type: {result}";
        }
    }
}
