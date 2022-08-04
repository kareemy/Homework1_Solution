
using Homework1.Models;

// Create an empty list of doctors
List<Doctor> myDoctors = new List<Doctor>();

// Create our first doctor individually
Doctor doctor1 = new Doctor();
doctor1.FirstName = "Kareem";
doctor1.LastName = "Dana";
// Give the doctor some patients.
// This works the same way as assigning a value to any type of property, but the data type is now a list
// So we have to use an initializer list to setup the list with several patients.
doctor1.Patients = new List<Patient> {
    new Patient {FirstName = "Jeff", LastName = "Babb"},
    new Patient {FirstName = "Samantha", LastName = "Carter"}
};

// Add our doctor to the list of doctors
myDoctors.Add(doctor1);

// Add a 2nd and 3rd doctor to the list directly. This combines the two steps of creating the doctor and adding them to the list 
// into one step
myDoctors.Add(new Doctor {
    FirstName = "Amjad", 
    LastName = "Abdullat", 
    Patients = new List<Patient> {
        new Patient {FirstName = "Daniel", LastName = "Jackson"},
        new Patient {FirstName = "Jack", LastName = "O'Neill"},
        new Patient {FirstName = "George", LastName = "Bush"}
    }
});

myDoctors.Add(
    new Doctor
    {
        FirstName = "Sean",
        LastName = "Humpherys",
        Patients = new List<Patient> {
            new Patient {FirstName = "George", LastName = "Hammond"},
            new Patient {FirstName = "Elizabeth", LastName = "Weir"},
            new Patient {FirstName = "Ibrahim", LastName = "Lazrig"},
            new Patient {FirstName = "Yao", LastName = "Ming"}
        }
    }
);

// Task 6: Loop through each doctor with a foreach loop
foreach (Doctor d in myDoctors)
{
    // Print out the count of Patients using the .Count property of the List
    Console.WriteLine($"Dr. {d.FirstName} {d.LastName} has the following {d.Patients.Count} patients: ");
    // For each doctor, print out all their patients by looping through the patients list
    // The variable d represents one specific doctor, so d.Patients is the list of patients for that doctor
    foreach (Patient p in d.Patients)
    {
        Console.WriteLine($"\t{p.FirstName} {p.LastName}");
    }
}