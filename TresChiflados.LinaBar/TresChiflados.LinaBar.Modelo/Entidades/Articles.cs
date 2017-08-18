using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TresChiflados.LinaBar.Modelo.Entidades
{
    [Table("Articulos")]
    public class Articles
    {
        [Key] /* Campo llave de la tabla */
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] /* Campo autonumerico generado de la tabla*/
        public Guid Id { get; set; }
        [Column("CodigoArticulo", TypeName = "varchar")]
        [StringLength(10)]
        public string AticleCode { get; set; }
        [Column("PluArticulo", TypeName = "varchar")]
        [StringLength(10)]
        public byte ArticlePlu { get; set; }
        [Column("NombreArticulo", TypeName = "varchar")]
        [StringLength(70)]
        public string ArticleName { get; set; }
        [Column("IvaAsociado", TypeName = "tiyint")]
        public byte Associatedtax { get; set; }
        [Column("ListaPrecio", TypeName = "int")]
        public Guid PriceList { get; set; }
        [Column("CostoArticulo", TypeName = "int")]
        public string Cost { get; set; }
    }
}
