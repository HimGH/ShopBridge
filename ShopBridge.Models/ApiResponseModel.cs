using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Models
{
    /// <summary>
    /// Api Response Model
    /// </summary>
    public class ApiResponseModel 
    {
        public dynamic data { get; set; }
        public bool success { get; set; }
    }
}
