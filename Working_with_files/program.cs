namespace working_with_files
{

    public class FileOperations
    {
        public void FileProperties()
        {
            string directoryPath = @"C:\ExampleDirectory";
            string fileName = "example.txt";

            // Combine directory and file name to create a full path
            string fullPath = Path.Combine(directoryPath, fileName);
            Console.WriteLine("Full Path: " + fullPath);

            // Get the file name without extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
            Console.WriteLine("File Name Without Extension: " + fileNameWithoutExtension);

            // Get the file extension
            string fileExtension = Path.GetExtension(fullPath);
            Console.WriteLine("File Extension: " + fileExtension);
        }
    }
    
}