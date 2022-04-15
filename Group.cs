using System;
using System.Collections.Generic;
using System.Text;
using StudentApp.Enum;

namespace StudentApp
{
    class Group
    {

        public string No { get; set; }
        public bool IsOnline { get; set; }
        private int _limit { get; set; }
        public List<Student> List;
        public List<Group> Grup;
        public Categories Category;
        public static int Bp = 100;
        public static int Dp = 100;
        public static int Sl = 100;
        public Group()
        {

        }
        public Group(Categories category, bool isOnline)
        {
            IsOnline = isOnline;
            switch (category)
            {
                case Categories.Programming:
                    No = $"Bp{Bp}";
                    Bp++;
                    break;
                case Categories.Design:
                    No = $"Dp{Dp}";
                    Dp++;
                    break;
                case Categories.SystemAdministration:
                    No = $"Sl{Sl}";
                    Sl++;
                    break;
                default:
                    Console.WriteLine("not a category");
                    break;
            }
            Category = category;
        }
        public void AddStudent(Student student)
        {
            if (IsOnline == true)
            {
                _limit = 15;

            }
            else
            {
                _limit = 10;
            }
            if (List.Count < _limit)
            {
                List.Add(student);
            }
            else
            {
                Console.WriteLine("qrup doludur");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Qrup: {No} IsOnline: {IsOnline} Telebelerin sayi: {List.Count}");
        }
        public void ShowStudents()
        {
            foreach (var item in List)
            {
                Console.WriteLine($"Telebe adi: {item.FullName} Tip: {item.Type}");
            }
        }
        public void ShowGroupStudents(string no)
        {
            foreach (var item in Grup)
            {
                if (item.No == no)
                {
                    ShowInfo();
                }
            }
        }
        public void ShowAllGroups()
        {
            foreach (var item in Grup)
            {
                Console.WriteLine($"Qrup No: {item.No} IsOnline: {IsOnline} Telebelerin sayi: {Grup.Count}");
            }
        }
    }
}
