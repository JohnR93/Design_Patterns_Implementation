namespace Design_Patterns_Implementation.Chain_of_Responsibility
{
    public class Component : IContextualHelp
    {
        private IContextualHelp container;
        public string tooltipText;

        public virtual void ShowHelp()
        {
            if(tooltipText != null)
            {
                System.Console.WriteLine(tooltipText);
            }
            else
            {
                container.ShowHelp();
            }
        }

        public IContextualHelp SetNext(IContextualHelp next)
        {
            container = next;
            return next;
        }
    }
}