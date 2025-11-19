abstract class Person
{
    string name;
    int age;
    string cpr;
    public Person(string name, int age, string cpr)
    {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

}
class Admin : Person
{
    AddEmployee();
    RemoveEmployee();
    AddBorrower();
    RemoveBorrower();
    AddMedia();
    RemoveMedia();
}

class Borrower : Person
{
    private string[] listOfBorrowedMediaAllTime;
    private string[] listOfBorrowedMediaNow;
    Borrow();
}

class Employee : Person
{
    AddMedia();
    RemoveMedia();
}