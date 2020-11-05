using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Lists
{
    [Serializable]
    class Employee
    {
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberOfHouse { get; set; }

        public Employee(string name, decimal sal, string pos, string city, string st, int num)
        {
            FullName = name;
            Salary = sal;
            Position = pos;
            City = city;
            Street = st;
            NumberOfHouse = num;
        }

        public override string ToString()
        {
            return $"{FullName} - {Position}\n";
        }

    }

}
