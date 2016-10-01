using System;

public class EmployeeData
{
    static void Main(string[] args)
    {

        //First name
        //Last name
        //Age(0...100)
        //Gender(m or f)
        //Personal ID number(e.g. 8306112507)
        //Unique employee number(27560000…27569999)

        string firstName = "Ivaylo";
        string lastName = "Kostov";
        byte age = 30;
        string gender = "male";
        ulong personalID = 8306112507u;
        uint employeeNum = 27569999u;
        string newLine = Environment.NewLine;

        Console.WriteLine("Name: {0} {1}{6}Age: {2}{6}Gender: {3}{6}ID: {4}{6}Unique: {5}", firstName, lastName, age, gender, personalID, employeeNum, newLine);
    }
}