using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    public static class Messages
    {
        
        

        public static string CheckKeyword(string userInputMessage)
        {
            
            

            
            DB db = new DB();

            if (userInputMessage.Contains(db.WordToFind1) == true)
            {
                return db.Response1;
            }
            if (userInputMessage.Contains(db.WordToFind2) == true)
            {
                return db.Response2;
            }
            else
            {
                string testu1 = "Du har ikke indtastet et gyldigt nøgleord. Prøv igen...";
                return testu1;
            }
        } 
    
    }

    
}
