namespace HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class HornetComm
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var messagePattern = @"^([0-9]*) <-> ([A-Za-z0-9]*)$";
            var broadcastPatter = @"^([^0-9]+) <-> ([A-Za-z0-9]*)$";
            var broadcastDict = new Dictionary<string, string>();
            var privateMessageDict = new Dictionary<string, List<string>>();

            while (line != "Hornet is Green")
            {
                var privateMessage = Regex.Match(line, messagePattern);
                var broadcast = Regex.Match(line, broadcastPatter);

                if (privateMessage.Success)
                {
                    var recipientCode = privateMessage.Groups[1].Value.Reverse();
                    var code = string.Empty;
                    foreach (var symbol in recipientCode)
                    {
                        code += symbol;
                    }
                    var message = privateMessage.Groups[2].Value;

                    if (!privateMessageDict.ContainsKey(code))
                    {
                        privateMessageDict[code] = new List<string>();
                    }
                    privateMessageDict[code].Add(message);

                }
                else if (broadcast.Success)
                {
                    var message = broadcast.Groups[1].Value;
                    var frequancy = broadcast.Groups[2].Value;
                    var diffFrequancy = string.Empty;
                    foreach (var symbol in frequancy)
                    {
                        if (char.IsLetter(symbol))
                        {
                            if (char.IsUpper(symbol))
                            {
                                diffFrequancy += symbol.ToString().ToLower();
                            }
                            else if (char.IsLower(symbol))
                            {
                                diffFrequancy += symbol.ToString().ToUpper();
                            }
                        }
                        else
                        {
                            diffFrequancy += symbol;
                        }
                    }
                    if (!broadcastDict.ContainsKey(diffFrequancy))
                    {
                        broadcastDict[diffFrequancy] = "";
                    }
                    broadcastDict[diffFrequancy] = message;
                }
                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastDict.Values.Count != 0)
            {
                foreach (var broadcast in broadcastDict)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");  
            }

            Console.WriteLine("Messages:");
            if (privateMessageDict.Values.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var privateMessage in privateMessageDict)
                {
                    foreach (var message in privateMessage.Value)
                    {
                        if (message != string.Empty)
                        {
                            Console.WriteLine($"{privateMessage.Key} -> {message}");
                        }
                        else
                        {
                            Console.WriteLine("None");
                            break;
                        }
                    }
                }
            }
        }
    }
}
