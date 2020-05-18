# マジかよというお気持ち

[NetCore/IsDateTest.vb](NetCore/IsDateTest.vb)
```vbnet
Sub DotNetCoreのIsDateは全角なんか絶対に受け入れたりはしない()
    Assert.IsFalse(IsDate("２０２０年１月１日"))
End Sub
```

[NetFramework/IsDateTest.vb](NetCore/IsDateTest.vb)
```vbnet
Sub DotNetFrameworkのIsDateは全角数字でも許可しちゃうの()
    Assert.IsTrue(IsDate("２０２０年１月１日"))
End Sub
```
