using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {

        [TestMethod()]
        public void Chek_8Symbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Chek_4Symbols_ReturnsFalse()
        {
            string password = "Aq1$";
            

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Chek_30Symbols_ReturnsFalse()
        {
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Chek_PasswordWithDigits_ReturnsTrue()
        {
            string password = "ASDqwe1$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Chek_PasswordWithLowerSymbols_ReturnsTrue()
        {
            string password = "ASDq123$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void Chek_30Symbols_ReturnsFalse()
        {
            string password = "ASqw12$$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

    }
}