﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bostan_Miruna_Lab8.Data;
using Bostan_Miruna_Lab8.Models;

namespace Bostan_Miruna_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Bostan_Miruna_Lab8.Data.Bostan_Miruna_Lab8Context _context;

        public IndexModel(Bostan_Miruna_Lab8.Data.Bostan_Miruna_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
