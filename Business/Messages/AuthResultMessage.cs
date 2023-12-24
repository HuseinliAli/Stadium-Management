using Framework.Entities.Users;

namespace Business.Messages
{
    public static class AuthResultMessage
    {
        public static string AuthorizationDenied = "Girise icaze verilmedi";
    }
    public static class UserResultMessage
    {
        internal static readonly string UserAlreadyExists;
        public static string UserAdded = "Istifadeci elave edildi";

        public static string UserRegistered = "Istifadeci qeydiyyat edildi";

        public static string UserNotFound { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static User PasswordError { get; internal set; }
    }
}
