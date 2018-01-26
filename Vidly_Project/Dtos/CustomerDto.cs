﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_Project.Models;

namespace Vidly_Project.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        public byte MembershipTypeId { get; set; }
        
        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}