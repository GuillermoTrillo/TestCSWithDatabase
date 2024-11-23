using TestCSWithDatabase.Models;

namespace TestCSWithDatabase.Services
{
    public class SecurityService
    {
        UserDAO userDAO = new UserDAO();

        public bool isValid(User user) 
        {
            return userDAO.FindUserByPassword(user);
        }
    }
}
