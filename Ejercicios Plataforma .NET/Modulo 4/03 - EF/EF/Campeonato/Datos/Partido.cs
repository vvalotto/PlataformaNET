//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Campeonato.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partido
    {
        public int Id { get; set; }
        public string GolesLocaL { get; set; }
        public string IdEquipoVisitante { get; set; }
        public string GolesVistante { get; set; }
        public int EquipoLocalId { get; set; }
        public int EquipoVisitanteId { get; set; }
    
        public virtual Equipo EquipoL { get; set; }
        public virtual Equipo EquipoV { get; set; }
    }
}
