using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.DTO
{
    public class BranchAccountDTO
    {
        public int AccountID { get; set; }
        public string AccountPassword { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public int Role { get; set; }
    }
}
