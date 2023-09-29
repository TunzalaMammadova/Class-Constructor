//using System;


//public class UserService
//{

//    public Users[] GetAllUsers()
//    {
//        Users user1 = new Users
//        {
//            id = 1,
//            fullName = "Aqshin Veliyev",
//            age = 25
//        };



//        Users user2 = new Users
//        {
//            id = 2,
//            fullName = "Haci Memmedov",
//            age = 28
//        };





//        Users user3 = new Users
//        {
//            id = 3,
//            fullName = "Metanet Abbasova",
//            age = 21
//        };





//        Users user4 = new Users
//        {
//            id = 4,
//            fullName = "Meryem Eliyeva",
//            age = 23
//        };

//        Users[] people = { user1, user2, user3, user4 };
//        return people;

//    }

//   public void ShowUsers()
//    {

//        var result = GetAllUsers();

//        foreach (var item in result)
//        {
//            Console.WriteLine(item.fullName);
//        }
//    }
//    public void GetUserById(int Id)
//    {
//        Users[] users = GetAllUsers();

//        var result = users.FirstOrDefault(m => m.id == Id);
//        Console.WriteLine(result.fullName);
//    }
//}



