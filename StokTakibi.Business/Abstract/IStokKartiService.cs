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

        List<StokKarti> GetAllByNonDeleted();


        void Add(StokKarti stokKarti);
        void Delete(int id);
        void HardDelete(StokKarti stokKarti);

        void Update(StokKarti stokKarti);
        StokKarti GetById(int stokId);


    }
}
