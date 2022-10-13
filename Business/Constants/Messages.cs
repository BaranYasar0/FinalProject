using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım saati.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductNameAlreadyExits = "Ürün ismi zaten mevcut";
        public static string CategoryLimitExceed="Kategori limidi aşıldı.";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
