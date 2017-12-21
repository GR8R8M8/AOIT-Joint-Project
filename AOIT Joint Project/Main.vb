Imports System.Threading

Public Module Main
    Public Sub Main()
        AddHandler System.Windows.Forms.Application.ThreadException, AddressOf MyThreadExceptionHandler

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

        AddHandler System.AppDomain.CurrentDomain.UnhandledException, AddressOf MyUnhandledExceptionHandler

        Application.Run(New FRM_Main)
    End Sub

    Sub MyUnhandledExceptionHandler(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        MsgBox("Unhandled Exception")
    End Sub

    Sub MyThreadExceptionHandler(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
        MsgBox("Thread Exception")
    End Sub
End Module
