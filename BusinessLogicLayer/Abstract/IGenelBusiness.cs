using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IGenelBusiness<T>
    {
        List<T> Listele();
        int Ekle(T entity);
        void Sil(T Entity);
        int Guncelle(T Entity);
    }
}
