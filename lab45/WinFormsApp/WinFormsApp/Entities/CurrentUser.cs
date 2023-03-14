using System;

namespace MyLibrary.Entities
{
    class CurrentUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        

        private CurrentUser() { }

        private static CurrentUser _instance;

        public static CurrentUser GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CurrentUser();
            }
            return _instance;
        }
    }
}
