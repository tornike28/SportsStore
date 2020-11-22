using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class CheckOutViewModel
    {
        [Required(AllowEmptyStrings =false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string SecondName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Phone Number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{10})", ErrorMessage = "*Not a valid number, must be 10 numbers")]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false)]
        public String Note { get; set; }
    }
}
