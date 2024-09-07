using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketApplication.Data.Services
{
    public class ActorService : IActorsService
    {
        public readonly AppDbContext _appDbContext;
        public ActorService(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var getallactors = await _appDbContext.Actors.ToListAsync();
            return getallactors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
