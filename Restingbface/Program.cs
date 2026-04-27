using System.Net.Http.Json;
using Restingbface;

HttpClient client = new(); 
client.BaseAddress = new Uri("https://swapi.py4e.com/api/"); 
HttpResponseMessage message= client.GetAsync("people/13?format=json").Result;

Starwars s = message.Content.ReadFromJsonAsync<Starwars>().Result; 

Console.WriteLine(s.Name);
Console.WriteLine(s.Height);
Console.WriteLine(s.mass);

message= client.GetAsync("starships/10?format=json").Result;
starwarsship e = message.Content.ReadFromJsonAsync<starwarsship>().Result; 
Console.WriteLine(e.Name);
Console.WriteLine(e.Model);
Console.WriteLine(e.length);
Console.WriteLine(e.crew);
Console.WriteLine(e.passenger);

message= client.GetAsync("films/7?format=json").Result;
Starwarsfilmer p = message.Content.ReadFromJsonAsync<Starwarsfilmer>().Result; 
Console.WriteLine(p.Title);
Console.WriteLine(p.episode_id);
Console.WriteLine(p.director);
Console.WriteLine(p.producer);
Console.WriteLine(p.release_date);

Console.ReadLine(); 