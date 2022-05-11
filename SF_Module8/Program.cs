using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SF_Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(II) [8.1.5]
            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }
            */

            /* (III - IV) [8.2.1 - 8.2.2]
            GetCatalogs();

            static void GetCatalogs()
            {
                string dirName = "C:\\";

                if (Directory.Exists(dirName))
                {
                    string[] dirs = Directory.GetDirectories(dirName);

                    Console.WriteLine("Папки ({0}):", dirs.Length);
                    
                    foreach (string d in dirs)
                        Console.WriteLine(d);

                    string[] files = Directory.GetFiles(dirName);

                    Console.WriteLine("\nФайлы ({0}):", files.Length);
                    

                    foreach (string s in files)
                        Console.WriteLine(s);
                }
            }

            Console.WriteLine();

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\");

                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo("C:\\newDirectory");

                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\newDirectory");
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            */

            /* (V) [8.2.4]
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\moish\Desktop\testFolder");

                string trashPath = @"C:\$Recycle.Bin";

                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /* (VI - VII) [8.3.1 - 8.3.2]
            var fileInfo = new FileInfo(@"D:\Documents\VS\SF\SF_Module8\SF_Module8\Program.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";

                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            */

            /* (VIII) [8.4.1]
            string filePath = @"D:\Documents\VS\SF\SF_Module8\SF_Module8\BinaryFile.bin";

            if (File.Exists(filePath))
            {
                string stringValue;

                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    stringValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);
            }
            */

            /* (IX) [8.4.2]
            WriteValues();
            ReadValues();

            static void WriteValues()
            {
                string filePath = @"D:\Documents\VS\SF\SF_Module8\SF_Module8\BinaryFile.bin";

                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Open)))
                {
                    writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
                }
            }

            static void ReadValues()
            {
                string filePath = @"D:\Documents\VS\SF\SF_Module8\SF_Module8\BinaryFile.bin";

                string StringValue;

                if (File.Exists(filePath))
                {
                    using (BinaryReader reader = new BinaryReader (File.Open(filePath, FileMode.Open)))
                    {
                        StringValue = reader.ReadString();
                    }

                    Console.WriteLine(StringValue);
                }
            }
            */

            /* (X) [8.4.3]
            var contact = new Contact("Andrew", 01234567890, "email@email.com");
            Console.WriteLine("Объект создан");

            // BinaryFormatter formatter = new BinaryFormatter();

            // using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            // {
                // formatter.Serialize(fs, contact);
            // }
            */
        }
    }

    /* (I) [8.1.4]
    public class Drive
    {
        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }

        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }
    }
    */

    /*(II) [8.1.5]
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
    }
    */

    // (X) [8.4.3]
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
    //
}