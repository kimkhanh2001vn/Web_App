using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.Utilities.Extentions
{
    public class ShopHouseException : Exception
    {
        public ShopHouseException()
        {
        }
        public ShopHouseException(string message)
            :base(message)
        {
        }
        public ShopHouseException(string message, Exception innerException)
            :base(message,innerException)
        {
        }
    }
}
