using NameCraft.Models;

namespace NameCraft.Services
{
    public class NicknameGenerator
    {
        private readonly WordBank _wordBank;
        private readonly Random _random = new();

        public NicknameGenerator(WordBank wordBank) => _wordBank = wordBank;

        public string Generate()
            => $"{GetRandom(_wordBank.Adjectives)}{GetRandom(_wordBank.Nouns)}{_random.Next(100)}";

        private string GetRandom(List<string> list) => list[_random.Next(list.Count)];
    }
}
