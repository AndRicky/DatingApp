namespace DatingApp.API.Helpers
{
    public class MessageParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        //default page size
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            //if client wants more than MaxPageSize, return MaxPageSize 
            //other wise return what they want
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}