namespace VolgaIT.BL
{
    public interface IWordSaver
    {
        bool IgnoreCase { get; set; }
        void AddWord(string word);
        void Clear();
    }
}
