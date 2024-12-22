using demo_mvc.Data.Base;
using demo_mvc.Models;

namespace demo_mvc.Data.Service
{
    public class ProducersService :EntityBaseRepository<Producer>, IProducersService

    {
        public ProducersService(AppDbContext context) : base(context)
        {

            
        }
    }
}
