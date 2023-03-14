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
    public static class BookService
    {
        public async static Task<bool> AddBook(string bookName, int authorId, int publisherId, string ISBN, int year)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_AddNewBook, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", bookName);
            cmd.Parameters.AddWithValue("@authorId", authorId);
            cmd.Parameters.AddWithValue("@publisherId", publisherId);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@year", year);

            con.Open();
            try
            {
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public async static Task<bool> DeleteBook(int id)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_DeleteBook, con);
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

        public async static Task<bool> TakeBook(int bookId)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_TakeBook, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookId", bookId);
            cmd.Parameters.AddWithValue("@userId", CurrentUser.GetInstance().Id);

            con.Open();
            try
            {
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return false;
        }

        public async static Task<bool> ReturnBook(int bookId)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_ReturnBook, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", bookId);

            con.Open();
            try
            {
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return false;
        }

        public async static Task<bool> UpdateBook(int bookId, string bookName, int authorId, int publisherId, string ISBN, int year)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_UpdateBook, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", bookId);
            cmd.Parameters.AddWithValue("@name", bookName);
            cmd.Parameters.AddWithValue("@authorId", authorId);
            cmd.Parameters.AddWithValue("@publisherId", publisherId);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@year", year);

            con.Open();
            try
            {
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public async static IAsyncEnumerable<Book> GetAllBooks()
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetBooks, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            Book book = null;

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                try
                {
                    book = new Book
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Author = reader.GetString("Author"),
                        Publisher = reader.GetString("Publisher"),
                        Year = reader.GetInt32("Year"),
                        ISBN = reader.GetString("ISBN"),
                        InUse = reader.GetString("StatusName").Equals("In use")
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in GetAllBooks: {ex.Message}");
                }

                yield return book;
            }

            con.Close();
        }

        public async static IAsyncEnumerable<Book> GetBooksForCurrentUser()
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_GetBooksForUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", CurrentUser.GetInstance().Id);

            con.Open();
            Book book = null;

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                try
                {
                    book = new Book
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Author = reader.GetString("Author"),
                        Publisher = reader.GetString("Publisher"),
                        Year = reader.GetInt32("Year"),
                        ISBN = reader.GetString("ISBN"),
                        InUse = reader.GetString("StatusName").Equals("In use")
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in GetAllBooks: {ex.Message}");
                }

                yield return book;
            }

            con.Close();
        }
    }
}
