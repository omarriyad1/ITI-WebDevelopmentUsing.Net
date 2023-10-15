using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp2.Models
{
    public class Track
    {
        public Track() 
        { 
            Students = new List<Student>();
        }
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id {  get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public virtual List<Student> Students { get; set;}
    }
}
