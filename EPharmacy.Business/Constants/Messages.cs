using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Business.Constants
{
    public static class Messages
    {
       
        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarılı bir şekilde kayıt edildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yekiniz yok";
    }
}
