using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenelRepo<T>
    {
        List<T> Listele(string method);
        int Ekle(T entity);
        void Sil(T Entity,string method);
        int Guncelle(T Entity);
    }
}
