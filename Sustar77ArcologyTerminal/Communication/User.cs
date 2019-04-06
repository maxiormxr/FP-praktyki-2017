namespace Sustar77ArcologyTerminal.Communication
{
    class User
    {
        private string userLogin;
        private string userToken;

        public User()
        {
            userLogin = "mateuszmachcinski@gmail.com";
            userToken = "1D6CCFD3BFC624B7D312E0D7EE329419";
        }

        public string getUserLogin()
        {
            return userLogin;
        }

        public string getUserToken()
        {
            return userToken;
        }
    }
}
