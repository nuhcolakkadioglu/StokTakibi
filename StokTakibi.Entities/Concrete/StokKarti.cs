using StokTakibi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakibi.Entities.Concrete
{
    public class StokKarti : IEntity
    {
        public int Id { get; set; }
        public string StokAdi { get; set; }
        public string StokBarkod { get; set; }
        public int BirimId { get; set; }
        public decimal Kdv { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }

        public bool IsDeleted { get; set; }

    }
}
