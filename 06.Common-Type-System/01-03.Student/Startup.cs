namespace Student
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstStudent = new Student("Kiro", "Skalata", "Valchev", "123-45-6789", "Unknown address", "0888747474",
                "kiro-skalata@gmail.com", 4, Universities.MedicalUniversity, Faculties.DentalMedicineFaculty, Specialties.DentalMedicine);


            var secondStudent = new Student("Kiro", "Skalata", "Valchev", "987-65-4321", "Unknown address", "0886454545",
                "kiro-bicepsa@gmail.com", 4, Universities.SofiaUniversity, Faculties.FMI, Specialties.SoftwareEngineer);

            var thirdStudent = new Student("Dimitar", "Pishtova", "Marinov", "321-56-9784", "Unknown address", "0895636363",
                "pishova@abv.bg", 4, Universities.TechnicalUniversity, Faculties.TransportFaculty, Specialties.TransportEngineer);

            bool compareFirstAndSecond = firstStudent.Equals(secondStudent);
            bool compareFirstAndThird = firstStudent.Equals(thirdStudent);
            bool operatorsCompareFirstAndSecond = firstStudent == secondStudent;
            bool operatorsCompareFirstAndThird = firstStudent != thirdStudent;
            var hashCodeTest = firstStudent.GetHashCode();

            // test ToString();
            Console.WriteLine(firstStudent + "\n");
            Console.WriteLine(secondStudent + "\n");
            Console.WriteLine(thirdStudent + "\n");

            Console.WriteLine("Compare first and second with Equals: {0}", compareFirstAndSecond);
            Console.WriteLine("Compare first and third with Equals: {0}\n", compareFirstAndThird);

            Console.WriteLine("Compare first and second with == {0}", operatorsCompareFirstAndSecond);
            Console.WriteLine("Compare first and third with == {0}\n", operatorsCompareFirstAndThird);

            Console.WriteLine("Compare first and second with CompareTo: {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Compare first and third with CompareTo: {0}\n", firstStudent.CompareTo(thirdStudent));

            var cloned = thirdStudent.Clone() as Student;

            Console.WriteLine("Cloned == thirdStudent? {0}", cloned == thirdStudent);
            thirdStudent = secondStudent; 
            Console.WriteLine("Cloned == thirdStudent? after swapping? {0}", cloned == thirdStudent);
        }
    }
}