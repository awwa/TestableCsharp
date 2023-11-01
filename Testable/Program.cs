using Testable;

/// <summary>
/// Repositoryパターンを使ってTextAnalyzerクラスにDIすることで、テストが書きやすくなった。
/// 単一責任の原則に従っている。
/// </summary>

// data.txt からファイルの内容を読み取るRepositoryを生成する
TextRepository repository = new("./data.txt");

// Repositoryを使ってTextAnalyzerを生成する
TextAnalyzer analyzer = new(repository);

// 文字数をカウントして出力する
int count = analyzer.Count();
Console.WriteLine($"文字数: {count}");

// 文字順を逆にして出力する
string reversed = analyzer.Reverse();
Console.WriteLine($"逆順: {reversed}");

