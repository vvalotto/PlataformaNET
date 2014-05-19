using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using IronMan.Dominio.Modelos;

namespace IronMan.Dominio.AccesoDatos.Mapeos
{
    public class PruebaMap : EntityTypeConfiguration<Prueba>
    {
        public PruebaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Tipo)
                .IsRequired();

            this.Property(t => t.Distancia)
                .IsRequired();
            this.Property(t => t.EstaHabilitado)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Pruebas");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tipo).HasColumnName("Tipo").HasMaxLength(50);
            this.Property(t => t.Distancia).HasColumnName("Distancia");
            this.Property(t => t.EstaHabilitado).HasColumnName("Habilitado");

            this.Property(t => t.Evento_Id).HasColumnName("Evento_Id");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.Pruebas)
                .HasForeignKey(d => d.Evento_Id);

        }
    }
}
