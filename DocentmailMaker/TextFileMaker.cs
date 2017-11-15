using System.Collections.Generic;
using System.IO;

namespace DocentmailMaker
{
    public class TextFileMaker
    {
        private string _fileLocation;
        public TextFileMaker(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public void createMailFiles(List<MailItem> mailItems)
        {
            string fileData = "";
            foreach (var item in mailItems)
            {
                fileData += GetMail(item.getName(), item.getSubject(), item.getCode());
            }
            CreateFile(fileData);
        }

        private void CreateFile(string fileData)
        {
            File.WriteAllText(_fileLocation, fileData);
        }

        private string GetMail(string name, string subject, string code)
        {
            return
                " \r\n" +
                " \r\n" +
                "Beste " + name + ", \r\n" +
                "Hierbij ontvangt u de code van uw docentevaluatie waarmee de studenten kunnen inloggen.\r\n" +
                " \r\n" +
                "Evasys link: https://evasys-eval.avans.nl/evasys/online.php \r\n" +
                "Code: " + code + " \r\n" +
                "Vak: " + subject + "\r\n" +
                " \r\n" +
                "Dit zal ongeveer 10 minuten in beslag nemen.\r\n" +
                " \r\n" +
                "Bij eventuele problemen met het inloggen kunt u controleren of de link begint met https://. Daarnaast kunt u proberen om Google Chrome te gebruiken om Evasys te benaderen. \r\n" +
                " \r\n" +
                "Met vriendelijke groet, \r\n" +
                "Kwaliteitscoördinatie AE & I\r\n" +
                " \r\n" +
                " \r\n";
        }
    }
}