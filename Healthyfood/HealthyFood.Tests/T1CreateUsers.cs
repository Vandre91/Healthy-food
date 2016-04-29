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
        public void t1_create_user_with_correct_firstname()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("", "ab", 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser(null, "ab", 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" ", "ab", 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" \t\r\n", "ab", 10, 10, 10, true));
        }

        [Test]
        public void t2_create_user_with_correct_lastname()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", null, 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "", 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab ", " ", 10, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", " \t\r\n", 10, 10, 10, true));
        }

        [Test]
        public void t3_create_user_with_correct_age()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", -1, 10, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 130, 10, 10, true));

        }

        [Test]
        public void t4_create_user_with_correct_weight()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, -1, 10, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 231, 10, true));

        }

        [Test]
        public void t5_create_user_with_correct_height()
        {
            Utilisateurs users = new Utilisateurs();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 29, true));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 251, true));

        }

        [Test]
        public void t6_create_a_user_with_a_different_name_and_first_name_of_another_user()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 180, false));
            users.CreateUser("ab", "cde", 10, 10, 180, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cde", 10, 10, 180, false));
        }

        [Test]
        public void t7_create_five_users_max()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false);
            users.CreateUser("abe", "cd", 10, 10, 180, false);
            users.CreateUser("abf", "cd", 10, 10, 180, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("abg", "cd", 10, 10, 180, false));

        }

        [Test]
        public void t8_find_users()
        {
            Utilisateurs users = new Utilisateurs();
            Profil_Utilisateur u = users.CreateUser("ab", "cd", 10, 10, 180, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false);
            Assert.Throws<ArgumentException>(() => users.FindUser("abg","cd"));
            Assert.That(users.FindUser("ab","cd"), Is.EqualTo(u));

        }

        [Test]
        public void t9_remove_users()
        {
            Utilisateurs users = new Utilisateurs();
            users.CreateUser("ab", "cd", 10, 10, 180, false);
            users.CreateUser("abc", "cd", 10, 10, 180, true);
            users.CreateUser("abd", "cd", 10, 10, 180, false);
            users.RemoveUser("ab", "cd");
            Assert.Throws<ArgumentException>(() => users.FindUser("ab", "cd"));
            Assert.Throws<ArgumentException>(() => users.RemoveUser("aassb", "cd"));

        }
    }
}
