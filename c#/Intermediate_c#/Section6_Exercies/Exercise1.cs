using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intermediate_Exercies
{
    public interface IworkEngine
    {
        void Upload(string a);
        void Notify(string a);
        void ChangeStatus();
        void Execute();

    }
    class VideoUploaded : IworkEngine
    {
        public void Upload(string URL)
        {
            Console.WriteLine("Uploading to " + URL);
        }
        public void Notify(string email)
        {
            Console.WriteLine("Email sent to " + email);
        }
        public void ChangeStatus()
        {
            Console.WriteLine("Changed status to uploaded");
        }
        public void Execute()
        {
            Upload("videoUploadURL");
            Notify("email@email.Ether");
            ChangeStatus();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var youtubeLite = new VideoUploaded();
            youtubeLite.Execute();

        }
    }
}
