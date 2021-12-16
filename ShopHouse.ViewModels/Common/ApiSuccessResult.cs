using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultobj)
        {
            IsSuccessed = true;
            ResultObj = resultobj;
        }
        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}
