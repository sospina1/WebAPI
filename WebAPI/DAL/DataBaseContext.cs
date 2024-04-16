using Microsoft.EntityFrameworkCore;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL
{
    public class DataBaseContext : DbContext 
    {

        // Asi me conecto a la base de datos, por medio de este constructor 
        public  DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        { 
        
        }
        //Este metodo es propio de EF CORE, me sirve para configurar unos indices de cada campo de una tabla en BD 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); // Aqui creo un indice del campo Name
                                                                             // para la tabla Countries
        }

        #region Dbsets

        public DbSet<Country> Countries { get; set; }

        #endregion

    }
}

