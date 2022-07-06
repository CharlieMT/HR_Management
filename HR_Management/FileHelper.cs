using System.IO;
using Newtonsoft.Json;

namespace HR_Management
{
    class FileHelper<T> where T: new()
    {

        private string filePath;

        public FileHelper(string filePath)
        {
            this.filePath = filePath;
        }

        public void SerializeData(T data)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(streamWriter, data);
            }
        }

        public T DeserializeData()
        {
            if (!File.Exists(filePath))
            using (var file = File.Create(filePath))
            {
                file.Close();
            }

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                var deserializeEmployee = (T)JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                streamReader.Close();
                return deserializeEmployee;
            }
        }

    }
}
