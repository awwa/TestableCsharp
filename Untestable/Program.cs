/// <summary>
/// main内に処理がベタ書きされているので、ユニットテストを書けない。
/// 単一責任の原則に反している。
/// </summary>

// data.txt ファイルの内容を読み取る
string[] lines = File.ReadAllLines("./data.txt");

// 文字数をカウントして出力する
int count = lines.Select(line => line.Length).Sum();
Console.WriteLine($"文字数: {count}");

// 文字順を逆にして出力する
IEnumerable<string> reversedLines = lines.Select(line =>
{
    char[] charArray = line.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
});
string reversed = string.Join("\n", reversedLines);
Console.WriteLine($"逆順: {reversed}");
