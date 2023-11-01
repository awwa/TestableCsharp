# Testable

DI を利用してテストを書きやすくするサンプルコードです。

## Untestable プロジェクト

Program.cs に処理がベタ書きされていてユニットテストできないコード。

- 実行方法

```
cd Testable
dotnet run
```

- 出力

```
文字数: 15
逆順: .atad a si sihT
```

## Testable

DI を利用してテストを書きやすくしたコード。

- 実行方法

```
cd Untesable
dotnet run
```

- 出力

```
文字数: 15
逆順: .atad a si sihT
```

## Testable.Test

Testable プロジェクトのテストコード。

```
cd Testable.Test
dotnet test
```
