using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.Web.Models
{

    [Table("product")]
    public class Product: BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]  
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1, 100000)]
        public decimal price { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Descripition { get; set; }

        [Column("category_name")]       
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string Image_URl { get; set; }

    }
}
