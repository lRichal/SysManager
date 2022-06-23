using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SysManager.Application.Helpers
{
    public static class Utils
    {
        public static ResultData<T> SuccessData<T>(T data, bool success)
        {
            var result = new ResultData<T>(data);
            result.Success = success;
            return result;
        }

        public static IActionResult Convert(ResultData _resultData)
        {
            if (_resultData.Success)
                return new ObjectResult(_resultData) { StatusCode = (int)HttpStatusCode.OK };

            return new BadRequestObjectResult(_resultData);
        }
    }
}
