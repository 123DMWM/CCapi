using System;
using System.Collections.Generic;

namespace CCapi {
    
    public static class Constants {
        
        public static DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
        public const string NotFound = "User not found";
        
        public static Dictionary<char, string> UserFlags
            = new Dictionary<char, string>() {
            { 'a', "Forum administrator" },
            { 'm', "Forum moderator" },
            { 'd', "ClassiCube developer" },
            { 'e', "ClassiCube blog editor" },
            { 'r', "Recovering account" },
            { 'b', "Banned" },
            { 'u', "Unverified" },
            { 'p', "ClassiCube Patron" },
        };
    }
}
