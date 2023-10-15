using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class ITIDBContext :DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENG-OMAR\\OMAR;Database=ITICodefirst;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=True") ;
        }




    }
}
