//Skapa en request
//Skicka request
//Ta emot svar, läsa text
//Deserialisera text
//Skriv ut data

using System.Net.Http.Json;

HttpClient client = new(); 
client.BaseAddress = new Uri("https://pokeapi.co/api/v2/"); 
HttpResponseMessage message=client.GetAsync("pokemon/snorlax").Result;  

//Console.WriteLine(message.Content.ReadAsStringAsync().Result);

pokemon p = message.Content.ReadFromJsonAsync<pokemon>().Result; 

Console.WriteLine(p.Weight);

Console.ReadLine(); 


// using System.Text.Json; 

// string t = File.ReadAllText("tool.json"); 
// List<Tool> tools = JsonSerializer.Deserialize<List<Tool>>(t); 

// foreach (Tool tool in tools)
// {
//     Console.WriteLine(tool.Name);
// }

// Console.ReadLine(); 

// // Tool h = new Tool(){ Name = "Hammare", Weight = 1}; 

// // string hText=JsonSerializer.Serialize(h); 

// // File.WriteAllText("tool.json",hText); 
// class Tool
// {
//     public string Name { get; set; }
//     public int Weight { get; set; }
// }