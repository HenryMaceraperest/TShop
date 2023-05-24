using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TShop.Models
{
    public class ProductModel
    {
        private int id;
        private string name;
        private string type;
        private string quantity;
        private bool ageLimit;
        private long barcode;
        private decimal cost;

        [DisplayName("Product ID")]
        public int Id 
        {
            get => id;
            set => id = value; 
        }

        [DisplayName("Product Name")]
        [Required(ErrorMessage ="Product name is required!")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Product name cannot be shorter than 3 and longer than 50 characters!")]
        public string Name 
        {
            get => name; 
            set => name = value;
        }

        [DisplayName("Product Type")]
        [Required(ErrorMessage = "Product type is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product type must be valid and between 3-50 characters!")]
        public string Type 
        {
            get => type; 
            set => type = value;
        }

        [DisplayName("Product Quantity")]
        [Required(ErrorMessage = "Product quantity is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product quantity must be valid and between 3-50 characters!")]
        public string Quantity 
        {
            get => quantity; 
            set => quantity = value;
        }

        [DisplayName("Product Age Limit")]
        [Required(ErrorMessage = "You need to set if the product has an age limit!")]
        public bool AgeLimit 
        {
            get => ageLimit; 
            set => ageLimit = value;
        }

        [DisplayName("Product Barcode")]
        [Required(ErrorMessage = "Product type is required!")]
        public long Barcode 
        {
            get => barcode; 
            set => barcode = value;
        }

        [DisplayName("Product Cost")]
        [Required(ErrorMessage = "Product type is required!")]
        public decimal Cost 
        {
            get => cost; 
            set => cost = value; 
        }
    }
}

//Product_id int IDENTITY(100000,1) primary key,
//Product_name nvarchar(50) not null,
//Product_type nvarchar(50) not null,
//Product_quantity nvarchar(50) not null,
//Product_ageLimit bit not null,
//Product_barcode bigint not null,
//Product_cost money not null