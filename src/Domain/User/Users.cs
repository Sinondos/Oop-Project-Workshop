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
    public Admin(string name, int age, string cpr)
        : base(name, age, cpr)
}

class Borrower : Person
{
    private string[] listOfBorrowedMediaAllTime;
    private string[] listOfBorrowedMediaNow;
    Borrow();
    public Borrower(string name, int age, string cpr)
        : base(name, age, cpr)
}

class Employee : Person
{
    AddMedia();
    RemoveMedia();
    public Employee(string name, int age, string cpr)
        : base(name, age, cpr)
}