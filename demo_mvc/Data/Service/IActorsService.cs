using demo_mvc.Models;

namespace demo_mvc.Data.Service
{
    public interface IActorsService
    {
       Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);

    }
}
