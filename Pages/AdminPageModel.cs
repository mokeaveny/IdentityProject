﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace IdentityProject.Pages
{
    [Authorize(Roles = "Admin")]
    public class AdminPageModel : PageModel
    {
    }
}
