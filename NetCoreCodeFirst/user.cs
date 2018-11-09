using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCodeFirst
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(32),Required]
        public string Account { get; set; }
       [MaxLength(32),Required]
        public string Password { get; set; }
    }
}
