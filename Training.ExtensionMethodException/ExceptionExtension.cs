using System;
using System.Globalization;
using System.IO;

namespace Training.ExtensionMethodException
{
    public static class ExceptionExtension
    {
        public static void SaveToFile(this Exception e)
        {
            DateTime dt = DateTime.Now;
            PersianCalendar pdt = new PersianCalendar();
            string myDirectory = Directory.GetCurrentDirectory();
            string myFile = Path.Combine(myDirectory, $"{pdt.GetYear(dt)}-{pdt.GetMonth(dt)}-{pdt.GetDayOfMonth(dt)}.txt");
            using (StreamWriter wr = new StreamWriter(myFile, true))
            {
                wr.WriteLine(e.Message);
                wr.WriteLine("--------------");
            }
        }
    }
}
