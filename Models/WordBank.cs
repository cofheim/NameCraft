namespace NameCraft.Models
{
    public class WordBank
    {
        public List<string> Adjectives { get; } = new();
        public List<string> Nouns { get; } = new();

        public void LoadWords(IWebHostEnvironment env)
        {
            string wwwroot = env.WebRootPath;
            Adjectives.AddRange(File.ReadAllLines(Path.Combine(wwwroot, "words/adjectives.txt")));
            Nouns.AddRange(File.ReadAllLines(Path.Combine(wwwroot, "words/nouns.txt")));
        }
    }
}
