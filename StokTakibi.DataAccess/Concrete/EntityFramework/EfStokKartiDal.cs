using StokTakibi.Core.DataAccess.EntityFramework;
using StokTakibi.DataAccess.Abstract;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakibi.DataAccess.Concrete.EntityFramework
{
    public class EfStokKartiDal : EfEntityRepositoryBase<StokKarti, StokTakibiContext>, IStokKartiDal
    {
    }
}
