using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameApp.Data;
using GameApp.Services;

namespace GameApp.Pages
{
    public class indexModel : PageModel
    {
        private readonly GameService _service;

        public indexModel(GameService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (Game.number1 < 10 || Game.number1 > 20)
                ModelState.AddModelError(string.Empty, "Number 1 should be between 10 and 20");
            if (Game.number2 < 10 || Game.number2 > 20)
                ModelState.AddModelError(string.Empty, "Number 2 should be between 10 and 20");

            if (ModelState.IsValid)
            {
                if (Game.number1 + Game.number2 > 30)
                    Game.wonAmount = 2 * Game.number1 * Game.number2;
                else
                    Game.wonAmount = 0;
                var id = await _service.CreateGame(Game);

                return RedirectToPage("Result", new { id = id });
            }
            
          return Page();
        }
    }
}
