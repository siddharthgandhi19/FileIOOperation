using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileIOOPeration
{
    public class JSONSerialization
    {
        public static void JsonDeserialization()
        {
            string json = @"{
                'Name' : 'Sid',
                'Description' : 'Welcome to Coding Club'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
           // Console.WriteLine(bsObj.Name);
            Console.WriteLine("Name = {0} , Description = {1}", bsObj.Name, bsObj.Description);
        }
        public static void JsonSerialization()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Sid",
                Description = "Welcome to Coding Club"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
    }
    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; } 
    }
}
