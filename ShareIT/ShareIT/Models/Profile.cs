﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShareIT.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
     
        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(30, ErrorMessage = "Numele nu poate avea mai mult de 30 de caractere")]
        public string ProfileName { get; set; }

        [Required(ErrorMessage = "Descrierea profilului este obligatorie")]
        [DataType(DataType.MultilineText)]
        public string ProfileDescription { get; set; }
        [Required]
        public DateTime SignUpDate { get; set; }
        public bool PrivateProfile { get; set; }
        //public int user_id
        public virtual ICollection<Post> Posts { get; set; }
    }
}