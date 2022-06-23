using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Helpers
{
    /// <summary>
    /// arquivo result data com duas classes, cada uma com sua atribuição
    /// 
    /// </summary>
    public class ResultData
    {
        public ResultData(bool success)
        {
            this.Success = success;
        }
        public bool Success 
        {
            get; set;
        }
    }

    public class ResultData<T> : ResultData
    {
        public ResultData(T data): base(true)
        {
            this.data = data;
        }
        public T data 
        {
            get; set;
        }
    }
}
