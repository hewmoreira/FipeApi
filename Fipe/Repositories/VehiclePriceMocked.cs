using System.Collections.Generic;

namespace Fipe.Repositories
{
    public class VehiclePriceMocked
    {
        public IDictionary<int, int> PriceDb()
        {
            IDictionary<int, int> dictRepos = new Dictionary<int, int>(); ;

            dictRepos.Add(1, 60000);
            dictRepos.Add(2, 70000);
            dictRepos.Add(3, 50000);
            dictRepos.Add(4, 150000);
            dictRepos.Add(5, 300000);
            dictRepos.Add(6, 1000000);
            dictRepos.Add(7, 90000);

            return dictRepos;
        }

        public int SearchValue(int id)
        {
            var dict = PriceDb();

            return dict[id];
        }
    }
}
