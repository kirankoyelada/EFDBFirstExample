using System.Collections.Generic;
using test.Models;

namespace test.data
{
    public interface IPostRepository
    {
        List<DataLoader> getDataLoader();
    }
}