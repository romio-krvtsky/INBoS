using System;
using System.Configuration;

namespace MyLibrary.Data
{
    public static class DataStorage
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["myLib"].ConnectionString;
        public static readonly string SP_LoginUser = "usp_LoginUser";
        public static readonly string SP_RegisterUser = "usp_RegisterUser";
        public static readonly string SP_UpdateUser = "usp_UpdateUser";
        public static readonly string SP_GetAllPublishers = "usp_GetAllPublishers";
        public static readonly string SP_GetAllAuthors = "usp_GetAllAuthors";
        public static readonly string SP_GetUser = "usp_GetUser";
        public static readonly string SP_GetUsers = "usp_GetUsers";
        public static readonly string SP_DeleteUser = "usp_DeleteUser";
        public static readonly string SP_GetBooksForUser = "usp_GetBooksForUser";
        public static readonly string SP_GetBooks = "usp_GetBooks";
        public static readonly string SP_UpdateBook = "usp_UpdateBook";
        public static readonly string SP_ReturnBook = "usp_ReturnBook";
        public static readonly string SP_TakeBook = "usp_TakeBook";
        public static readonly string SP_DeleteBook = "usp_DeleteBook";
        public static readonly string SP_AddNewBook = "usp_AddNewBook";
    }
}
