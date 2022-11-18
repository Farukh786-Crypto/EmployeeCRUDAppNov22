using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.Models
{
    [Table("StateMst")]
    public class StateMst
    {
        [Key]
        public int stateId { get; set; }
        public string stateName { get; set; }

        // Navigation property

        public CountryMst CountryMst { get; set; }

        [ForeignKey("CountryMst")]
        public int countryId { get; set; }

    }
}
