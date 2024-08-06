using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }


    }
}
