using System.Collections.Generic;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            Dictionary<string, string> phoneBookList = new Dictionary<string, string>();

            phoneBook.addContact(phoneBookList, "Levani", "3525235252");
            phoneBook.addContact(phoneBookList, "Levani", "3525235254");
            phoneBook.addContact(phoneBookList, "Levani", "3525235253");
            phoneBook.addContact(phoneBookList, "Giorgi", "3525235252");
            phoneBook.addContact(phoneBookList, "Gio", "12311231");
            phoneBook.addContact(phoneBookList, "Gio", "12311222221");
            phoneBook.deleteContact(phoneBookList,"giooo");
            phoneBook.deleteContact(phoneBookList,"Gio");
            phoneBook.searchContact(phoneBookList, "test");
            phoneBook.searchContact(phoneBookList, "Levani");

            foreach (var phoneBookLists in phoneBookList) {
                Console.WriteLine($"{phoneBookLists.Key} : {phoneBookLists.Value}");
            }
        }
    }
}
