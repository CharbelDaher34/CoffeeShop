namespace Coffee_shop
{
    public class Helper
    {
        static public void StreamWriter(string content, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                    writer.Write(content);
            }
            catch (Exception)
            {
            }
        }

        static public string StreamReader(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                    return reader.ReadToEnd();
            }
            catch
            {
                return "";
            }
        }
    }
}