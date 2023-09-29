
//Employee employee = new()
//{
//    fullName = "Semed Huseynov",
//    address = "Ehmedli",
//    age = 27
//};


//Console.WriteLine(employee.fullName);

//Console.WriteLine(employee.GetFullData());





//Employee employee = new()
//{
//    fullName = "Semed Huseynov",
//    age = 27
//};

//Console.WriteLine(employee.GetFullData());




//Employee employee1 = new()
//{
//    fullName = "Semed Huseynov",
//    address = "Ehmedli",
//    age = 27
//};


//Employee employee2 = new()
//{
//    fullName = "Oruc Mehrabov",
//    address = "Yasamal",
//    age = 26
//};



//Employee employee3 = new()
//{
//    fullName = "Ilham Abasli",
//    address = "Lokbatan",
//    age = 19
//};



//Employee[] employees = { employee1, employee2, employee3 };

//foreach (var item in employees)
//{
//    Console.WriteLine(item.GetFullData());

//}



//Book book = new Book();
//Book book = new Book ("title");




//Book book = new Book();

//book.name = "Isgendername";
//book.author = "Nizami";

//Console.WriteLine(book.GetData());



//Book book = new Book("Xosrov", "Nizami");

//Console.WriteLine(book.GetData());

//Book book = new();

//Book book = new(100, "Azerbaycan");



//Users user1 = new Users
//{
//    id = 1,
//    fullName = "Aqshin Veliyev",
//    age = 25
//};



//Users user2 = new Users
//{
//    id = 2,
//    fullName = "Haci Memmedov",
//    age = 28
//};





//Users user3 = new Users
//{
//    id = 3,
//    fullName = "Metanet Abbasova",
//    age = 21
//};





//Users user4 = new Users
//{
//    id = 4,
//    fullName = "Meryem Eliyeva",
//    age = 23
//};


//Users[] people = { user1, user2, user3, user4 };

////foreach (var item in people)
////{
////    Console.WriteLine(item.fullName);
////}

//foreach (var item in people)
//{
//    if(item.id == 2)
//    {
//        Console.WriteLine(item.fullName);
//        break;
//    }
//}



//var result = people.FirstOrDefault(m => m.id > 2);

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}


//static Users[] GetAllUsers()
//{
//    Users user1 = new Users
//    {
//        id = 1,
//        fullName = "Aqshin Veliyev",
//        age = 25
//    };



//    Users user2 = new Users
//    {
//        id = 2,
//        fullName = "Haci Memmedov",
//        age = 28
//    };





//    Users user3 = new Users
//    {
//        id = 3,
//        fullName = "Metanet Abbasova",
//        age = 21
//    };





//    Users user4 = new Users
//    {
//        id = 4,
//        fullName = "Meryem Eliyeva",
//        age = 23
//    };

//    Users[] people = { user1, user2, user3, user4 };
//    return people;

//}

//var result = GetAllUsers();

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}

//static Users[] GetAllUsers()
//{
//    Users user1 = new Users
//    {
//        id = 1,
//        fullName = "Aqshin Veliyev",
//        age = 25
//    };



//    Users user2 = new Users
//    {
//        id = 2,
//        fullName = "Haci Memmedov",
//        age = 28
//    };





//    Users user3 = new Users
//    {
//        id = 3,
//        fullName = "Metanet Abbasova",
//        age = 21
//    };





//    Users user4 = new Users
//    {
//        id = 4,
//        fullName = "Meryem Eliyeva",
//        age = 23
//    };

//    Users[] people = { user1, user2, user3, user4 };
//    return people;

//}

//static void ShowUsers()
//{

//    var result = GetAllUsers();

//    foreach (var item in result)
//    {
//        Console.WriteLine(item.fullName);
//    }
//}


//UserService service = new();

//service.ShowUsers();

//service.GetUserById(3);


//static void SearchByName(string searchText)

//bool isExist = false;

//{
//    Product[] products = GetAllProducts();

//    foreach (var item in products)
//    {
//        if (product.name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
//        {
//            Console.WriteLine($"{ product.id} - { product.name} - {product.price} - {product.count}");
//            isExist = true;

//        }
//        else
//        {
//            isExist = false;

//        }

//        if (!isExist)
//        {
//            Console.WriteLine("NotFound");
//        }

//    }
//}

//SearchByName();




//static Product[] GetAllProducts()
//{
//    Product product1 = new Product
//    {
//        id = 1,
//        name = "Iphone",
//        price = 1200,
//        count = 3
//    };




//    Product product2 = new Product
//    {
//        id = 2,
//        name = "Samsung 12",
//        price = 2200,
//        count = 5
//    };

//    Product product3 = new Product
//    {
//        id = 3,
//        name = "Xiaomi",
//        price = 200,
//        count = 30
//    };



//    Product product4 = new Product
//    {
//        id = 4,
//        name = "Nokia",
//        price = 1000,
//        count = 100
//    };

//    Product[] product = { product1, product2, product3, product4 };

//    foreach (var item in product)
//    {

//    }



//}