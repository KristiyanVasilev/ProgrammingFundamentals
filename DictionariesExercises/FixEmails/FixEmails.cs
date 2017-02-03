namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var name = "";
            var mailsList = new Dictionary<string, string>();
            while (name != "stop")
            {
                name = Console.ReadLine();
                if (name != "stop")
                {
                    var mail = Console.ReadLine();
                    mailsList[name] = mail;
                    var fixedMails = mailsList
                        .Where(x => !x.Value.ToLower().EndsWith("us") && x.Value.EndsWith("uk"))
                        .ToDictionary(p => p.Key, p => p.Value);                   
                }
            }
            foreach (var mail in mailsList)
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}
