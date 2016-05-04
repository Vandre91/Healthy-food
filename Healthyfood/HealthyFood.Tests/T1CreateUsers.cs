using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthyfood;

namespace HealthyFoodTests
{
    [TestFixture]

    public class T1CreateUsers
    {
        [Test]
        public void t01_create_or_modify_user_with_correct_firstname()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("", "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(null, "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" ", "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" \t\r\n", "ab", 10, 30, 30, true, false));
            Profil_Utilisateur u= users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.That(u.FirstName, Is.EqualTo("cd"));
            Assert.That(u.LastName, Is.EqualTo("ab"));
            Assert.That(u.Age, Is.EqualTo(10));
            Assert.That(u.Weight, Is.EqualTo(30));
            Assert.That(u.Height, Is.EqualTo(30));
            Assert.That(u.IsFemale, Is.EqualTo(true));
            Assert.That(u.IsVegetarian, Is.EqualTo(false));
            Assert.Throws<ArgumentException>(() => u.FirstName = "") ;
            Assert.Throws<ArgumentException>(() => u.FirstName = null);
            Assert.Throws<ArgumentException>(() => u.FirstName = " ");
            Assert.Throws<ArgumentException>(() => u.FirstName = " \t\r\n");

        }

        [Test]
        public void t02_create_or_modify_user_with_correct_lastname()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", null, 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab ", " ", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", " \t\r\n", 10, 30, 30, true, false));
            Profil_Utilisateur u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.Throws<ArgumentException>(() => u.LastName = "");
            Assert.Throws<ArgumentException>(() => u.LastName = null);
            Assert.Throws<ArgumentException>(() => u.LastName = " ");
            Assert.Throws<ArgumentException>(() => u.LastName = " \t\r\n");
        }

        [Test]
        public void t03_create_or_modify_user_with_correct_age()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", -1, 10, 10, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 129, 10, 10, true, false));
            Profil_Utilisateur u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.Throws<ArgumentException>(() => u.Age = -1);
            Assert.Throws<ArgumentException>(() => u.Age = 131);

        }

        [Test]
        public void t04_create_user_with_correct_weight()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, -1, 10, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 231, 10, true, false));
            Profil_Utilisateur u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.Throws<ArgumentException>(() => u.Weight = -1);
            Assert.Throws<ArgumentException>(() => u.Weight = 231);

        }

        [Test]
        public void t05_create_user_with_correct_height()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 29, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 251, true, false));
            Profil_Utilisateur u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.Throws<ArgumentException>(() => u.Height = 29);
            Assert.Throws<ArgumentException>(() => u.Height = 251);

        }

        [Test]
        public void t06_create_a_user_with_a_different_name_and_first_name_of_another_user()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 180, false, false));
            users.CreateUser("ab", "cde", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cde", 10, 10, 180, false, false));
        }

        [Test]
        public void t07_create_five_users_max()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            users.CreateUser("abe", "cd", 10, 10, 180, false, false);
            users.CreateUser("abf", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("abg", "cd", 10, 10, 180, false, false));

        }

        [Test]
        public void t08_find_users()
        {
            Utilisateurs users = new Utilisateurs();
            Profil_Utilisateur u = users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.FindUser("abg","cd"));
            Assert.That(users.FindUser("ab","cd"), Is.EqualTo(u));

        }

        [Test]
        public void t09_remove_users()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, true, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            users.RemoveUser("ab", "cd");
            Assert.Throws<ArgumentException>(() => users.FindUser("ab", "cd"));
            Assert.Throws<ArgumentException>(() => users.RemoveUser("aassb", "cd"));

        }

        [Test]
        public void t10_modify_isfemale_and_isvegeterian()
        {
            Utilisateurs users = new Utilisateurs();
            Profil_Utilisateur u =users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            u.IsFemale = true;
            Assert.That(u.IsFemale, Is.EqualTo(true));
            u.IsVegetarian = true;
            Assert.That(u.IsVegetarian, Is.EqualTo(true));

        }
    }
}
