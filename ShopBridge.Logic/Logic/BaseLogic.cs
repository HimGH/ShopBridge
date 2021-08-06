using ShopBridge.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Logic
{

    public class BaseLogic : IBaseLogic
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
   
}
