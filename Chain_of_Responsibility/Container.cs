using System.Collections.Generic;

namespace Design_Patterns_Implementation.Chain_of_Responsibility
{
    public class Container : Component
    {
        protected List<IContextualHelp> children;

        public  void AddChildren(IContextualHelp child)
        {
            children.Add(child);
        }

    }
}