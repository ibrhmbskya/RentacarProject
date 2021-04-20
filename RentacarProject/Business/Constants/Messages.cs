using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi!";
        public static string CarNameInvalid = "Araba adı 2 harften uzun değil ya da günlük fiyat 0'dan küçük";
        

        //car images
        //CAR IMAGES MESSAGES
        public static string CarImageAdded = "araba resmi eklendi!";
        public static string CarImageDeleted = "araba resmi silindi!";
        public static string CarImageNotDeleted = "araba resmi silinemedi!";
        public static string CarImageUpdated = "araba resmi güncellendi!";
        public static string CarImageNotFound = "araba resmi bulunamadı!";
        public static string CarNotFound = "araba bulunamadı";
        public static string CarImageCountLimitExceeded = "araba resmi limiti aşıldı!";

        //user
        public static string AuthorizationDenied = "Yetkiniz yoktur.";
        public static string UserRegistered="KKayıt oldu";
        public static string UserNotFound= "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";


        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColorListed = "Renkler listelendi";
        public static string CardExist = "Kredi kartı var";


        //customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = " Müşteri güncellendi";


        //rental
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralana Güncellendi";


        public static string CarUndelivered = "Araba teslim edilmemiş.";
    }
}
