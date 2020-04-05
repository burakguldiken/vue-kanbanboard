using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kanbanboard.core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kanbanboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        #region Variables
        public IMethod _SMethod;
        #endregion
        #region Constructor        
        public BaseController(IMethod _SMethod)
        {   
            this._SMethod = _SMethod;
        }
        #endregion
    }
}