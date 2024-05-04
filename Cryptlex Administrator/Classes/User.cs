using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptlex_Administrator.Classes
{
    internal class User
    {
        public UserCredentials UserCredentials { get; set; }
    }
    internal class UserCredentials
    {
        public UserCredentials(string accountID, string email, string password)
        {
            AccountID = accountID;
            Email = email;
            Password = password;
        }

        public string AccountID { get; set; }
        public string AccountAlias { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TwoFactorCode { get; set; }
        public string TwoFactorRecoveryCode { get; set; }

        public UserCredentialModel ToJsonModel()
        {
            return new UserCredentialModel(AccountID, Email, Password);
        }

        internal class UserCredentialModel
        {
            public UserCredentialModel(string accID, string accEmail, string accPassword)//TODOD: expand credential model to include optional params
            {
                accountId = accID;
                email = accEmail;
                password = accPassword;
            }

            public string accountId { get; set; }
            public string accountAlias { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string twoFactorCode { get; set; }
            public string twoFactorRecoveryCode { get; set; }

        }

    }


}
