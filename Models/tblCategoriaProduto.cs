//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace simpress_challenge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblCategoriaProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCategoriaProduto()
        {
            this.tblProduto = new HashSet<tblProduto>();
        }
    
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduto> tblProduto { get; set; }
    }
}
