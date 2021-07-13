namespace Design_Patterns_Implementation.Chain_of_Responsibility
{
    public class Dialog : Container
    {
        public string WikiPageURL;

        public override void ShowHelp()
        {
            if(WikiPageURL != null)
            {
                System.Console.WriteLine(WikiPageURL);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}