using System.Text.Json; 

string t = File.ReadAllText("tool.json"); 
List<Tool> tools = JsonSerializer.Deserialize<List<Tool>>(t); 

foreach (Tool tool in tools)
{
    Console.WriteLine(tool.Name);
}

Console.ReadLine(); 

// Tool h = new Tool(){ Name = "Hammare", Weight = 1}; 

// string hText=JsonSerializer.Serialize(h); 

// File.WriteAllText("tool.json",hText); 
class Tool
{
    public string Name { get; set; }
    public int Weight { get; set; }
}