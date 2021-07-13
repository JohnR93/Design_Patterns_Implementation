namespace Design_Patterns_Implementation.Chain_of_Responsibility
{
    public class Panel : Container
    {
        public string ModalHelpText;

        public override void ShowHelp()
        {
            if(ModalHelpText != null)
            {
                System.Console.WriteLine(ModalHelpText);
            }
            else
            {
                base.ShowHelp();
            }           
        }
    }
}