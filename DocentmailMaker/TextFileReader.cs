using System;
using System.Collections.Generic;
using System.IO;

namespace DocentmailMaker
{
    public class TextFileReader
    {
        private string _fileLocation;
        public TextFileReader(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public List<MailItem> readTekstFile()
        {
            List<MailItem> mailItems = new List<MailItem>();
            string line;
            int counter = 0;
            
            StreamReader file = new StreamReader(_fileLocation);

            while ((line = file.ReadLine()) != null)
            {
                mailItems.Add(new MailItem(line));
                
                counter++;
            }
            file.Close();
            return mailItems;
        }
    }
}