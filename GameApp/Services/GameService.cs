using GameApp.Data;
using Microsoft.EntityFrameworkCore;

namespace GameApp.Services
{
    public class GameService
    {
        readonly AppDbContext _context;
        readonly ILogger _logger;
        public GameService(AppDbContext context, ILoggerFactory factory)
        {
            _context = context;
            _logger = factory.CreateLogger<GameService>();

        }
        public async Task<List<Game>> GetGames()
        {
            return await _context.Games
                .Where(x => x.wonAmount!=0)
                .Select(x => new Game
                {
                    idGame = x.idGame,
                    fullName = x.fullName,
                    number1 = x.number1,
                    number2 = x.number2,
                    wonAmount = x.wonAmount
                })
                .ToListAsync();
        }
        public async Task<int> CreateGame(Game game)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
            return game.idGame;
        }
        public async Task<Game> GetGame(int id)
        {
            return await _context.Games
                .Where(x => x.idGame == id)
                .Select(x => new Game
                {
                    idGame = x.idGame,
                    fullName = x.fullName,
                    number1 = x.number1,
                    number2 = x.number2,
                    wonAmount = x.wonAmount
                })
                .SingleOrDefaultAsync();
        }
    }
}
