using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities
{
    [Table("ConfigurationTable")]
    public class Config
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
