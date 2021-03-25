using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Home_Fitness.Models
{
    public class Item
    {
        [Key]
        public int EquipmentID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Customer Name")]
        public String CustomerName { get; set; }

        public String Code { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description Of Equipment")]
        public String DescriptionOfEquipment { get; set; }

        [Required(ErrorMessage = "Required")]
        public decimal Price { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime DateModified { get; set; }

        [Display(Name = "Equipment Type")]
        public String EquipmentType { get; set; }
    }
}
