namespace JwtApplication.Models
{
    public class UserConstant
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                UserName = "rizwan_admin", EmailAddress ="rizwan.khan@gmail.com",Password="rizju",GivenName="rizju",Surname="Khan",Role="Administrator"
            }, new UserModel()
            {
                UserName = "danish_seller", EmailAddress ="danish.khan@gmail.com",Password="dan",GivenName="dan",Surname="Khan",Role="Seller"
            }
            

        };
    }
}
