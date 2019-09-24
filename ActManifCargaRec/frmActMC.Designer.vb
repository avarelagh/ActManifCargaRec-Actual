<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActMC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActMC))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblManifCargaForMRBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblManifCargaForMRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCOs_beDataSet = New ActManifCargaRec.PCOs_beDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblManifCargaForMRBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblManifCargaForMRDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkConferido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtDataConferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblManifCargaForMRTableAdapter = New ActManifCargaRec.PCOs_beDataSetTableAdapters.tblManifCargaForMRTableAdapter()
        Me.TableAdapterManager = New ActManifCargaRec.PCOs_beDataSetTableAdapters.TableAdapterManager()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTitActConferido = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.TblManifCargaForMRBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblManifCargaForMRBindingNavigator.SuspendLayout()
        CType(Me.TblManifCargaForMRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCOs_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblManifCargaForMRDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblManifCargaForMRBindingNavigator
        '
        Me.TblManifCargaForMRBindingNavigator.AddNewItem = Nothing
        Me.TblManifCargaForMRBindingNavigator.BindingSource = Me.TblManifCargaForMRBindingSource
        Me.TblManifCargaForMRBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblManifCargaForMRBindingNavigator.DeleteItem = Nothing
        Me.TblManifCargaForMRBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TblManifCargaForMRBindingNavigatorSaveItem})
        Me.TblManifCargaForMRBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblManifCargaForMRBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblManifCargaForMRBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblManifCargaForMRBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblManifCargaForMRBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblManifCargaForMRBindingNavigator.Name = "TblManifCargaForMRBindingNavigator"
        Me.TblManifCargaForMRBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblManifCargaForMRBindingNavigator.Size = New System.Drawing.Size(1193, 25)
        Me.TblManifCargaForMRBindingNavigator.TabIndex = 0
        Me.TblManifCargaForMRBindingNavigator.Text = "BindingNavigator1"
        '
        'TblManifCargaForMRBindingSource
        '
        Me.TblManifCargaForMRBindingSource.DataMember = "tblManifCargaForMR"
        Me.TblManifCargaForMRBindingSource.DataSource = Me.PCOs_beDataSet
        '
        'PCOs_beDataSet
        '
        Me.PCOs_beDataSet.DataSetName = "PCOs_beDataSet"
        Me.PCOs_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblManifCargaForMRBindingNavigatorSaveItem
        '
        Me.TblManifCargaForMRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblManifCargaForMRBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblManifCargaForMRBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblManifCargaForMRBindingNavigatorSaveItem.Name = "TblManifCargaForMRBindingNavigatorSaveItem"
        Me.TblManifCargaForMRBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblManifCargaForMRBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblManifCargaForMRDataGridView
        '
        Me.TblManifCargaForMRDataGridView.AllowUserToAddRows = False
        Me.TblManifCargaForMRDataGridView.AllowUserToDeleteRows = False
        Me.TblManifCargaForMRDataGridView.AllowUserToOrderColumns = True
        Me.TblManifCargaForMRDataGridView.AllowUserToResizeRows = False
        Me.TblManifCargaForMRDataGridView.AutoGenerateColumns = False
        Me.TblManifCargaForMRDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TblManifCargaForMRDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.TblManifCargaForMRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblManifCargaForMRDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn17, Me.chkConferido, Me.txtDataConferencia, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12})
        Me.TblManifCargaForMRDataGridView.DataSource = Me.TblManifCargaForMRBindingSource
        Me.TblManifCargaForMRDataGridView.Location = New System.Drawing.Point(12, 95)
        Me.TblManifCargaForMRDataGridView.Name = "TblManifCargaForMRDataGridView"
        Me.TblManifCargaForMRDataGridView.Size = New System.Drawing.Size(1169, 370)
        Me.TblManifCargaForMRDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataMC"
        DataGridViewCellStyle25.Format = "d"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data MC"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumMC"
        DataGridViewCellStyle26.Format = "0000"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nr MC"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 4
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 58
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataChegada"
        DataGridViewCellStyle27.Format = "g"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data Chegada"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 93
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NumPco"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nr Pco"
        Me.DataGridViewTextBoxColumn17.MaxInputLength = 4
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'chkConferido
        '
        Me.chkConferido.DataPropertyName = "Conferida"
        Me.chkConferido.HeaderText = "Conferido"
        Me.chkConferido.Name = "chkConferido"
        Me.chkConferido.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkConferido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkConferido.Width = 77
        '
        'txtDataConferencia
        '
        Me.txtDataConferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.txtDataConferencia.DataPropertyName = "DataConferida"
        DataGridViewCellStyle28.Format = "g"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.txtDataConferencia.DefaultCellStyle = DataGridViewCellStyle28
        Me.txtDataConferencia.HeaderText = "Data Conferencia"
        Me.txtDataConferencia.MaxInputLength = 20
        Me.txtDataConferencia.Name = "txtDataConferencia"
        Me.txtDataConferencia.Width = 105
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Artigo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nr PCO Transp"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descrição"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 255
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Quant"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "N0"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn8.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 87
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Un"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Un"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 46
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Peso"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "#,##0.0"
        DataGridViewCellStyle30.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn9.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 56
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Nº Factura"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nr Factura"
        Me.DataGridViewTextBoxColumn12.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 76
        '
        'TblManifCargaForMRTableAdapter
        '
        Me.TblManifCargaForMRTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblManifCargaForMRTableAdapter = Me.TblManifCargaForMRTableAdapter
        Me.TableAdapterManager.UpdateOrder = ActManifCargaRec.PCOs_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(988, 57)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Gravar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblTitActConferido
        '
        Me.lblTitActConferido.AutoSize = True
        Me.lblTitActConferido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitActConferido.Location = New System.Drawing.Point(427, 30)
        Me.lblTitActConferido.Name = "lblTitActConferido"
        Me.lblTitActConferido.Size = New System.Drawing.Size(341, 50)
        Me.lblTitActConferido.TabIndex = 3
        Me.lblTitActConferido.Text = "Encomendas na Zona de Conferência" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Actualiza Data da Conferência"
        Me.lblTitActConferido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(1104, 57)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmActMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 481)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblTitActConferido)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TblManifCargaForMRDataGridView)
        Me.Controls.Add(Me.TblManifCargaForMRBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActMC"
        Me.Text = "p"
        CType(Me.TblManifCargaForMRBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblManifCargaForMRBindingNavigator.ResumeLayout(False)
        Me.TblManifCargaForMRBindingNavigator.PerformLayout()
        CType(Me.TblManifCargaForMRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCOs_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblManifCargaForMRDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PCOs_beDataSet As PCOs_beDataSet
    Friend WithEvents TblManifCargaForMRBindingSource As BindingSource
    Friend WithEvents TblManifCargaForMRTableAdapter As PCOs_beDataSetTableAdapters.tblManifCargaForMRTableAdapter
    Friend WithEvents TableAdapterManager As PCOs_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblManifCargaForMRBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblManifCargaForMRBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblManifCargaForMRDataGridView As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTitActConferido As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents chkConferido As DataGridViewCheckBoxColumn
    Friend WithEvents txtDataConferencia As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents btnSair As Button
End Class
