using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakibi.Business.Abstract
{
   public interface IStokKartiService
    {
        List<StokKarti> GetAll();
        void Add(StokKarti stokKarti);
        void Delete(StokKarti stokKarti);
        void Update(StokKarti stokKarti);
        StokKarti GetById(int stokId);


    }
}
