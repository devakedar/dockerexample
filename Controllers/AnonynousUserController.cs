using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dockersampleconfig.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dockersampleconfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnonynousUserController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()

        {
            using (truyumContext context = new truyumContext())
                if (context != null)
                {
                    return context.MenuItem.ToList();
                }
            return null;
        }
    }
}
