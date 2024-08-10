using Microsoft.AspNetCore.Mvc;
using MLShop.Presentation.Model;

namespace MLShop.Presentation.Controllers
{
    [Route("api/[controller]")] //api/Product
    [ApiController]
    public class TestController : ControllerBase
    {
        /*
        [HttpGet]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(200,Type = typeof(string))]
        public string GetMessage()
        {

            //return Ok("")
            //return BadRequest();
            //return Unauthorized();
            //return InternalServerError()

            return "Hello MLShop Api Project";
        }
       


        [HttpGet]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(ResponseModel))]
        public ResponseModel GetMessage()
        {

            return new ResponseModel()
            {
                StatusCode = 200,
                Message = "Hello from api to person",
                Data = ""
            };

        }
      



        [HttpGet]
        [ProducesResponseType(500, Type = typeof(BaseResponseModel<Product>))]
        [ProducesResponseType(401, Type = typeof(BaseResponseModel<Product>))]
        [ProducesResponseType(400, Type = typeof(BaseResponseModel<Product>))]
        [ProducesResponseType(200, Type = typeof(BaseResponseModel<Product>))]
        public BaseResponseModel<Product> GetMessage()
        {

            return new BaseResponseModel<Product>()
            {
                StatusCode = 200,
                Message = "Hello from api to person",
                Data = new Product() { Name = "Küpe", Price = 500 }
            };

        }
       

        [HttpGet]
        [ProducesResponseType(500, Type = typeof(BaseResponseModel<List<Product>>))]
        [ProducesResponseType(401, Type = typeof(BaseResponseModel<List<Product>>))]
        [ProducesResponseType(400, Type = typeof(BaseResponseModel<List<Product>>))]
        [ProducesResponseType(200, Type = typeof(BaseResponseModel<List<Product>>))]
        public BaseResponseModel<List<Product>> GetMessage()
        {

            return new BaseResponseModel<List<Product>>()
            {
                StatusCode = 200,
                Message = "Hello from api to person",
                Data = new List<Product>()
                {
                    new Product() { Name = "Sandalet" , Price =1400 },
                    new Product() { Name = "Şapka" , Price =2400 },
                    new Product() { Name = "Güneş kremi" , Price =1200 },
                }
            };

        }

            [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(string))]
        public ActionResult<string> GetMessage(int id)
        {
            if (id > 0)
            {
                return Ok("Merhaba APi Dündaysına hoş geldiniz"); //ActionResult->Ok,BadRequest

            }
            else
            {
                return BadRequest("Merhaba APi Dündaysına hoş geldiniz"); //ActionResult->Ok,BadRequest

            }
        }
        */

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(BaseResponseModel<string>))]
        public ActionResult<BaseResponseModel<string>> GetMessage()
        {

            HttpContext.Response.Headers["Custom-header"] = "Ozan,Tugce,Mirac";

            var response = new BaseResponseModel<string>
            {
                StatusCode = 200,
                Message = "işlem başarılı",
                Data = "Test Data"

            };
            return Ok(response);

        }
    }



}
