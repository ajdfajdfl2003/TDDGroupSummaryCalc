# TDD Day01 Homework



## Requirement

- 來源可以為「任何型別的集合」。
- 可以任意決定幾筆一組。
- 回傳每一組加總後的集合
  - 加總結果型別可以直接用 **`<int>`**

## Test

- 3筆一組，取 **Cost** 欄位總和。

- 4筆一組，取 **Revenue** 欄位總和。

- 單筆一組，取 **SellPrice** 欄位總和。

- 兩筆一組，取 **Cost** 欄位總和。

- 分組筆數是負數，丟出 **ArgumentOutOfRangeException** 例外。

- 分組筆數為零，總和為零。

  > 這個不知道行不行。

## Reference

- [FluentAssertions - Collections](https://github.com/dennisdoomen/fluentassertions/wiki#collections)
- [FluentAssertions - Object graph comparison](https://github.com/dennisdoomen/fluentassertions/wiki#object-graph-comparison)
- [[Property selector Expression>. How to get/set value to selected property](http://stackoverflow.com/questions/5075484/property-selector-expressionfunct-how-to-get-set-value-to-selected-property)](http://stackoverflow.com/questions/5075484/property-selector-expressionfunct-how-to-get-set-value-to-selected-property)
- [C# - yeild return 使用方法](http://limitedcode.blogspot.tw/2014/07/c-yeild.html)
- [Extension Methods (C# Programming Guide)](https://msdn.microsoft.com/en-us/library/bb383977.aspx)