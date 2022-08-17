namespace MediatorPattern_Testing
{
    public class MediatorPatternDemo
    {
        private static void Main(string[] args)
        {
            User Ryan = new User("Ryan");
            User AnimeGirl = new User("Anime Girl");

            Ryan.sendMessage("Hey ;)");
            Ryan.sendMessage("U Up");

            AnimeGirl.sendMessage("Read");
        }//end Main
    }//end MediatorPatternDemo
}//end ns