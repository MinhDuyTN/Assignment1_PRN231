using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository.Data.Entity
{
    public class Category
    {
        [Key]
        [MaxLength(30)]
        public string CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CategoryDescription { get; set; }

        [MaxLength(160)]
        public string FromCountry { get; set; }
    }
}

