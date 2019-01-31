using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax_Form_Post_MVC.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Gets or sets PersonId.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        public string City { get; set; }
    }
}