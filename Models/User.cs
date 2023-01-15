namespace ArquivoCSV.Models
{
    public class User
    {
        public User (string name, string phone, DateTime birthDate)
        {

            Name = name;
            Phone = phone;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }

        public static implicit operator string(User user)
            => $"{user.Name}, {user.Phone}, {user.BirthDate:yyyy-MM-dd}";

        public static implicit operator User(string line)
        {
            var data = line.Split(",");
            return new User(
                data[0],
                data[1],
                data[2].ToDateTime());
        }
    }
    public static class StringExtension
    {
        public static DateTime ToDateTime(this string value)
        {
            var data = value.Split("-");
            return new DateTime(
                int.Parse(data[0]),
                int.Parse(data[1]),
                int.Parse(data[2]));
        }
    }
}