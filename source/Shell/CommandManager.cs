using System;
using System.Collections.Generic;

namespace saor.Shell
{
    public class Command
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Command(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual string Execute(params string[] args)
        {
            // Default implementation (if any)
            return string.Empty;
        }
    }

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