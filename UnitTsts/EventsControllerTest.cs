using myApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace UnitTests
{
    public class EventsControllerTest
    {
        [Fact]
        public void Get_ReturnOk()
        {
            //AAA

            //Arrange

            //Act
            var controller = new EventsController();
            var result = controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public void GetById_ReturnNotFound()
        {
            //AAA

            //Arrange
            int id = 3;

            //Act
            var controller = new EventsController();
            var result = controller.Get(id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
    //[TestClass]
    //public class EventsControllerTest
    //{
    //    private readonly EventsController _eventController;
    //    public EventsControllerTest()
    //    {
    //        _eventController = new EventsController();
    //    }

    //    [Fact]
    //    public void Get_ReturnOk()
    //    {
    //        //var controller = new EventsController();
    //        var result = _eventController.Get();

    //        //Assert
    //        Assert.IsType<OkObjectResult>(result);
    //        Assert.IsType<OkObjectResult>(result);
    //    }

    //    public void GetById_retutnNotFound()
    //    {
    //        int id = 1;
    //        var result = _eventController.Get(id);
    //        Assert.IsType<NotFoundResult>(result);
    //    }
    //    [Fact]
    //    public void Delete_returnBadRequest();
    //    {
    //     int id = 8;
    //     var result = _eventController.Get(id);
    //     Assert.IsType<BadRequestResult>(result);
    //    }

    //    [Fact]

    //    public void Put_ReturnUnauthorized()
    //{
    //    int id =6;
    //    var result = _eventController.Get(id);
    //    Assert.IsType<UnauthorizedResult>(result);
    //}

}