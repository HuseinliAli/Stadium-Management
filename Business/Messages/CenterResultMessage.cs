using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public static class CenterResultMessage
    {
        public static string Listed = "Stadion mərkəzləri siyahılandırıldı.";
        public static string ListFailed = "Stadion mərkəzləri siyahılandırılmadı.";
        public static string Added = "Stadion mərkəzi sistemə əlavə edildi.";
        public static string AddFailed = "Stadion mərkəzi sistemə əlavə edilmədi.";
        public static string Removed = "Stadion mərkəzi sistemdən silindi.";
        public static string RemoveFailed = "Stadion mərkəzi sistemdən silinmədi.";
        public static string Updated = "Stadion mərkəzinin məlumatları yeniləndi.";
        public static string UpdateFailed = "Stadion mərkəzinin məlumatları yenilənmədi.";
    }
}
