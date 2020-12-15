using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    public class DB
    {
        private string response1 = "Foreningens telefonnummer er 88888888";
        private string response2 = "Foreningen åbningstider er fra 10.00 til 12.00";
        private string wordToFind1 = "telefon";
        private string wordToFind2 = "åbningstider";

        public string Response1
        {
            get { return response1; }
            set { Response1 = response1; }
        }
        public string Response2
        {
            get { return response2; }
            set { Response2 = response2; }
        }
        public string WordToFind1
        {
            get { return wordToFind1; }
            set { WordToFind1 = wordToFind1; }
        }
        public string WordToFind2
        {
            get { return wordToFind2; }
            set { WordToFind2 = wordToFind2; }
        }

        public DB()
        {
            
        }
    }
}
