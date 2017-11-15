using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DocentmailMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = Environment.CurrentDirectory + @"\excelfiles\exceltext.txt";
            string fileLocation2 = Environment.CurrentDirectory + @"\excelfiles\mail.txt";
            List<MailItem> mailItems = new TextFileReader(fileLocation).readTekstFile();
            new TextFileMaker(fileLocation2).createMailFiles(mailItems);

        }
    }
}
