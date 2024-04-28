using Azure.Core;
using crud_repo_day_2_.Controllers;
using crud_repo_day_2_.Data;
using crud_repo_day_2_.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace crud_repo_day_2_.Repository
{
    public class FruitRepo:IFruit
    {
        private readonly ApplicationDbContext obj;

        public FruitRepo(ApplicationDbContext context)
        {
            obj = context;
        }

        public void Insert(Fruit fruit)
        {
            obj.fruits.Add(fruit);
            obj.SaveChanges();
        }
        public List<Fruit> Index()
        {
            return obj.fruits.ToList();
        }
        public void deletedata(int id)
        {
            var find1 = obj.fruits.Find(id);
            obj.fruits.Remove(find1);
            obj.SaveChanges();
        }

        public Fruit edit(int id)
        {
            return obj.fruits.Where(x => x.Id == id).FirstOrDefault();
        }
        public void editdata(Fruit fruit) 
        {
            var update = obj.fruits.Find(fruit.Id);
            update.Name = fruit.Name;
            update.Price = fruit.Price;
            obj.SaveChanges();



        }
        
    }
}
