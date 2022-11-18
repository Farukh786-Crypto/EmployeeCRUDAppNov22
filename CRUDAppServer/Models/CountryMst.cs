using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.Models
{
    [Table("CountryMst")]
    public class CountryMst
    {
        [Key]
        public int countryId { get; set; }
        public string countryName { get; set; }

    }
}
