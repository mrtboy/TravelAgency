using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }

        public Customer(int id ,string firstName, string lastName, string address, string phone, string dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = lastName;
            Phone = phone;
            DateOfBirth = dateOfBirth;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, First Name: {1}, Last Name: {2}, Address: {3}, Phone Number: {4}, Date of birth: {5}", 
                Id, FirstName, LastName, Address, Phone, DateOfBirth);
        }
    }
}
