using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// in order to use files
using System.IO;  //because we are using files;


namespace WFApp51
{
    class TextFileHelper
    {
        // ----------------FIELDS AND PROPERTIES-------------
        //StreamReader (for text input from
        //a file), StreamWriter (for text output to a file) and FileStream(for both input from and
        //output to a file).

        // Default text file name
        private static String defFilePath = "../../DefaultFile.txt";
        public static String DefFilePath
        {
            get { return defFilePath; }
        }

        // ----------------METHODS-------------
        /// <summary>
        /// Opens and returns the string from the default txt file
        /// Out is required for specifyig the output destination, if there's such
        /// As the txt file stores text in lines we need a list of 
        /// strings to get each line
        /// </summary>
        /// <returns>
        /// The boolean value FALSE - if the method was not successful
        /// and TRUE otherwise
        /// </returns>
        public static bool OpenFile(out List<String> Res)
        {
            bool MethodRes = false;
            // FileStream can be used to write data to and read data from files.
            FileStream fs = null;
            // Implements a TextReader that reads characters from a byte stream in a particular encoding.
            StreamReader sr = null;
            Res = new List<string>();
            try
            {
                // opens a file and starts the streaming a current of bytes
                fs = new FileStream(defFilePath, FileMode.Open, FileAccess.Read);
                // sr reads the stream and converts the bytes into text
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Res.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                    Res.Add(line);
                }
                // This means that the method was performed succesfully
                MethodRes = true;
            }
            // if somethind went wrong, while opening a file
            catch
            {
                
            }
            finally
            {
                // anyways, if the fs and sr were used, we gotta make sure they are now closed.
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Opens a file with a specified path.
        /// Out is required for specifyig the output destination, if there's such
        /// As the txt file stores text in lines we need a list of 
        /// strings to get each line
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns>
        /// The boolean value FALSE - if the method was not successful
        /// and TRUE otherwise
        /// </returns>
        public static bool OpenFile(String FileName, out List<String> Res)
        {
            bool MethodRes = false;
            // FileStream can be used to write data to and read data from files.
            FileStream fs = null;
            // Implements a TextReader that reads characters from a byte stream in a particular encoding.
            StreamReader sr = null;
            Res = new List<string>();
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                // sr reads the stream and converts the bytes into text
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Res.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                    Res.Add(line);
                }
                SetDefaultFilePath(FileName);
                // This means that the method was performed succesfully
                MethodRes = true;
            }
            // if somethind went wrong, while opening a file
            catch
            {

            }
            finally
            {
                // anyways, if the fs and sr were used, we gotta make sure they are now closed.
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Saves a text from a specified object to the default file, 
        /// Parameter is an array representation of what to save
        /// </summary>
        /// <param name="tbTextToSave"></param>
        /// <returns>
        /// False - if something went wrong
        /// True - if everything was sucessful 
        /// </returns>
        public static bool SaveFile(string[] textToSave)
        {
            bool MethodRes = false;
            // FileStream can be used to write data to and read data from files.
            FileStream fs = null;
            // Implements a TextWriter for writing characters to a stream in a particular encoding.
            StreamWriter sw = null;
            try
            {

                fs = new FileStream(defFilePath, FileMode.Create, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                // the lines go into the file
                sw = new StreamWriter(fs);
                // that's how we handle the lines in the tb
                // tbTextToSave.Lines gets an array of all the lines
                // in a textbox, which can be then run through and 
                // transfered to FileStream one by one
                foreach (String Line in textToSave)
                {
                    sw.WriteLine(Line);
                }
                MethodRes = true;
            }
            catch
            {

            }
            finally
            {
                /// You should close it only if it was created!
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Saves a text from a specified object to the default file
        /// Parameter is an array representation of what to save
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="textToSave"></param>
        /// <returns>
        /// False - if something went wrong
        /// True - if everything was sucessful 
        /// </returns>
        public static bool SaveFile(string FileName, string[] textToSave)
        {
            bool MethodRes = false;
            // FileStream can be used to write data to and read data from files.
            FileStream fs = null;
            // Implements a TextWriter for writing characters to a stream in a particular encoding.
            StreamWriter sw = null;
            try
            {

                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                // the lines go into the file
                sw = new StreamWriter(fs);
                // that's how we handle the lines in the tb
                // tbTextToSave.Lines gets an array of all the lines
                // in a textbox, which can be then run through and 
                // transfered to FileStream one by one
                foreach (String Line in textToSave)
                {
                    sw.WriteLine(Line);
                }
                MethodRes = true;
            }
            catch
            {

            }
            finally
            {
                /// You should close it only if it was created!
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Saves a text from a specified object to the default file
        /// Parameters: 
        /// ShouldISetDef - is a boolean, True if you want to change
        ///     False if not
        /// ===
        /// textToSave is an array representation of what to save
        /// </summary>
        /// <param name="ShouldISetDef"></param>
        /// <param name="FileName"></param>
        /// <param name="textToSave"></param>
        /// <returns>
        /// False - if something went wrong
        /// True - if everything was sucessful 
        /// </returns>
        public static bool SaveFile(bool ShouldISetDef, string FileName, string[] textToSave)
        {
            bool MethodRes = false;
            // FileStream can be used to write data to and read data from files.
            FileStream fs = null;
            // Implements a TextWriter for writing characters to a stream in a particular encoding.
            StreamWriter sw = null;
            try
            {

                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                // the lines go into the file
                sw = new StreamWriter(fs);
                // that's how we handle the lines in the tb
                // tbTextToSave.Lines gets an array of all the lines
                // in a textbox, which can be then run through and 
                // transfered to FileStream one by one
                foreach (String Line in textToSave)
                {
                    sw.WriteLine(Line);
                }
                MethodRes = true;
            }
            catch
            {

            }
            finally
            {
                /// You should close it only if it was created!
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            if (ShouldISetDef)
            {
                SetDefaultFilePath(FileName);
            }
            return MethodRes;
        }



        /// <summary>
        /// Replaces a def file path with one spec by user
        /// </summary>
        /// <param name="newFilePath"></param>
        public static void SetDefaultFilePath(String newFilePath)
        {
            defFilePath = newFilePath;
        }

        // ----------------CONSTRUCTORS-------------
        // are not necessary for the static class
        // otherwise we could specify that the first constructor just does nothing then sets a default
        // .txt file and makes sure it's created
        // the constructor with a parameter would make a default file name the same as one of choice
    }
}
