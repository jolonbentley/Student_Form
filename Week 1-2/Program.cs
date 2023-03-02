using System;
using System.Collections.Generic;
using System.IO;

namespace Week_1_2
{
    class Program
    {
        
        static void Main(string[] args)
        { 

            List<Student> studentList = new List<Student>();
            int option;
            do
            {
                Console.WriteLine("==========Student Information==========");
                Console.WriteLine("1. Add Information");
                Console.WriteLine("2. Insert Information");
                Console.WriteLine("3. Update Information");
                Console.WriteLine("4. Delete Information");
                Console.WriteLine("5. Search Information");
                Console.WriteLine("6. Display Information");
                Console.WriteLine("7. Search Information by Index");
                Console.WriteLine("8. Write String to File");
                Console.WriteLine("9. Read String from File");
                Console.WriteLine("10. Exit");
                Console.WriteLine("Type the number of your selection, then press ENTER");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddInfo(studentList);
                        break;
                    case 2:
                        InsertInfo(studentList);
                        break;
                    case 3:
                        UpdateInfo(studentList);
                        break;
                    case 4:
                        DeleteInfo(studentList);
                        break;
                    case 5:
                        SearchInfo(studentList);
                        break;
                    case 6:
                        DisplayInfo(studentList);
                        break;
                    case 7:
                        SearchInfoIndex(studentList);
                        break;
                    case 8:
                        WriteFile();
                        break;
                    case 9:
                        ReadFile();
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (option != 10);
        }

        static void AddInfo(List<Student> studentList)
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number: ");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            studentList.Add(new Student { FirstName = firstName, LastName = lastName, Email = email, Id = id, MobileNumber = mobileNumber, Address = address });
            Console.WriteLine("\n***Information added successfully***\n");
        }

        static void InsertInfo(List<Student> studentList)
        {
            try
            {
                Console.WriteLine("Enter location to insert: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();
                studentList.Add(new Student { FirstName = firstName, LastName = lastName, Email = email, Id = id, MobileNumber = mobileNumber, Address = address });
                Console.WriteLine("\n***Information inserted successfully***\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void UpdateInfo(List<Student> studentList)
        {
            try
            {
                Console.WriteLine("Enter index to update: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select field to update:");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Email");
                Console.WriteLine("4. Student ID");
                Console.WriteLine("5. Mobile Number");
                Console.WriteLine("6. Address");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter First Name: ");
                        studentList[index].FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name: ");
                        studentList[index].LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter Email: ");
                        studentList[index].Email = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter Student ID: ");
                        studentList[index].Id = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Enter Mobile Number: ");
                        studentList[index].MobileNumber = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter Address: ");
                        studentList[index].Address = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid field selected.");
                        break;
                }
                Console.WriteLine("\n***Information updated successfully***\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void DeleteInfo(List<Student> studentList)
        {
            try
            {
                Console.WriteLine("Enter index to delete: ");
                int index = Convert.ToInt32(Console.ReadLine());
                studentList.RemoveAt(index);
                Console.WriteLine("\n***Information deleted successfully***\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        static void SearchInfo(List<Student> studentList)
        {
            Console.WriteLine("Enter first name to search (case sensitive): ");
            string firstName = Console.ReadLine();
            bool found = false;
            foreach (var student in studentList)
            {
                if (student.FirstName == firstName)
                {
                    Console.WriteLine("First Name: {0} Last Name: {1} Email: {2} ID: {3} Mobile Number: {4} Address: {5}", student.FirstName, student.LastName, student.Email, student.Id, student.MobileNumber, student.Address);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found");
            }
        }

        static void DisplayInfo(List<Student> studentList)
        {
            Console.WriteLine("\nStudents Information: ");
            foreach (var student in studentList)
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Email: {2} ID: {3} Mobile Number: {4} Address: {5}\n", student.FirstName, student.LastName, student.Email, student.Id, student.MobileNumber, student.Address);
            }
        }

        static void SearchInfoIndex(List<Student> studentList)
        {
            Console.WriteLine("Enter index to search: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < studentList.Count)
            {
                Student foundStudent = studentList[index];
                Console.WriteLine("First Name: " + foundStudent.FirstName);
                Console.WriteLine("Last Name: " + foundStudent.LastName);
                Console.WriteLine("Email: " + foundStudent.Email);
                Console.WriteLine("Student ID: " + foundStudent.Id);
                Console.WriteLine("Mobile Number: " + foundStudent.MobileNumber);
                Console.WriteLine("Address: " + foundStudent.Address);
            }
            else
            {
                Console.WriteLine("Index not found");
            }
        }

        static void WriteFile()
        {
            Console.WriteLine("Write your string:");
            string filePath = @"C:\Users\admin\Desktop\Techtorium Projects\PP - Term 1\Week 1 and 2 - Assignment\SR27\file.txt";
            string text = Console.ReadLine();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
                fileStream.Write(data, 0, data.Length);
                Console.WriteLine("Writing String to File was successful");
            }
        }

        static void ReadFile()
        {
            Console.WriteLine("Read String from File is:");
            string filePath = @"C:\Users\admin\Desktop\Techtorium Projects\PP - Term 1\Week 1 and 2 - Assignment\SR27\file.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fileStream.Length];
                int bytesRead = fileStream.Read(data, 0, data.Length);
                string text = System.Text.Encoding.UTF8.GetString(data, 0, bytesRead);
                Console.WriteLine(text);
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
