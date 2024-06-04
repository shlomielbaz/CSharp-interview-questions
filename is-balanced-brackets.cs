// write a function gets a string and checks if is balanced brackets, e.g.: isBalanced("(a{[]}){}([])"); will returnces true!

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
