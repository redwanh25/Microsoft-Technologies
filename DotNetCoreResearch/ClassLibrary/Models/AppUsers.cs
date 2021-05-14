using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary.Models
{
    public class AppUsers : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public int UserRoleId { get; set; }

        [ForeignKey("UserRoleId")]
        public UserRole UserRoles { get; set; }

        public int OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organizations { get; set; }
    }
}
