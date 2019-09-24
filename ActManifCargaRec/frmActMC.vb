Imports ActManifCargaRec.Extensions

Public Class frmActMC
    Private Sub TblManifCargaForMRBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblManifCargaForMRBindingNavigatorSaveItem.Click, btnSave.Click
        Me.Validate()
        Me.TblManifCargaForMRBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PCOs_beDataSet)
        Me.TblManifCargaForMRTableAdapter.Fill(Me.PCOs_beDataSet.tblManifCargaForMR)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PCOs_beDataSet.tblManifCargaForMR' table. You can move, or remove it, as needed.
        Me.TblManifCargaForMRTableAdapter.Fill(Me.PCOs_beDataSet.tblManifCargaForMR)

        Dim r As Integer
        r = Me.PCOs_beDataSet.tblManifCargaForMR.Rows.Count
        'MsgBox(r)
        If r > 0 Then
            AutoSizeHeight()
        Else
            MsgBox("No dta to show in the Grid / Sem linhas para mostrar na grelha")
        End If

    End Sub

    Private Sub AutoSizeHeight()
        If TblManifCargaForMRDataGridView.Rows.Count < 15 Then
            'MessageBox.Show(TblManifCargaForMRDataGridView.Rows.Count)
            TblManifCargaForMRDataGridView.Height = (TblManifCargaForMRDataGridView.Rows.Count() + 3) * TblManifCargaForMRDataGridView.Rows(0).Height
        Else
            TblManifCargaForMRDataGridView.Height = (15 + 3) * TblManifCargaForMRDataGridView.Rows(0).Height
        End If
    End Sub

    Private Sub TblManifCargaForMRDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblManifCargaForMRDataGridView.CellValueChanged
        TblManifCargaForMRDataGridView.Invalidate()
    End Sub

    Private Sub TblManifCargaForMRDataGridView_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TblManifCargaForMRDataGridView.CurrentCellDirtyStateChanged

        If TblManifCargaForMRDataGridView.JobAssigned Then
            TblManifCargaForMRDataGridView.JobAssignedDate()
        Else
            TblManifCargaForMRDataGridView.JobAssignedDateToNothing()
        End If

        TblManifCargaForMRDataGridView.CommitJob()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Public Sub RowsTextColor()

        For i As Integer = 0 To TblManifCargaForMRDataGridView.Rows.Count() - 1 Step +1
            Dim valDate As Date
            valDate = Date.Parse(TblManifCargaForMRDataGridView.Rows(i).Cells(2).Value)
            If valDate < DateAdd("d", -5.0, Date.Now) Then
                TblManifCargaForMRDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.DarkRed
            End If
        Next
        'TblManifCargaForMRDataGridView.DefaultCellStyle.SelectionBackColor = Color.Beige;
        'TblManifCargaForMRDataGridView.DefaultCellStyle.SelectionForeColor = Color.Blue;
    End Sub



    Private Sub TblManifCargaForMRDataGridView_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles TblManifCargaForMRDataGridView.RowPrePaint
        RowsTextColor()
        TblManifCargaForMRDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub TblManifCargaForMRBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles TblManifCargaForMRBindingNavigator.RefreshItems

    End Sub
End Class
