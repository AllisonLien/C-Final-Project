using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static void SetUser(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Role = null;
        }
    }
}