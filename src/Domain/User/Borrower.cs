
class Borrower : User
{
    private string[] listOfBorrowedMediaAllTime;
    private string[] listOfBorrowedMediaNow;
    Borrow();
    public Borrower(string name, int age, string cpr)
        : base(name, age, cpr)
}
