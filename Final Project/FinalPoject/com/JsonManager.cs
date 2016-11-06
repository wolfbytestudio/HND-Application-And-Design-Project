using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com
{
    /// <summary>
    /// Json manager contains a load and save method
    /// to save and load objects to specific files
    /// 
    /// Author - 30008095
    /// </summary>
    public static class JsonManager
    {

        /// <summary>
        /// Loads the target object from a file
        /// 
        /// set your target object to this method
        /// </summary>
        /// <typeparam name="Type">The type of object being loaded</typeparam>
        /// <param name="fileName">The file name</param>
        /// <param name="target">The target object</param>
        /// <returns>the object we targeted</returns>
        public static object load<Type>(string fileName)
        {
            try
            {
                StreamReader file = new StreamReader(fileName);
                string json = file.ReadToEnd();
                file.Close();
                return JsonConvert.DeserializeObject<Type>(json);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }

        }

        /// <summary>
        /// Saves the target object to a file
        /// </summary>
        /// <param name="fileName">the file name we are saving to</param>
        /// <param name="target">the target object we are saving as a json</param>
        public static void save(string fileName, object target)
        {
            try
            {
                string json = JsonConvert.SerializeObject(target);
                StreamWriter writer = new StreamWriter(fileName);
                writer.Write(json);
                writer.Close();
            }
            catch
            {
                throw new Exception("Error saving");
            }
        }
        

    }
}
