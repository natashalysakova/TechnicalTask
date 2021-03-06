﻿using System.ComponentModel.DataAnnotations;

namespace TechnicalTask.Models
{
    public class OrganizationCountry
    {
        [Key]
        public int Id { get; set; }

        public int OrganizationId { get; set; }
        public int CountryId { get; set; }

        public Organization Organization { get; set; }
        public Country Country { get; set; }
    }
}
