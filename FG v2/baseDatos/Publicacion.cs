//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baseDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publicacion
    {
        public Publicacion()
        {
            this.Archivoes = new HashSet<Archivo>();
        }
    
        public int idPublicacion { get; set; }
        public string publicacion1 { get; set; }
        public int idGrupo { get; set; }
        public int idUsuario { get; set; }
    
        public virtual ICollection<Archivo> Archivoes { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}