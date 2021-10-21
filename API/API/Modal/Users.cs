using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Modal
{
    public class Users
    {

        [Key]
        public int UserId { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string UserName{ get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string City { get; set; }

        public int Phone { get; set; }

        public int Pincode  { get; set; }
    }
}
