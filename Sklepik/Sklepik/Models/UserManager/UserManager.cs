using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sklepik.Models.DB;
using Sklepik.Models.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace Sklepik.Models.UserManager
{
    public class UserManager
    {
        public void AddUserAccount(UserSignUpView newUser)  // dodanie użytkownika 
        {
            using (SklepKomputerowyEntities db = new SklepKomputerowyEntities())
            {
                MD5 md5Hash = MD5.Create();
                Klientt user = new Klientt();
                user.email = newUser.Email;
                user.hasło = GetMd5Hash(md5Hash, newUser.Password);
                user.Imie = newUser.Login;
                user.Nazwisko = newUser.Nazwisko;
                user.Nr_tele = newUser.Telefon;
                db.Klientt.Add(user);
                db.SaveChanges();

            }
        }

        public string GetEmail(string login)
        {
            using (SklepKomputerowyEntities db = new SklepKomputerowyEntities())
            {
                var user = db.Klientt.Where(o => o.User_ID.Equals(login));
                if (user.Any())
                {
                    return user.FirstOrDefault().e_mail;
                }
            }
            return string.Empty;
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}