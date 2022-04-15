using System;
using System.Collections.Generic;
using StudentApp.Enum;
namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> Groups = new List<Group>();
            List<Student> Group = new List<Student>();
            while (true)
            {
                Console.WriteLine($"                                                      MENU: \n1. Yeni Qrup Yarat " +
                    $"\n2. Gruplarin Siyahisini Goster " +
                    $"\n3. Grup uzerinde duzelis etmek " +
                    $"\n4. Qrupdaki telebelerin siyahisini goster " +
                    $"\n5. Butun telebelerin siyahisi " +
                    $"\n6. Telebe yarat");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("                                           Qrup melumatlarini daxil edin:");
                        Console.WriteLine($"Qrup categorisini secin: \n\n1.Programming\n2.Design\n3.System Administration");
                        int input2 = int.Parse(Console.ReadLine());
                        Categories category = new Categories();
                        switch (input2)
                        {
                            case 1:
                                category = Categories.Programming;
                                break;
                            case 2:
                                category = Categories.Design;
                                break;
                            case 3:
                                category = Categories.SystemAdministration;
                                break;
                            default:
                                Console.WriteLine("duzgun sec oc");
                                break;
                        }
                        Console.WriteLine("\nIs online:");
                        bool isonline = bool.Parse(Console.ReadLine());
                        Group group = new Group(category, isonline);
                        Groups.Add(group);
                        break;
                    case 2:
                        foreach (var item in Groups)
                        {
                            Console.WriteLine($"Qrup: {item.No} IsOnline: {item.IsOnline} Telebelerin sayi: {Groups.Count}");
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        Group grup = new Group();
                        Console.WriteLine("Qrup nomresini daxil edin:");
                        string no = Console.ReadLine();
                        grup.ShowGroupStudents(no);
                        break;
                    case 5:
                        Student students = new Student();
                        students.ToString();
                        break;
                    case 6:
                        Console.WriteLine("Telebe adini daxil edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Qrup nomresini daxil edin: ");
                        string No = Console.ReadLine();
                        //Group qrupp = new Group();
                        // qrupp.No = No;
                        foreach (var item in Groups)
                        {
                            if (item.No==No)
                            {
                                Student student = new Student(name, qrupp, isOnline);
                            }
                            
                        }
                        Console.WriteLine("Student typeini daxil edin: ");
                        bool isOnline = bool.Parse(Console.ReadLine());
                        
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
