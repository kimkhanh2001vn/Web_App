using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "defaultString";
        public const string CartSession = "CartSession";
        public const int DisplayViewAll = 6;
        public const string requiredMess = "yêu cầu nhập";

        public class PasswordVal
        {
            public const string regexPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$";
            public const string notification = "Bắt buộc phải có chứa chữ hoa, chữ thường, số và ký tự đặt biệt!";
        }
        public class Appsettings
        {
            public const string DefaultLangueId = "DefaultLangueId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class Productsettings
        {
            public const int NumberOffFeaturedProduct = 8;
            public const int NumberOffPopularproduct = 8;
        }

        public class ProductContants
        {
            public const string NA = "N/A";
        }
    }
}
