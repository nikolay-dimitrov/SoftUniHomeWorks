using Problem1Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.AppenderClasses
{
    using Problem1Logger.Classes.ValidatorClasses;

    public class FileAppender : AbstractAppender, IFileAppender
    {
        private string outputFile;

        public FileAppender(ILayout layout)
            : base(layout)
        {

        }

        public string File
        {
            get
            {
                return this.outputFile;
            }
            set
            {
                this.ValidateFilePath(value);
                this.outputFile = value;
            }
        }

        protected override void WriteToOutput(string logMessage)
        {
            this.CheckThatFilePathIsSet();

            this.WriteMessageToFile(logMessage);
        }

        private void ValidateFilePath(string path)
        {
            DataValidator.ValidateMessageString(path, "Failed To Set File - File Path String Cannot Be Null Or Empty");
        }

        private void CheckThatFilePathIsSet()
        {
            DataValidator.CheckThatFilePathIsSet(this.File,
                "Failed Write To File - File Is Not Set In The Current Context");
        }

        private void WriteMessageToFile(string logMessage)
        {
            string path = this.File;
            string message = logMessage + Environment.NewLine;

            System.IO.File.AppendAllText(path, message);
        }

    }
}
