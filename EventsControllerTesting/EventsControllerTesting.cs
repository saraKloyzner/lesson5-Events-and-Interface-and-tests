using Microsoft.AspNetCore.Mvc;
using myApi;
using myApi.Controllers;
using UnitTests;

namespace EventsControllerTesting
{
    public class EventsControllerTesting
    {
        //[TestClass]
        //public class EventsControllerTest
        //{
        private readonly EventsController _eventController;
        public EventsControllerTesting()
        {
            var context = new DataContextFake();
            _eventController = new EventsController(context);
        }

        [Fact]
        public void Get_ReturnOk()
        {
            //var controller = new EventsController();
            var result = _eventController.Get();

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_ReturnNotFound()
        {
            int id =9;
            //Act
           
            var result = _eventController.Get(id);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
        //[Fact]
        //public void Delete_ReturnBadRequest()
        //{
        //    int id = 8;
        //    var controller = new EventsController();
        //    var result = controller.Get(id);
        //    Assert.IsType<BadRequestResult>(result);
        //}

        //[Fact]

        //public void Put_ReturnUnauthorized()
        //{
        //    int id = 6;
        //    var controller = new EventsController();
        //    var result = controller.Get(id);
        //    Assert.IsType<UnauthorizedResult>(result);
        //}
    }
}