using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Migrations_EF.Models;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Migrations_EF.DTOs
{
    public class CustomerDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public int MembershipTypesId { get; set; }

      //  [Min18]
        public DateTime? birthD { get; set; }
    }
}