using lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account> 
            {
                new Account()
                { 
                Id = 1,
                Name = "Thuy Kieu",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/hehe.png"),
                Gender = 0,
                Bio = "Hehe",
                Birthday = new DateTime(2003, 1, 13)
                },

                new Account()
                {
                Id = 2,
                Name = "Nguu Ma Vuong",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/duongtang.jpg"),
                Gender = 0,
                Bio = "meme",
                Birthday = new DateTime(2003, 05, 23)
                },

                new Account()
                {
                Id = 3,
                Name = "Hong Hai Nhi",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/dao.jpg"),
                Gender = 0,
                Bio = "Hehe",
                Birthday = new DateTime(2003, 06, 29)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            //goi doi tuong ra de su dung
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                Id = 1,
                Name = "Thuy Kieu",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/hehe.png"),
                Gender = 0,
                Bio = "Hehe",
                Birthday = new DateTime(2003, 1, 13)
                },

                new Account()
                {
                Id = 2,
                Name = "Nguu Ma Vuong",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/duongtang.jpg"),
                Gender = 0,
                Bio = "meme",
                Birthday = new DateTime(2003, 05, 23)
                },

                new Account()
                {
                Id = 3,
                Name = "Hong Hai Nhi",
                Email = "Test@gmail.com",
                Phone = "0235125894",
                Address = "Ha Noi",
                Avatar = Url.Content("./images/avatar/dao.jpg"),
                Gender = 0,
                Bio = "Hehe",
                Birthday = new DateTime(2003, 06, 29)
                },
            };
            //su dung using.System.Linq; truy xuat du lieu 1 doi tuong trong danh sach theo id
            Account account_ne = accounts.FirstOrDefault(ac => ac.Id == id);
            //gui doi tuong qua view 
            ViewBag.hehe = account_ne;
            return View();
        }
    }
}
