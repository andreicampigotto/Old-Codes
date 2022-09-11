//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFisrtListGuy.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livro()
        {
            this.Locacaos = new HashSet<Locacao>();
            this.Autores = new HashSet<Autore>();
        }
    
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public int Genero { get; set; }
        public int Editora { get; set; }
        public string Sinopse { get; set; }
        public string Observacoes { get; set; }
        public bool Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public System.DateTime DatInc { get; set; }
        public System.DateTime DatAlt { get; set; }
    
        public virtual Editora Editora1 { get; set; }
        public virtual Genero Genero1 { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacao> Locacaos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autore> Autores { get; set; }
    }
}