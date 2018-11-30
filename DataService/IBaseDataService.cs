using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public interface IBaseDataService<TModel, TKey> where TModel : class
    {

        TModel Add(TModel item);
        TModel Update(TModel item);
        TModel Delete(TModel item);

        TModel Get(TKey id);
        IQueryable<TModel> All();
        IQueryable<TModel> All(int PageSize, int PageIndex);

        long Count();

        int Save();

    }
}
