using Microsoft.AspNetCore.Mvc;

namespace lab4.Models
{
    /// <summary>
    /// DataLocal: chua du lieu va cac phuong thuc thuc hien cac chuc nang CRUD
    /// GetPeoples: lay danh sach du lieu Peoples
    /// GetPeolpeById: lay doi tuong peoples theo id
    /// </summary>
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
        new People (){
    Id = 1,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "/images/avatar/cho-mieng.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
new People (){
    Id = 2,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "/images/avatar/cung-khong-phai-doi-thu-cua-chuy.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
new People (){
    Id = 3,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "/images/avatar/dang-khoc-a.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
new People (){
    Id = 4,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "/images/avatar/ua-la-sao.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
new People (){
    Id = 5,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "/images/avatar/cung-khong-phai-doi-thu-cua-chuy.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
new People (){
    Id = 6,
    Name = "Ronaldo",
    Email="ronaldo@gmail.com",
    Phone = "0987656432",
    Address = "Bồ Đào Nha",
    Avatar = "images/avatar/cho-mieng.jpg",
    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
    Birthday = new DateTime(1986/4/7),
    Gender =1
},
        };
        

        public static List<People> GetPeoples()
        { 
        return _peoples;
        }

        public static People? GetPeopleById(int Id)
        { 
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }

    }
    
}
