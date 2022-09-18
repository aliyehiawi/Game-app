using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameApp.Data;
using GameApp.Services;

namespace GameApp.Pages
{
    public class ListModel : PageModel
    {
        private readonly GameService _service;

        public ListModel(GameService service)
        {
            _service = service;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _service.GetGames();
        }
    }
}
