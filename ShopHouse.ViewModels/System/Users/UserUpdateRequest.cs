using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopHouse.ViewModels.System.Users
{
    public class UserUpdateRequest
    {
        public Guid ID { get; set; }
        [Display(Name = "Tên")]
        public string FirstName { get; set; }
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string PhoneNumber { get; set; }
    }
}
