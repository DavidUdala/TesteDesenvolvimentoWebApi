using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace TesteDesenvolvimentoAPI.Models
{
    public class Tool
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string link { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string description { get; set; }


    }
}
