namespace TestCSWithDatabase.Models
{
    public class User
    {
        int id;
        string name;
        string password;

        public string getName()
        {
            return name; 
        }
        public void setName(string newName)
        {
            name = newName;
        }
    }
}
