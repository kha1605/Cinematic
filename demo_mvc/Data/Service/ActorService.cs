using demo_mvc.Data.Base;
using demo_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Data.Service
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorService(AppDbContext context) : base(context) { }
       

    }
}