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
    
    public partial class Tarea
    {
        public int idTarea { get; set; }
        public string tarea1 { get; set; }
        public bool status { get; set; }
        public int idGrupo { get; set; }
    
        public virtual Grupo Grupo { get; set; }
    }
}