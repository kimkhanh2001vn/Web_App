using ShopHouse.ViewModels.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopHouse.ViewModels.System.Users
{
    public class UserVm
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
        [Display(Name = "Tên Đăng Nhập")]
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
    }
}