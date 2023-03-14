using MyLibrary.Data;
using MyLibrary.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Services
{
    public static class UserService
    {
        public async static Task<bool> UpdateUser(User user)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_UpdateUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            cmd.Parameters.AddWithValue("@lastName", user.LastName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@date", user.Birthday);

            int roleId;
            if ((roleId = await Helpers.GetRoleId(user.Role)) > 0)
            {
                cmd.Parameters.AddWithValue("@roleId", roleId);
            }
            else
            {
                return false;
            }

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

        public async static Task<bool> LoginUser(string email, string password)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_LoginUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (reader.Read())
            {
                var user = CurrentUser.GetInstance();
                user.Id = reader.GetInt32("Id");
                user.FirstName = reader.GetString("FirstName");
                user.LastName = reader.GetString("LastName");
                user.Role = reader.GetString("RoleName").Equals("User") ? Role.User : Role.Admin;
                return true;
            }

            return false;
        }

        public async static Task<bool> RegisterUser(
            string firstName,
            string lastName,
            string email,
            string password,
            DateTime birthDay,
            Role role)
        {
            using SqlConnection con = new(DataStorage.connectionString);
            using SqlCommand cmd = new(DataStorage.SP_RegisterUser, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@date", birthDay);

            int roleId;
            if ((roleId = await Helpers.GetRoleId(role)) > 0)
            {
                cmd.Parameters.AddWithValue("@roleId", roleId);
            }
            else
            {
                return false;
            }

            con.Open();
            try
            {
                return await cmd.ExecuteNonQueryAsync() == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
