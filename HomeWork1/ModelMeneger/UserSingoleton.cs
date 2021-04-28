using HomeWork1.Entity;

namespace HomeWork1.ModelMeneger
{
    public static class UserSingleton
    {
        private static Entity.managers _instance;

        public static Entity.managers GetUser()
        {
            if (_instance == null)
            {
                _instance = new Entity.managers();
            }

            return _instance;
        }

        public static Entity.managers FromDatabase (Entity.managers context)
        {
            var user = GetUser();
            user.ID = context.ID;
            user.userId = context.userId;
            user.Login = context.Login;
            user.Password = context.Password;
            return _instance;
        }
    }
}
