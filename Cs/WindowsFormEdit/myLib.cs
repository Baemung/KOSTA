namespace myLibrary
{
    public class myLib
    { 
        public static string Get_Token(string fPath)
        {
            string[] spstring = fPath.Split('\\');
            string fName = spstring[spstring.Length - 1];
            //string fName = openFileDialog1.SafeFileName;
            return fName;
        }
    }
}
