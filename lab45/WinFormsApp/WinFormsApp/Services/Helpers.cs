using MyLibrary.Data;
using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Services
{
    public static class Helpers
    {
        public async static Task<int> GetRoleId(Role role)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new($"SELECT TOP 1 RoleId FROM [Role] WHERE RoleName = '{role}'", con);

            con.Open();
            int result = -1;
            try
            {
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                result = await reader.ReadAsync() ? reader.GetInt32("RoleId") : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public async static Task<bool> DeleteUser(int id)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_DeleteUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int result = 0;
            try
            {
                result = await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return result > 0;
        }

        public async static IAsyncEnumerable<User> GetAllUsers()
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetUsers, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            User user = null;
           
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                try
                {
                    user = new User
                    {
                        Id = reader.GetInt32("Id"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("lastName"),
                        Email = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        Role = reader.GetString("RoleName").Equals("User") ? Role.User : Role.Admin
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                yield return user;
            }

            con.Close();
        }

        public async static Task<User> GetUser(int id)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                try
                {
                    return new User
                    {
                        Id = reader.GetInt32("Id"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("lastName"),
                        Email = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        Birthday = reader.GetDateTime("Birthday"),
                        Role = reader.GetString("RoleName").Equals("User") ? Role.User : Role.Admin
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            con.Close();
            return null;
        }

        public async static Task<List<Author>> GetAllAuthors()
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetAllAuthors, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            var authors = new List<Author>();

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                try
                {
                    authors.Add(new Author
                    {
                        Id = reader.GetInt32("AuthorId"),
                        Name = reader.GetString("Name"),
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in GetAllAuthors: {ex.Message}");
                }
            }

            con.Close();

            return authors;
        }

        public async static Task<List<Publisher>> GetAllPublishers()
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetAllPublishers, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            var publishers = new List<Publisher>();

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                try
                {
                    publishers.Add(new Publisher
                    {
                        Id = reader.GetInt32("PublisherId"),
                        Name = reader.GetString("PublisherName"),
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in GetAllPublishers: {ex.Message}");
                }
            }

            con.Close();

            return publishers;
        }
    }
}
