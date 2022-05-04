using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Singleton
{
    class PobierzDane
    {
        public string ReadFile(string key)
        {
            string nameFile = "Finanse.txt";
            string tekst="";
         
                StreamReader stream = new StreamReader(nameFile);
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                   if(line.Contains(key))
                    {
                        return  line;
                    }
                    else
                    {
                        tekst = "Default:0000";
                    }
                }
                stream.Close();
          
            return tekst;
        }
    }
}
