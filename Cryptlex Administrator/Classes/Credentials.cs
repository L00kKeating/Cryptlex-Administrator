using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Security.Principal;

namespace Cryptlex_Administrator
{
    public class Credentials
    {
        public Credentials(string accountID, string email, string password)
        {
            AccountID = accountID;
            Email = email;
            Password = password;
        }

        public string AccountID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}