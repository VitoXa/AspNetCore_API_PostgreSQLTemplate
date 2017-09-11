using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_API_PostgreSQLTemplate.Models
{
    public class Document
    {
        [Key]
        public long Id { get; set; }

        public string DocumentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        
        [JsonIgnore]
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public int PersonId { get; set; }

    }
}

