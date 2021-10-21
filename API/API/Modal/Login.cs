using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Modal
{
    public class Login
    {
       
        [Column(TypeName = "nvarchar(100)")]
        public String username { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String password { get; set; }

    }
}
