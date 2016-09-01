using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;
using ClassLibrary2;
using Moq;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var repo = new Mock<IUnitofWork>();
            var getAllReturns = new List<Modal>() {
                new Modal {ID=1,Name="pankaj",Desc="dhami" },
                new Modal {ID=2,Name="rahul",Desc="dhami" },
                new Modal {ID=3,Name="deepak",Desc="dhami" },
                new Modal {ID=4,Name="gaurav",Desc="dhami" }

            };
            repo.Setup(a => a.Repository.GetAllModal(It.IsAny<int>())).Returns(getAllReturns);
            HomeController controller = new HomeController(repo.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            var actual = result.Model;
            // Assert
            Assert.IsNotNull(actual);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}
    }

}
