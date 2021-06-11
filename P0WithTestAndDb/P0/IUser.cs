namespace P0
{
    public interface IUser
    {
        User Register();
        string DeleteAccount(string firstName, string lastName, string passWord);
    }
}