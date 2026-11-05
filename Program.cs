using System.Security;

// часть 1

// Player player = new Player();

// player.Name = "Ярослав";
// player.Level = 10;


// string json = JsonSerializer.Serialize(player);

// Console.WriteLine("Компактный JSON:");
// Console.WriteLine(json);

// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string prettyJson = JsonSerializer.Serialize(player, options);

// Console.WriteLine();
// Console.WriteLine("Форматированный JSON:");
// Console.WriteLine(prettyJson);

// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }
// переменная типа string
// 2 часть

// using System.Text.Json;

// // Создаём JSON вручную
// string json = """
// {
//     "Name": "Ярослав",
//     "Level": 5
// }
// """;

// // Преобразуем JSON в объект Player
// Player restoredPlayer = JsonSerializer.Deserialize<Player>(json);

// // Выводим свойства восстановленного объекта
// Console.WriteLine("Восстановленный объект:");
// Console.WriteLine($"Имя: {restoredPlayer.Name}");
// Console.WriteLine($"Уровень: {restoredPlayer.Level}");


// // Объявляем класс
// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }
// часть 3

// using System.Text.Json;
// using System.IO;


// Player player = new Player();

// player.Name = "Ярослав";
// player.Level = 12;


// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string json = JsonSerializer.Serialize(player, options);


// File.WriteAllText("player.json", json);

// Console.WriteLine("JSON сохранён в файл player.json");


// string readJson = File.ReadAllText("player.json");


// Player restoredPlayer = JsonSerializer.Deserialize<Player>(readJson);


// Console.WriteLine("\nДанные восстановленного объекта:");
// Console.WriteLine($"Имя: {restoredPlayer.Name}");
// Console.WriteLine($"Уровень: {restoredPlayer.Level}");



// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }

// часть 4
// using System.Text.Json;
// List<Player> players = new List<Player>
// {
//     new Player { Name = "Александр", Level = 15 },
//     new Player { Name = "Мария", Level = 20 },
//     new Player { Name = "Иван", Level = 12 },
//     new Player { Name = "Маргорита", Level = 30 }
// };
// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };
// string json = JsonSerializer.Serialize(players, options);
// File.WriteAllText("players.json", json);
// Console.WriteLine("Список игроков сохранён в файл players.json");
// string readJson = File.ReadAllText("players.json");
// List<Player> restoredPlayers =
//     JsonSerializer.Deserialize<List<Player>>(readJson)!;
// Console.WriteLine("\nКоличество игроков: " + restoredPlayers.Count);

// Console.WriteLine("Имя первого игрока: " + restoredPlayers[0].Name);

// Console.WriteLine("Уровень третьего игрока: " + restoredPlayers[2].Level);
// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }

// using System.Text.Json;

// // Читаем файл
// string readJson = File.ReadAllText("players.json");

// try
// {
//     // Пытаемся восстановить список игроков
//     List<Player> restoredPlayers =
//         JsonSerializer.Deserialize<List<Player>>(readJson)!;

//     Console.WriteLine("Количество игроков: " + restoredPlayers.Count);
//     Console.WriteLine("Имя первого игрока: " + restoredPlayers[0].Name);
// }
// catch (JsonException ex)
// {
//     Console.WriteLine("Ошибка при чтении JSON!");
//     Console.WriteLine(ex.Message);
// }

// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }
//При попытке десериализации повреждённого JSON возникает исключение JsonException, оно появляется в ситуации, когда данные JSON имеют неправильный формат
// using System.Text.Json;


// GameSettings settings = new GameSettings();


// settings.PlayerName = "Артём";
// settings.Volume = 80;
// settings.FullScreen = true;
// settings.Difficulty = Difficulty.Hard;


// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string json = JsonSerializer.Serialize(settings, options);


// File.WriteAllText("settings.json", json);

// Console.WriteLine("Настройки сохранены в settings.json");


// if (File.Exists("settings.json"))
// {
//     Console.WriteLine("\nЗагрузка настроек...");

    
//     string readJson = File.ReadAllText("settings.json");

//     try
//     {
        
//         GameSettings loadedSettings =
//             JsonSerializer.Deserialize<GameSettings>(readJson)!;

        
//         Console.WriteLine("\nИгрок: " + loadedSettings.PlayerName);
//         Console.WriteLine("Громкость: " + loadedSettings.Volume);

//         string fullScreen = loadedSettings.FullScreen ? "да" : "нет";

//         Console.WriteLine("Полный экран: " + fullScreen);
//         Console.WriteLine("Сложность: " + loadedSettings.Difficulty);
//     }
//     catch (JsonException ex)
//     {
//         Console.WriteLine("Ошибка загрузки настроек!");
//         Console.WriteLine(ex.Message);
//     }
// }
// else
// {
//     Console.WriteLine("Файл settings.json не найден!");
// }



// class GameSettings
// {
//     public string PlayerName { get; set; } = "";
//     public int Volume { get; set; }
//     public bool FullScreen { get; set; }
//     public Difficulty Difficulty { get; set; }
// }


// enum Difficulty
// {
//     Easy,
//     Normal,
//     Hard
// }
// самостоятельные задачи
// 1 задача

// using System.Text.Json;


// Computer computer = new Computer();

