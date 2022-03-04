using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peresdachi.Models
{
    class ModelUsers
    {
        [Key]

        public int id { get; set; }
        public string role { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string GroupStd { get; set; }
    }
}
