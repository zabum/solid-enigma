using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Einkaufszettel
{
    public class EinkaufszettelItemDB
    {
        readonly SQLiteAsyncConnection datenbank;

        public EinkaufszettelItemDB(string dbPath)
        {
            datenbank = new SQLiteAsyncConnection(dbPath);
            datenbank.CreateTableAsync<EinkaufszettelItem>().Wait();
        }

        public Task<List<EinkaufszettelItem>> GetItemsAsync()
        {
            return datenbank.Table<EinkaufszettelItem>().ToListAsync();
        }

        public Task<List<EinkaufszettelItem>> GetItemsNotDoneAsync()
        {
            return datenbank.QueryAsync<EinkaufszettelItem>("SELECT * FROM [EinkaufszettelItem] WHERE [Done] = 0");
        }

        public Task<EinkaufszettelItem> GetItemAsync(int id)
        {
            return datenbank.Table<EinkaufszettelItem>().Where(i=>i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(EinkaufszettelItem item)
        {
            if (item.ID != 0)
            {
                return datenbank.UpdateAsync(item);
            }
            else
            {
                return datenbank.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(EinkaufszettelItem item)
        {
            return datenbank.DeleteAsync(item);
        }
     }
}
