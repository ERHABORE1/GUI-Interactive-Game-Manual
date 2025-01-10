namespace Text_BasedAdventure
{
    public class Note
{
        public int Id { get; set; }
        public string Content { get; set; }
        public List<string> References { get; set; } = new List<string>();

    }
}
