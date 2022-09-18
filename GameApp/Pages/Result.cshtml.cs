using GameApp.Data;
using GameApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameApp.Pages
{
    public class ResultModel : PageModel
    {
        public string result { get; set; }
        public Game game { get; set; }
        private readonly GameService _service;

        public ResultModel(GameService service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            game = await _service.GetGame(id);
            if (game is null)
            {
                return NotFound();
            }
            if (game.wonAmount != 0)
                result = "Congratulations, you won " + game.wonAmount;
            else
                result = "You lost ! Try again";
            return Page();
        }
    }
}
