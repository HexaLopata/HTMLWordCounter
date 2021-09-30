namespace VolgaIT.BL
{
    public class WordCounterConfig
    {
        public string FilePath { get; set; } = "output.txt";
        public string[] IgnoredTags { get; set; } = new string[] { "style", "script" };
        public int MaxWordLength { get; set; } = 100;
        public bool IgnoreCase { get; set; } = false;
    }
}
