using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Repository.Data.Entity
{
    public class BranchAccount
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [MaxLength(40)]
        public string AccountPassword { get; set; }

        [Required]
        [MaxLength(60)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(60)]
        public string EmailAddress { get; set; }

        public int Role { get; set; }
    }
}

