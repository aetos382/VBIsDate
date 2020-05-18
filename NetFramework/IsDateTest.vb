Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace NetCore

    <TestClass>
    Public Class IsDateTest

        <TestMethod>
        Sub DotNetFrameworkのIsDateは全角数字でも許可しちゃうの()
            Assert.IsTrue(IsDate("２０２０年１月１日"))
        End Sub
    End Class

End Namespace

