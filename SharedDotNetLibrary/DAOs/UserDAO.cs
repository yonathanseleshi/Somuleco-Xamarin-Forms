using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using SharedDotNetLibrary.Models;

namespace SharedDotNetLibrary.DAOs
{
    public class UserDAO
    {
    
            readonly SQLiteAsyncConnection database;

            public UserDAO(string dbPath)
            {
                database = new SQLiteAsyncConnection(dbPath);
                database.CreateTableAsync<User>().Wait();
            }

            public Task<List<User>> GetUsersAsync()
            {
                return database.Table<User>().ToListAsync();
            }

     

            public Task<User> GetUserAsync(int id)
            {
                return database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
            }



            public Task<int> SaveUserAsync(User user)
            {
                if (user.ID != 0)
                {
                    return database.UpdateAsync(user);
                }
                else
                {
                    return database.InsertAsync(user);
                }
            }



            public Task<int> DeleteItemAsync(User user)
            {
                return database.DeleteAsync(user);
            }


      
    }
}
