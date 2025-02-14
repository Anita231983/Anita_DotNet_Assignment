using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the LibraryManagementSystem2User class
public class LibraryManagementSystem2User : IdentityUser
{
    public class OnlineVotingSystemUser : IdentityUser
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
      public int id { get; set; }
        public string ProfileImage { get; set; }

    }
}

