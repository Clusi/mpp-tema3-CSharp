using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Repository
{
    interface IRepository<Entity>
    {
        void add(Entity e);
        void update(Entity e, int id);
        void delete(int id);
        List<Entity> getAll();
    }
}
