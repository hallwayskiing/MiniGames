namespace MiniGames.GameForms
{
    class TypeList
    {
        private List<string> list;

        private Random random;

        private string? lastLine;

        public TypeList()
        {
            list = File.ReadAllLines("D:\\code\\MiniGames\\MiniGames\\Utils\\typelist.txt").ToList();
            random = new Random();
        }
        public string GetRandomLine()
        {
            string line = list[random.Next(list.Count)];
            return line == lastLine ? GetRandomLine() : lastLine = line;
        }
    }
}
