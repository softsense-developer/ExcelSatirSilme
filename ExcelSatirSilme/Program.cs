using ClosedXML.Excel;
using System;

namespace ExcelSatirSilme
{
    internal class Program
    {
        static void Main(string[] args)
        {//dosya uzantısının xlsx olması lazım xls dosyasını açıp farklı kaydet deyip aşağıdan excel dosyası diye kaydedersen yeterli olur
            using (var workbook = new XLWorkbook(@"C:\Users\pc\source\repos\ConsoleApp2\AYSESAHİN.xlsx"))// klasörün yolunu yapıştırın 
            {
                var worksheet = workbook.Worksheet(1);
                for (int i = 1; i <= 100; i++)//kac satır silmesini istiyorsanız 100 yerine onu yazın
                {
                    worksheet.Row(1).Delete();
                    Console.WriteLine(i);
                }
                workbook.Save();
            }
        }
    }
}
