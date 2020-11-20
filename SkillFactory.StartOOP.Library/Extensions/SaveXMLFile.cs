namespace SkillFactory.StartOOP.Library.Extensions
{
    /// <summary>
    /// Сохраним данные в XML file
    /// </summary>
    public static class Expansion
    {
        /// <summary>
        /// Расширение для сохранения в файл объекта c# как XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void SaveXMLFile<T>(this T obj, string fileName)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            var path = fileName;
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, obj);
            file.Close();
        }
    }
}
