using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;
using System.Web.Mvc;

namespace MvcApplication1.Tests.Controller
{
    [TestClass]
    public class PostControllerTest
    {
        [TestMethod]
        public void EditPost()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            int id = controller.createPost();
            ViewResult result = controller.Edit(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreatePost()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeletePost()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            int id = controller.createPost();
            ViewResult result = controller.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
