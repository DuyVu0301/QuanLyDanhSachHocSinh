using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Tan", Age = 16 },
            new Student { Id = 2, Name = "Vu", Age = 14 },
            new Student { Id = 3, Name = "Khang", Age = 18 },
            new Student { Id = 4, Name = "An", Age = 17 },
            new Student { Id = 5, Name = "Vien", Age = 15 }
        };

        // a. In toàn bộ danh sách học sinh
        Console.WriteLine("Danh sach toan bo hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in ra danh sách học sinh có tuổi từ 15 đến 18
        var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        foreach (var student in studentsAge15To18)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        var studentsNameStartingWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
        Console.WriteLine("\nHoc sinh co ten bat day bang chu 'A':");
        foreach (var student in studentsNameStartingWithA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).First();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: " +
            $"{oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        var sortedStudents = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        Console.ReadKey();
    }
}
