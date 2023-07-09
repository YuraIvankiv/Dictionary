using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class EmployeeManager
    {
        private Dictionary<string, string> employees;

        public EmployeeManager()
        {
            employees = new Dictionary<string, string>();
        }
        public void AddEmployee(string login, string password)// додати логін і пароль співробітника
        {
            if (!employees.ContainsKey(login))
            {
                employees.Add(login, password);
                Console.WriteLine("Employee added successfully.");
            }
            else
            {
                Console.WriteLine("This login already exists, please choose another one");
            }
        }
        public void RemoveEmployee(string login)// видалити логін співробітника
        {
            if (employees.ContainsKey(login))
            {
                employees.Remove(login);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("No employee with this login was found.");
            }
        }
        public void UpdateEmployee(string login, string newPassword)//змінити інформацію про логін і пароль співробітника
        {
            if (employees.ContainsKey(login))
            {
                employees[login] = newPassword;
                Console.WriteLine("Employee information has been updated successfully.");
            }
            else
            {
                Console.WriteLine("No employee with this login was found.");
            }
        }
        public void GetPassword(string login)//Отримання пароля за логіном
        {
            if (employees.ContainsKey(login))
            {
                string password = employees[login];
                Console.WriteLine($"Password for an employee with a login'{login}': {password}");
            }
            else
            {
                Console.WriteLine("No employee with this login was found.");
            }
        }
    }
}
