namespace Testable;

public class TextRepository : ITextRepository
{
    /// <summary>
    /// ファイルパス
    /// </summary>
    private string _path = string.Empty;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="path"></param>
    public TextRepository(string path)
    {
        _path = path;
    }

    /// <summary>
    /// 引数で指定したファイルの内容を読み込んで返す
    /// </summary>
    /// <returns>ファイルの内容</returns>
    public string[] ReadAllLines()
    {
        return File.ReadAllLines(_path);
    }
}