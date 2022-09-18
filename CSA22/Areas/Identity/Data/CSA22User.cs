using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CSA22.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CSA22User class
public class CSA22User : IdentityUser
{
    public string FirstName { get; set; }
    public String LastName { get; set; }
}

