namespace cw2;

public class UsersRepo
{
    public List<User> Users { get; set; }
    public UsersRepo()
    {
        Users = getUsersFromFile("dane.txt");
    }
    private List<User> getUsersFromFile(string path)
    {
        var users = new List<User>();
        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            var data = line.Split(';');
            users.Add(new User
            {
                Id = Convert.ToInt32(data[0]),
                Firstname = data[1],
                Lastname = data[2],
                Age = Convert.ToInt32(data[3])
            });
        }
        return users;
    }
}
