using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOPeration
{
    public class BinarySerialization
    {
        public static void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"E:\Bridgelabz\FileIOOperation\FileIOOPeration\Binary.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo deseriialization = (Demo)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName{deseriialization.ApplicationName} ---- ApplicationID {deseriialization.ApplicationID}");
            Console.ReadKey();
        }
            public static void Serialization()
              {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"E:\Bridgelabz\FileIOOperation\FileIOOPeration\Binary.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, sample);
            Console.ReadKey();
            }
    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = " Binary Serialization ";
        public int ApplicationID { get; set; } = 1001;
    }
}
