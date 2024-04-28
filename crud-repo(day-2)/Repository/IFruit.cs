using crud_repo_day_2_.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace crud_repo_day_2_.Repository
{
    public interface IFruit
    {
        void Insert(Fruit fruit);
        void deletedata(int id);

        Fruit edit(int id);
        void editdata(Fruit fruit);
        List<Fruit> Index();
    }
}
