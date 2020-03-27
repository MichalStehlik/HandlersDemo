using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5
{
    public class AddModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Input { get; set; } = "";
        public IActionResult OnGet()
        {
            Input = Input + "Ahoj";
            return Page();
        }

        public IActionResult OnGetNazdar()
        {
            Input = Input + "Nazdar";
            return RedirectToPage("/Index");
            //return NotFound(); // 404
            //return Unauthorized(); // 401
        }

        public void OnPost()
        {
            
        }
    }
}