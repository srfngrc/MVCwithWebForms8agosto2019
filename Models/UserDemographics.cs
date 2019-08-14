using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//THIS IS THE MODEL, THAT I CREATED IN FIRST HAND

namespace MVCwithWebForms8agosto2019.Models
{
    public class UserDemographics
    {
        public UserDemographics()
        {
            Hobbies = new List<Hobby>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateMovedIntoArea { get; set; }
        public bool OwnHome { get; set; }
        public int TotalPeopleInHome { get; set; }
        public virtual List<Hobby> Hobbies { get; set; }

    }
}