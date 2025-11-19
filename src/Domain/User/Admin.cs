class Admin : User
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