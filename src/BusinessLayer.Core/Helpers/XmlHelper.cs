using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace BusinessLayer.Core.Helpers
{
    public class XmlHelper
    {
        public static T DeserializeFromXml<T>(string xml)
        {
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        public static void SerializeToXml<T>(T obj, string fileName)
        {
            string directory = AssemblyDirectory;
            string fullPath = Path.Combine(directory, fileName);
            var ser = new XmlSerializer(typeof(T));

            using (var fileStream = new StreamWriter(new FileStream(fullPath, FileMode.Create), Encoding.UTF8))
            {
                ser.Serialize(fileStream, obj);
            }
        }

        public static string SerializeToXmlString<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);

                return textWriter.ToString();
            }
        }

        private static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}
