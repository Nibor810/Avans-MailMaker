namespace DocentmailMaker
{
    public class MailItem
    {
        private readonly string _teacherName;
        private readonly string _reviewSubjectName;
        private readonly string _reviewCode;

        public MailItem(string textFileValue)
        {
            char[] delimiterChars = { '\t' };
            string[] values = textFileValue.Split(delimiterChars);
            _teacherName = getName(values[0]);
            _reviewSubjectName = getSubject(values[1]);
            _reviewCode = getCode(values[2]);
        }

        public string getName()
        {
            return _teacherName;
        }

        public string getSubject()
        {
            return _reviewSubjectName;
        }

        public string getCode()
        {
            return _reviewCode;
        }

        public override string ToString()
        {
            return 
                "Name: "+_teacherName + "\r\n"+
                "Subject: "+_reviewSubjectName+ "\r\n" +
                "Code: " + _reviewCode + "\r\n";
        }

        public MailItem(string teacherNameCellValue, string reviewSubjectNameCellValue, string reviewCodeCellValue)
        {
            _teacherName = getName(teacherNameCellValue);
            _reviewSubjectName = getSubject(reviewSubjectNameCellValue);
            _reviewCode = getCode(reviewSubjectNameCellValue);
        }

        private string getName(string teacherNameCellValue)
        {
            char[] delimiterChars = {','};
            if (teacherNameCellValue.Contains(","))
            {
                string[] words = teacherNameCellValue.Split(delimiterChars);
                return words[1] + " " + words[0];
            }
            return teacherNameCellValue;
        }

        private string getCode(string reviewSubjectNameCellValue)
        {
            char[] delimiterChars = { '(',')' };
            return reviewSubjectNameCellValue.Trim(delimiterChars);
        }

        private string getSubject(string reviewSubjectNameCellValue)
        {
            char[] delimiterChars = { ':' };
            return reviewSubjectNameCellValue.Trim(delimiterChars);
        }
    }
}