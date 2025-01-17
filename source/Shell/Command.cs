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
}