// computer.Price = 120000;
// computer.Processor = "Intel Core i7-14700K";
// computer.Memory = 32;


// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string json = JsonSerializer.Serialize(computer, options);


// Console.WriteLine("JSON компьютера:");
// Console.WriteLine(json);


// Computer restoredComputer =
//     JsonSerializer.Deserialize<Computer>(json)!;


// Console.WriteLine("\nВосстановленные данные:");
// Console.WriteLine("Цена: " + restoredComputer.Price + " руб.");
// Console.WriteLine("Процессор: " + restoredComputer.Processor);
// Console.WriteLine("Объём памяти: " + restoredComputer.Memory + " ГБ");



// class Computer
// {
//     public int Price { get; set; }
//     public string Processor { get; set; } = "";
//     public int Memory { get; set; }
// }
// задача 2
// using System.Text.Json;


// List<Computer> computers = new List<Computer>
// {
//     new Computer
//     {
//         Price = 120000,
//         Processor = "Intel Core i7-14700K",
//         Memory = 32
//     },

//     new Computer
//     {
//         Price = 85000,
//         Processor = "AMD Ryzen 5 7600",
//         Memory = 16
//     },

//     new Computer
//     {
//         Price = 150000,
//         Processor = "Intel Core i9-14900K",
//         Memory = 64
//     },

//     new Computer
//     {
//         Price = 95000,
//         Processor = "AMD Ryzen 7 7700",
//         Memory = 32
//     }
// };


// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string json = JsonSerializer.Serialize(computers, options);


// File.WriteAllText("computers.json", json);

// Console.WriteLine("Список компьютеров сохранён!");


// string readJson = File.ReadAllText("computers.json");


// List<Computer> restoredComputers =
//     JsonSerializer.Deserialize<List<Computer>>(readJson)!;


// Console.WriteLine("\nКоличество компьютеров: " + restoredComputers.Count);


// Console.WriteLine("\nПервый компьютер:");
// Console.WriteLine("Цена: " + restoredComputers[0].Price + " руб.");
// Console.WriteLine("Процессор: " + restoredComputers[0].Processor);
// Console.WriteLine("Память: " + restoredComputers[0].Memory + " ГБ");

// Console.WriteLine("\nТретий компьютер:");
// Console.WriteLine("Цена: " + restoredComputers[2].Price + " руб.");
// Console.WriteLine("Процессор: " + restoredComputers[2].Processor);
// Console.WriteLine("Память: " + restoredComputers[2].Memory + " ГБ");



// class Computer
// {
//     public int Price { get; set; }
//     public string Processor { get; set; } = "";
//     public int Memory { get; set; }
// }
// задача 3
// using System.Text.Json;


// PhoneShop shop = new PhoneShop();

// shop.Phones = new List<Phone>
// {
//     new Phone
//     {
//         Brand = "Apple",
//         Memory = 256
//     },

//     new Phone
//     {
//         Brand = "Samsung",
//         Memory = 512
//     },

//     new Phone
//     {
//         Brand = "Xiaomi",
//         Memory = 128
//     },

//     new Phone
//     {
//         Brand = "Google",
//         Memory = 256
//     }
// };


// shop.Catalog = new Dictionary<int, string>
// {
//     { 1, "iPhone 17 Pro" },
//     { 2, "Samsung Galaxy S25 Ultra" },
//     { 3, "Xiaomi Redmi Note 14" },
//     { 4, "Google Pixel 10" }
// };


// JsonSerializerOptions options = new JsonSerializerOptions
// {
//     WriteIndented = true
// };


// string json = JsonSerializer.Serialize(shop, options);


// File.WriteAllText("phones.json", json);

// Console.WriteLine("Данные телефонов сохранены!");


// if (File.Exists("phones.json"))
// {
//     Console.WriteLine("\nЗагрузка данных...");

    
//     string readJson = File.ReadAllText("phones.json");

//     try
//     {
        
//         PhoneShop restoredShop =
//             JsonSerializer.Deserialize<PhoneShop>(readJson)!;

        
//         Console.WriteLine("\nКоличество телефонов: "
//             + restoredShop.Phones.Count);

        
//         Console.WriteLine("\nСписок телефонов:");

//         foreach (Phone phone in restoredShop.Phones)
//         {
//             Console.WriteLine("Бренд: " + phone.Brand);
//             Console.WriteLine("Память: " + phone.Memory + " ГБ");
//             Console.WriteLine();
//         }

        
//         Console.WriteLine("Каталог телефонов:");

//         foreach (var item in restoredShop.Catalog)
//         {
//             Console.WriteLine(item.Key + " — " + item.Value);
//         }
//     }
//     catch (JsonException ex)
//     {
//         Console.WriteLine("Ошибка загрузки JSON!");
//         Console.WriteLine(ex.Message);
//     }
// }
// else
// {
//     Console.WriteLine("Файл phones.json не найден!");
// }



// class Phone
// {
//     public string Brand { get; set; } = "";
//     public int Memory { get; set; }
// }



// class PhoneShop
// {
//     public List<Phone> Phones { get; set; } = new List<Phone>();

//     public Dictionary<int, string> Catalog { get; set; }
//         = new Dictionary<int, string>();
// }
