/*
 * Command in saor.Shell
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/giovol/saor/blob/main/LICENSE
 * Project link: https://github.com/giovol/saor
 */

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
            return string.Empty;
        }
    }
}