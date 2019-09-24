Imports System.Reflection

Module Extensions
    ''' <summary>
    ''' Indicates if a job has been assigned for the current row
    ''' </summary>
    ''' <param name="GridView"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.Diagnostics.DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Function JobAssigned(ByVal GridView As DataGridView) As Boolean
        If IsDBNull(GridView.Rows(GridView.CurrentRow.Index).Cells("chkConferido").Value) Then
            Return False
        Else
            Return CBool(GridView.Rows(GridView.CurrentRow.Index).Cells("chkConferido").Value)
        End If
    End Function
    ''' <summary>
    ''' Assigns today's date to the job DateAssigned field of the current row
    ''' </summary>
    ''' <param name="GridView"></param>
    ''' <remarks></remarks>
    <System.Diagnostics.DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Sub JobAssignedDate(ByVal GridView As DataGridView)
        GridView.Rows(GridView.CurrentRow.Index).Cells("txtDataConferencia").Value = Now
    End Sub
    ''' <summary>
    ''' Assigns a null date to the DateAssigned field of the current row
    ''' </summary>
    ''' <param name="GridView"></param>
    ''' <remarks></remarks>
    <System.Diagnostics.DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Sub JobAssignedDateToNothing(ByVal GridView As DataGridView)
        GridView.Rows(GridView.CurrentRow.Index).Cells("txtDataConferencia").Value = DBNull.Value
    End Sub
    ''' <summary>
    ''' Commits changes if needed
    ''' </summary>
    ''' <param name="GridView"></param>
    ''' <remarks></remarks>
    <System.Diagnostics.DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Sub CommitJob(ByVal GridView As DataGridView)
        If GridView.IsCurrentCellDirty Then
            GridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


End Module
