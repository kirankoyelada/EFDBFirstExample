using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.data
{
    public class PostRepo : IPostRepository
    {
         devcustomapplogprocessordbContext db;
         public PostRepo(devcustomapplogprocessordbContext _db)
         {
             this.db=_db;
         }
        public List<DataLoader> getDataLoader()
        {
            var values=db.DataLoader.Take(5).ToList();
            return values;
        }
    }
}