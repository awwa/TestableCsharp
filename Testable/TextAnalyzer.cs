using System.Linq;

namespace Testable;

public class TextAnalyzer
{
    private string[] _lines = default!;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="repository">ITextRepository</param>
    public TextAnalyzer(ITextRepository repository)
    {
        _lines = repository.ReadAllLines();
    }

    /// <summary>
    /// 文字列を逆順にして返す
    /// </summary>
    /// <returns></returns>
    public string Reverse()
    {
        IEnumerable<string> reversedLines = _lines.Select(line =>
        {
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        });
        return string.Join("\n", reversedLines);
    }

    /// <summary>
    /// 文字数をカウントして返す
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return _lines.Select(line => line.Length).Sum();
    }
}