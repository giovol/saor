/*
 * CommandManager in saor.Shell
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/giovol/saor/blob/main/LICENSE
 * Project link: https://github.com/giovol/saor
 */

using System;
using System.Collections.Generic;

namespace saor.Shell
{
    

    public class CommandManager
    {
        private Dictionary<string, Command> commands = new Dictionary<string, Command>();

        public void RegisterCommand(Command command)
        {
            if (!commands.ContainsKey(command.Name))
            {
                commands.Add(command.Name, command);
            }
            else
            {
                throw new ArgumentException($"Command {command.Name} is already registered.");
            }
        }

        public string ExecuteCommand(string commandName, params string[] args)
        {
            if (commands.TryGetValue(commandName, out Command command))
            {
                return command.Execute(args);
            }
            else
            {
                throw new ArgumentException($"Command {commandName} not found.");
            }
        }

        public void ListCommands()
        {
            foreach (var command in commands.Values)
            {
                Console.WriteLine($"{command.Name}: {command.Description}");
            }
        }
    }
}