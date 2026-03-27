
namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit
{
    public class UserEditOnGetUserRequest
    {
        public int id { get; set; } = 0;
        public string ide { get; set; } = "0";
    }

    public class UserEditOnGetUserQuery
    {
        public UserEditOnGetUserRequest Request { get; set; }
    }
}
