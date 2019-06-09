using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietnamHistory.Models;

namespace VietnamHistory.Data
{
    public class VietnamHistoryDatabase
    {        
        readonly SQLiteAsyncConnection _database;

        public VietnamHistoryDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Period>().Wait();
        }

        async public void InsertAllPeriodsAsync(List<Period> periods)
        {
            List<Period> periodList = await _database.Table<Period>().ToListAsync();

            if (periodList.Count == 0)
            {
                await _database.InsertAllAsync(periods);
            }

        }

        public Task<List<Period>> GetPeriodsAsync()
        {
            return _database.Table<Period>().ToListAsync();
        }
    }
}