using Firebase.Database;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietnamHistory.Models;

namespace VietnamHistory.Data
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://vietnam-history-eab32.firebaseio.com/");

        public async Task<List<Period>> GetAllPeriods()
        {
            List<Period> res = (await firebase
             .Child("Periods")
             .OnceAsync<Period>()).Select(item => new Period
             {
                 PeriodName = item.Object.PeriodName,
                 ID = item.Object.ID
             }).ToList();


            return res;
        }
    }
}
