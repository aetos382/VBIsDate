Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace NetCore

    <TestClass>
    Public Class IsDateTest

        <TestMethod>
        Sub DotNetCore��IsDate�͑S�p�Ȃ񂩐�΂Ɏ󂯓��ꂽ��͂��Ȃ�()
            Assert.IsFalse(IsDate("�Q�O�Q�O�N�P���P��"))
        End Sub
        
    End Class

End Namespace

