using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.InRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Command

        List<T> GetAll();
        List<T> GetActives();
        List<T> GetUpdated();
        List<T> GetDeleted();

        //Modify Command

        void Add(T item);
        void Delete(T item);
        void Destroy(T item);
        void Update(T item);

        void AddRange(List<T> list);
        void DeleteRange(List<T> list);
        void DestroyRange(List<T> list);
        void UpdateRange(List<T> list);

        //Linq Command

        T FirstOrDefault(Expression<Func<T,bool>> exp);

        bool Any(Expression<Func<T,bool>> exp);

        object Select(Expression<Func<T, object>> exp);

        List<T> Where(Expression<Func<T,bool>> exp);

        //Find Command

        T Find(int id);

        //Get FirstDatas

        List<T> GetFirsDatas(int number);

        //Get LastDatas
        List<T> GetLastDatas(int number);


    }
}
