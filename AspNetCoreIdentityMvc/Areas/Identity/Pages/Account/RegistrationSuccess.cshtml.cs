using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspNetCoreIdentityMvc.Areas.Identity.Pages.Account
{
    public class RegistrationSuccess : PageModel
    {
        private readonly ILogger<RegistrationSuccess> _logger;

        public RegistrationSuccess(ILogger<RegistrationSuccess> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}