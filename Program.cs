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
