using Newtonsoft.Json;
using System;

namespace GeniyIdiotClassLibrary
{
    public class UsersResultStorage
    {
        public static string Path = "UserResults.json";
        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exist(Path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;

        }
        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);

        }
    }
}