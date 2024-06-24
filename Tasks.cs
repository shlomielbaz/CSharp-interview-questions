namespace main;

public class Tasks
{
    public static async Task Run()
    {
        string[] urls = new string[]
        {
            "http://example.com",
            "http://example.org",
            "http://example.net"
        };

        int[] mss = new int[] { 2000, 500, 1000 };

        Task<string>[] downloadTasks = new Task<string>[6];

        for (int i = 0; i < urls.Length; i++)
        {
            string url = urls[i];
            int ms = mss[i];

            downloadTasks[i] = DownloadAsync(url, ms);
            downloadTasks[i + 3] = Task.Run(async () =>
            {
                await Task.Delay(ms);
                return $"{url} - {ms}";
            });
        }

        string[] contents = await Task.WhenAll(downloadTasks);

        foreach (string content in contents)
        {
            Console.WriteLine(content);
        }
    }

    static async Task<string> DownloadAsync(string url, int ms)
    {
        await Task.Delay(ms);
        return url;
    }

    private static bool isBalanced(string str)
    {
        Stack<char> opens = new Stack<char>();

        Dictionary<char, char> bracets = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        char[] inputs = str.ToCharArray();

        foreach (char leter in inputs)
        {
            if (bracets.ContainsKey(leter))
            {
                opens.Push(leter);
            }
            else
            {
                char open = opens.Pop();
                try
                {
                    if (bracets[open] != leter)
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

        }
        return true;
    }
}
