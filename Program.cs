using ArquivoCSV.Models;

namespace ArquivoCSV;
public class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>
        {
             new("Jonas Ramos diuasbdyiasbfyvaufvauysvfyavfuyavfuyavfu", "5599999999996", DateTime.Now.AddYears(-40)),
             new("Bruna Silva", "5599999999997", DateTime.Now.AddYears(-38)),
             new("Pedro Santos", "5599999999996", DateTime.Now.AddYears(-18)),
             new("Jonas Ramos diuasbdyiasbfyvaufvauysvfyavfuyavfuyavfu", "5599999999996", DateTime.Now.AddYears(-40)),
             new("Bruna Silva", "5599999999997", DateTime.Now.AddYears(-38)),
             new("Pedro Santos", "5599999999996", DateTime.Now.AddYears(-18))

        };

        var data = users.Select(users => (string)users);
        File.WriteAllLines(@"C:\dev\Users.csv", data.ToList()); //salva o CSV

       // var data = File.ReadLines(@"C:\dev\Users.csv"); //ler o CSV

        foreach (var line in data)
        {
            User user = line;
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Phone);
            Console.WriteLine(user.BirthDate);
            Console.WriteLine("--");
        }
    }
}

