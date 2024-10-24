using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    internal class PhoneBook
    {
        int count = 0;

        public Dictionary<string, string> addContact(Dictionary<string,string> phoneBookList ,string name, string phoneNumber)
        {
            
            if (phoneBookList.ContainsKey(name))
            {
                phoneBookList[name + count] = phoneNumber;
                count++;
            }
            else
            {
                phoneBookList[name] = phoneNumber;
            }

            return phoneBookList;

        }

        public Dictionary<string, string> deleteContact(Dictionary<string, string> phoneBookList, string name)
        {
            
            if (phoneBookList.ContainsKey(name))
            {
                phoneBookList.Remove(name);
                
            }
            else
            {
                Console.WriteLine($"Key: {name} Not Found");
            }

            return phoneBookList;

        }
        
        public void searchContact(Dictionary<string, string> phoneBookList, string name)
        {
            if (phoneBookList.ContainsKey(name)){
                Console.WriteLine(phoneBookList[name]);
            } else {
                Console.WriteLine($"Key: {name} Not Found");
            }

            
        }


    }
}
