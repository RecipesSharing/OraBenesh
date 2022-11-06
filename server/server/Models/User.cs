using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class User
    {
        public string userCode { get; set; }
        public string userName { get; set; }
        public string userAddress { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }

        public User(string userCode, string userName, string userAddress, string userEmail, string userPassword)
        {
            this.userCode = userCode;
            this.userName = userName;
            this.userAddress = userAddress;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
        }
        public User()
        {

        }
    }
}