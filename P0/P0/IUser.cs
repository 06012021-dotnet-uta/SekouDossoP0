namespace P0
{
    public interface IUser
    {
        User Register(string firstName, string lastName, string passWord);
        string DeleteAccount(string firstName, string lastName, string passWord);
    }
}