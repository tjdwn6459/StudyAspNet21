using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewPortpolio.Models
{
    public class Account
    {
            [Key]
            public int Id { get; set; }
            public String Name { get; set; }


            [Required(ErrorMessage = "이메일은 필수입니다.")]
            [DataType(DataType.EmailAddress)]
            [StringLength(125)]
            public String Email { get; set; }

            [Required(ErrorMessage = "패스워드는 필수입니다.")]
            [DataType(DataType.Text)]
            [StringLength(50)]
            public String Password { get; set; }
            public String Grade { get; set; }
        
    }
}
