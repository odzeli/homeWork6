//**Считайте файл различными способами.Смотрите “Пример записи файла различными
//способами”. Создайте методы, которые возвращают массив byte (FileStream, BufferedStream),
//строку для StreamReader и массив int для BinaryReader
using System;
using System.IO;

namespace homeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int kbyte = 1024;
            int mbyte = 1024 * kbyte;
            int gbyte = 1024 * mbyte;
            int size = mbyte;
            //Read FileStream
            //Read BinaryStream
            //Read StreamReader/StreamWriter
            //Read BufferedStream
            BinaryReaderReading(@"D:\data.txt");
            Console.ReadKey();
        }        public static byte[] FileStreamReading(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate);
            byte[] array = new byte[fstream.Length];
            fstream.Read(array, 0, array.Length);
            fstream.Close();
            //string textFromFile = System.Text.Encoding.Default.GetString(array);
            return array;
        }        public static byte[] BufferedStreamReading(string fileName, int size)
        {
            FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate);
            BufferedStream bstream = new BufferedStream(fstream, size);
            byte[] arrayFromFile = new byte[fstream.Length];
            bstream.Read(arrayFromFile, 0, arrayFromFile.Length);
            fstream.Close();
            //string textFromFile = System.Text.Encoding.Default.GetString(arrayFromFile);
            //Console.WriteLine(textFromFile);
            return arrayFromFile;
        }        public static string StreamReaderReading(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader sreader = new StreamReader(fstream);
            string text = sreader.ReadToEnd();
            fstream.Close();
            Console.WriteLine(text);
            return text;
        }
        public static int[] BinaryReaderReading(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryReader breader = new BinaryReader(fstream);
            int[] array = new int[fstream.Length];
            int value;
            int i = 0;
            while ((value = breader.Read()) != -1)
            {
                array[i] = value;
                i++;
                //Console.WriteLine(breader.Read());
            }
            fstream.Close();
            return array;
        }
    }
}
