using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_ECommerce.Controllers
{
    public class CompraUsuarioController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;

        public CompraUsuarioController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        

    }
}
