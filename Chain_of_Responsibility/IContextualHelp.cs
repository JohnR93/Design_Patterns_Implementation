namespace Design_Patterns_Implementation.Chain_of_Responsibility
{
    public interface IContextualHelp
    {
         void ShowHelp();
         IContextualHelp SetNext(IContextualHelp component);
    }
}