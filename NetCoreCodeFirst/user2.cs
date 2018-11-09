using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCodeFirst
{
    public class User2
    {
        public int Id { get; set; }
        [MaxLength(32),Required]
        public string Account { get; set; }
       [MaxLength(32),Required]
        public string Password { get; set; }
    }
}
