using System;
using System.Collections.Generic; // Required for List<>
using Homework1.Models; // Required to bring in the Patient class

// Task 3: Model of Doctor
namespace Homework1.Models
{
    class Doctor 
    {
        // First and Last name properties
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        // List of Patients as a property. Each doctor can now have several patients associated with them.
        // This is an example of a relationship. A doctor has a connection to patients through this property.
        public List<Patient> Patients {get; set;} = new List<Patient>();
    }
}