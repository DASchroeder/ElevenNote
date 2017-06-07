using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ElevenNote.Web.Controllers;
using ElevenNote.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElevenNote.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public static bool ValidateObject(object o)
        {
            var results = new List<ValidationResult>();

            try
            {
                Validator.TryValidateObject(o, new ValidationContext(o), results, true /* validate all properties */);
                return results.Count == 0;
            }
            catch
            {
                return false;
            }

        }

        [TestMethod]
        public void IndexPageViewBagShouldSetTitleToHome()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Home", result.ViewBag.Message);
        }

        [TestMethod]
        public void UsernameRequiredByModelToRegister()
        {
            var model = new RegisterViewModel
            {
                Email = null,
                ConfirmPassword = "LetMeIn1234!",
                Password = "LetMeIn1234!"
            };

            Assert.IsFalse(ValidateObject(model));
        }
    }
}
