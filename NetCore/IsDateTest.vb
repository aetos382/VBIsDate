Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace NetCore

    <TestClass>
    Public Class IsDateTest

        <TestMethod>
        Sub DotNetCore‚ÌIsDate‚Í‘SŠp‚È‚ñ‚©â‘Î‚Éó‚¯“ü‚ê‚½‚è‚Í‚µ‚È‚¢()
            Assert.IsFalse(IsDate("‚Q‚O‚Q‚O”N‚PŒ‚P“ú"))
        End Sub
        
    End Class

End Namespace

