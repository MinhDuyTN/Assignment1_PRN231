using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Data.Entity
{
    public class SilverJewelry
    {
        [Key]
        [MaxLength(200)]
        public string SilverJewelryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SilverJewelryName { get; set; }

        [MaxLength(250)]
        public string SilverJewelryDescription { get; set; }

        public decimal MetalWeight { get; set; }

        public decimal Price { get; set; }

        public int ProductionYear { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [MaxLength(30)]
        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}

