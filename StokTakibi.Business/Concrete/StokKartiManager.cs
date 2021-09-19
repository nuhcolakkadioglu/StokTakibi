
using StokTakibi.Business.Abstract;
using StokTakibi.DataAccess.Abstract;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakibi.Business.Concrete
{
    public class StokKartiManager : IStokKartiService
    {
        private IStokKartiDal _stokKarti;
        public StokKartiManager(IStokKartiDal stokKarti)
        {
            _stokKarti = stokKarti;
        }
        public void Add(StokKarti stokKarti)
        {
            _stokKarti.Add(stokKarti);
        }

        public void Delete(int id)
        {
            var result = _stokKarti.Get(m=>m.Id== id);
            result.IsDeleted = true;
            _stokKarti.Delete(result);
           
        }

        public List<StokKarti> GetAll()
        {
            return _stokKarti.GetAll();
        }

        public List<StokKarti> GetAllByNonDeleted()
        {
            return _stokKarti.GetAll(m=>m.IsDeleted==false);
        }

        public StokKarti GetById(int stokId)
        {
            return _stokKarti.Get(m => m.Id == stokId);
        }

        public void HardDelete(StokKarti stokKarti)
        {

            _stokKarti.HardDelete(stokKarti);
        }

        public void Update(StokKarti stokKarti)
        {
            _stokKarti.Update(stokKarti);

        }
    }
}
