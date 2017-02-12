namespace FolderSize
{  
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024.00 / 1024.00;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
