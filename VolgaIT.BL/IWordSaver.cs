namespace VolgaIT.BL
{
    public interface IWordSaver
    {
        string FilePath { get; set; }
        bool IgnoreCase { get; set; }
        void AddWord(string word);
        void Clear();
        void SaveAll();
    }
}
