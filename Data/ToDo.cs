using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationToDo.Data
{
    public class ToDo
    {
        public Boolean Done { get; set; }

        [StringLength(255, MinimumLength = 5, ErrorMessage = "This needs to be longer.")]
        public string Name { get; set; }

        [Key]
        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}
