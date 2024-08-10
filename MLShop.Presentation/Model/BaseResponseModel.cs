namespace MLShop.Presentation.Model
{
    public class BaseResponseModel<T> //application/json
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public T Data { get; set; }


    }


}

