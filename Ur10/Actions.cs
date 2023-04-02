using System.IO;

namespace Ur10 {
    public static class FileUtils {
        public static string ReadStringFromFile(string fileName) {
            using (StreamReader reader = new StreamReader(fileName)) {
                return reader.ReadToEnd();
            }
        }

        public static void WriteStringToFile(string fileName, string contents) {
            using (StreamWriter writer = new StreamWriter(fileName)) {
                writer.WriteLine(contents);
            }
        }
    }
}