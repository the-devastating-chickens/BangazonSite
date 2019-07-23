using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bangazon.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Listed On")]

        public DateTime DateCreated { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Please shorten the product title to 255 characters")]
        // Billy Mitchell: This Regular Expression is used to forbid users from usings these !@#$%^&*() characters. Use allow: [characters in here] or not allow [^characters in here]
        [RegularExpression(@"^[^!@#$%^&*()]+$", ErrorMessage = "The characters !@#$%^&*() are not allowed")]
        public string Description { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the product title to 55 characters")]
        // Billy Mitchell: This Regular Expression is used to forbid users from usings these !@#$%^&*() characters. Use allow: [characters in here] or not allow [^characters in here]
        [RegularExpression(@"^[^!@#$%^&*()]+$", ErrorMessage = "The characters !@#$%^&*() are not allowed")]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        //Billy Mitchell: This Data Annotation forbids the user from entering a price higher then 10,000
        [Range(0.0, 10000.0, ErrorMessage = "Price cannot exceed $10,000")]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string UserId { get; set; }

        public string City { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        public bool Active { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public int? ProductTypeId { get; set; }
        [Display(Name = "Product Category")]

        public ProductType ProductType { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product()
        {
            Active = true;
        }

        [NotMapped]
        public int QuantityRemaining
        {
            get
            {
                if(OrderProducts != null)
                {
                    return Quantity - OrderProducts.Count;
                }
                else
                {
                    return Quantity;
                }
            }
        }

    }
}
