<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class material_quote
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.tbMaterialName = New System.Windows.Forms.TextBox()
        Me.cbCarType = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTable = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MaterialTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MaterialTable)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 442)
        Me.SplitContainer1.SplitterDistance = 68
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbCompany, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbMaterialName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbCarType, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSearch, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(834, 68)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(502, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(3)
        Me.Label3.Size = New System.Drawing.Size(160, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "单位"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(336, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3)
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "车型"
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.FormattingEnabled = True
        Me.cbCompany.Location = New System.Drawing.Point(506, 34)
        Me.cbCompany.Margin = New System.Windows.Forms.Padding(7)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(131, 20)
        Me.cbCompany.TabIndex = 2
        '
        'tbMaterialName
        '
        Me.tbMaterialName.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbMaterialName.Location = New System.Drawing.Point(7, 34)
        Me.tbMaterialName.Margin = New System.Windows.Forms.Padding(7)
        Me.tbMaterialName.Name = "tbMaterialName"
        Me.tbMaterialName.Size = New System.Drawing.Size(303, 21)
        Me.tbMaterialName.TabIndex = 0
        '
        'cbCarType
        '
        Me.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarType.FormattingEnabled = True
        Me.cbCarType.Location = New System.Drawing.Point(340, 34)
        Me.cbCarType.Margin = New System.Windows.Forms.Padding(7)
        Me.cbCarType.Name = "cbCarType"
        Me.cbCarType.Size = New System.Drawing.Size(131, 20)
        Me.cbCarType.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(668, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 31)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "搜索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(751, 30)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 31)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "增加/修改"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3)
        Me.Label1.Size = New System.Drawing.Size(327, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "材料名称"
        '
        'MaterialTable
        '
        Me.MaterialTable.AllowUserToAddRows = False
        Me.MaterialTable.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.MaterialTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MaterialTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MaterialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTable.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTable.Name = "MaterialTable"
        Me.MaterialTable.ReadOnly = True
        Me.MaterialTable.RowHeadersWidth = 10
        Me.MaterialTable.RowTemplate.Height = 23
        Me.MaterialTable.Size = New System.Drawing.Size(834, 370)
        Me.MaterialTable.TabIndex = 0
        '
        'material_quote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 442)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 1080)
        Me.MinimumSize = New System.Drawing.Size(750, 480)
        Me.Name = "material_quote"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "材料报价管理"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MaterialTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCompany As ComboBox
    Friend WithEvents tbMaterialName As TextBox
    Friend WithEvents cbCarType As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTable As DataGridView
End Class
