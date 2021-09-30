using System.IO;
using System.Text.Json;

namespace VolgaIT.BL
{
    public class JsonWordCounterConfigurator : IWordCounterConfigurator
    {
        public IWordSaver WordSaver => _wordSaver;

        public WordCounterConfig Config
        {
            get => _config;
            set
            {
                _config = value;
                SaveJson();
            }
        }

        private IWordSaver _wordSaver;
        private WordCounterConfig _config;
        private string _jsonFilePath;

        public JsonWordCounterConfigurator(IWordSaver wordSaver, string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
            if (File.Exists(_jsonFilePath))
            {
                var jsonConfig = File.ReadAllText(jsonFilePath);
                _config = JsonSerializer.Deserialize<WordCounterConfig>(jsonConfig);
            }
            else
            {
                _config = new WordCounterConfig();
                SaveJson();
            }
            wordSaver.FilePath = Config.FilePath;
            _wordSaver = wordSaver;
        }

        public void Configure(IWordCountService wordCounter)
        {
            _wordSaver.FilePath = Config.FilePath;
            wordCounter.WordSaver = _wordSaver;

            wordCounter.IgnoreCase = Config.IgnoreCase;
            wordCounter.IgnoredTags = Config.IgnoredTags;
            wordCounter.MaxWordLength = Config.MaxWordLength;
        }

        private void SaveJson()
        {
            var jsonConfig = JsonSerializer.Serialize(_config);
            File.WriteAllText(_jsonFilePath, jsonConfig);
        }
    }
}
