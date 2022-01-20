using demo1.Controllers;
using demo1.Models;
using System;
using Xunit;

namespace demo1.Test
{
    public class PostTestContoller
    {

        public class PostTestController
        {
            private PostRepository repository;
            public PostTestController()
            {
                repository = new PostRepository();
            }
            [Fact]
            public void Test_Index_View_Result()
            {
                //Arrange
                var controller = new HomeController(this.repository);
                //Act
                var result = controller.Index();
                //Assert
                Assert.IsType(result);
            }


            [Fact]
            public void Test_Index_Return_Result()
            {
                //Arrange
                var controller = new HomeController(this.repository);
                //Act
                var result = controller.Index();
                //Assert
                Assert.NotNull(result);
            }
            [Fact]
            public void Test_Index_GetPosts_MatchData()
            {
                //Arrange
                var controller = new HomeController(this.repository);
                //Act
                var result = controller.Index();
                //Assert
                var viewResult = Assert.IsType(result); 
                var model = Assert.IsAssignableFrom > (viewResult.ViewData.Model);
                Assert.Equal(3, model.Count); Assert.Equal(101, model[0].PostId); 
                Assert.Equal("Devops", model[0].Title);
            }
        }
    }
}
