using System;
using System.Collections.Generic;
using System.Text;

namespace _12_commands
{
    class Bot
    {
        public void commandBot()
        {
            bool waitForStart = true;
            bool programRunning = false;

            var stopCommands = new Dictionary<string, string>()
            {
                {"stop", "STOP"},
                {"exit", "STOP"},
                {"quit", "STOP"},
                {"end", "STOP"}
            };
            var startCommands = new Dictionary<string, string>()
            {
                {"start", "START"},
                {"execute", "START"}
            };

            while (waitForStart)
            {
                Console.WriteLine("Type \"start\" or \"execute\" to start program");
                string word = Console.ReadLine();

                if (startCommands.ContainsKey(word))
                {
                    waitForStart = false;
                    programRunning = true;
                }
            }

            while (programRunning)
            {
                Console.WriteLine("Use any of the commands: stop, exit, quit, end, print");
                string word = Console.ReadLine();

                if (stopCommands.ContainsKey(word))
                {
                    programRunning = false;
                    Console.WriteLine("Program stopped!");
                }

                else if (word == "print")
                {
                    Console.WriteLine("Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.");
                }
            }
        }
    }
}