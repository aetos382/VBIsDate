Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace NetCore

    <TestClass>
    Public Class IsDateTest

        <TestMethod>
        Sub DotNetCoreのIsDateは全角数字なんか絶対に受け入れたりはしない()
            Assert.IsFalse(IsDate("２０２０年１月１日"))
        End Sub
        
    End Class

End Namespace

