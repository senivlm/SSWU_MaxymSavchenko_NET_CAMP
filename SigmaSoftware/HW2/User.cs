namespace SigmaSoftware.HW2;

public class User
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Username { get; }

    public User(string username)
    {
        Username = username;
    }

    public override string ToString()
    {
        return Username;
    }
}