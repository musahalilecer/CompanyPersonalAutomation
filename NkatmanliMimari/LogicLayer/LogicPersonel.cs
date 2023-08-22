using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer1;
using System.Security.Cryptography.X509Certificates;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LlPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LlPersonelEkle(EntityPersonel p)
        {
            if(p.Ad!="" && p.Soyad!="" && p.Maas >=3500 && p.Ad.Length>=3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LlPersonelSil(int per)
        {
            if(per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LlPersonelGuncelle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 3500 && p.Ad.Length >= 3)
            {
                return DALPersonel.PersonelGuncelle(p);
            }
            else
            {
                return false;
            }
        }
    }
}
