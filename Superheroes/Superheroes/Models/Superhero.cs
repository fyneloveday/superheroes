using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Alter Ego")]
        public string AlterEgo { get; set; }

        [Display(Name = "Primary Ability")]
        public string PrimaryAbility { get; set; }

        [Display(Name = "Secondary Ability")]
        public string SecondaryAbility { get; set; }

        [Display(Name = "Catchphrase")]
        public string Catchphrase { get; set; }


    }

}