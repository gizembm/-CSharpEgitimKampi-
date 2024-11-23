using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>where T : class
    {
        void Insert(T entitiy);
        void Updater(T entitiy);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
