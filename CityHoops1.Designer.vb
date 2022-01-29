<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCityHoops1
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
        Me.lbxName = New System.Windows.Forms.ListBox()
        Me.lbxNumberOfFouls = New System.Windows.Forms.ListBox()
        Me.lbxPointsScored = New System.Windows.Forms.ListBox()
        Me.lbxGender = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumberOfFouls = New System.Windows.Forms.Label()
        Me.lblPointsScored = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.TxtNumberOfFouls = New System.Windows.Forms.TextBox()
        Me.txtPointsScored = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHighestPoints = New System.Windows.Forms.Label()
        Me.lblHighestFouls = New System.Windows.Forms.Label()
        Me.lblGrandPoint = New System.Windows.Forms.Label()
        Me.lblGrandFoul = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblmpoints = New System.Windows.Forms.Label()
        Me.lblmfouls = New System.Windows.Forms.Label()
        Me.lbltotalp = New System.Windows.Forms.Label()
        Me.lblTotalFoul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxName
        '
        Me.lbxName.FormattingEnabled = True
        Me.lbxName.Location = New System.Drawing.Point(35, 255)
        Me.lbxName.Name = "lbxName"
        Me.lbxName.Size = New System.Drawing.Size(154, 264)
        Me.lbxName.TabIndex = 0
        '
        'lbxNumberOfFouls
        '
        Me.lbxNumberOfFouls.FormattingEnabled = True
        Me.lbxNumberOfFouls.Location = New System.Drawing.Point(234, 255)
        Me.lbxNumberOfFouls.Name = "lbxNumberOfFouls"
        Me.lbxNumberOfFouls.Size = New System.Drawing.Size(157, 264)
        Me.lbxNumberOfFouls.TabIndex = 1
        '
        'lbxPointsScored
        '
        Me.lbxPointsScored.FormattingEnabled = True
        Me.lbxPointsScored.Location = New System.Drawing.Point(438, 255)
        Me.lbxPointsScored.Name = "lbxPointsScored"
        Me.lbxPointsScored.Size = New System.Drawing.Size(159, 264)
        Me.lbxPointsScored.TabIndex = 2
        '
        'lbxGender
        '
        Me.lbxGender.FormattingEnabled = True
        Me.lbxGender.Location = New System.Drawing.Point(663, 255)
        Me.lbxGender.Name = "lbxGender"
        Me.lbxGender.Size = New System.Drawing.Size(159, 264)
        Me.lbxGender.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 185)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblNumberOfFouls
        '
        Me.lblNumberOfFouls.AutoSize = True
        Me.lblNumberOfFouls.Location = New System.Drawing.Point(231, 185)
        Me.lblNumberOfFouls.Name = "lblNumberOfFouls"
        Me.lblNumberOfFouls.Size = New System.Drawing.Size(80, 13)
        Me.lblNumberOfFouls.TabIndex = 7
        Me.lblNumberOfFouls.Text = "NumberOfFouls"
        '
        'lblPointsScored
        '
        Me.lblPointsScored.AutoSize = True
        Me.lblPointsScored.Location = New System.Drawing.Point(435, 185)
        Me.lblPointsScored.Name = "lblPointsScored"
        Me.lblPointsScored.Size = New System.Drawing.Size(70, 13)
        Me.lblPointsScored.TabIndex = 8
        Me.lblPointsScored.Text = "PointsScored"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(660, 185)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(35, 216)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 10
        '
        'TxtNumberOfFouls
        '
        Me.TxtNumberOfFouls.Location = New System.Drawing.Point(234, 216)
        Me.TxtNumberOfFouls.Name = "TxtNumberOfFouls"
        Me.TxtNumberOfFouls.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumberOfFouls.TabIndex = 11
        '
        'txtPointsScored
        '
        Me.txtPointsScored.Location = New System.Drawing.Point(438, 216)
        Me.txtPointsScored.Name = "txtPointsScored"
        Me.txtPointsScored.Size = New System.Drawing.Size(100, 20)
        Me.txtPointsScored.TabIndex = 12
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(663, 216)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 20)
        Me.txtGender.TabIndex = 13
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(67, 564)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 14
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(67, 613)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblHighestPoints
        '
        Me.lblHighestPoints.AutoSize = True
        Me.lblHighestPoints.Location = New System.Drawing.Point(560, 574)
        Me.lblHighestPoints.Name = "lblHighestPoints"
        Me.lblHighestPoints.Size = New System.Drawing.Size(72, 13)
        Me.lblHighestPoints.TabIndex = 17
        Me.lblHighestPoints.Text = "HighestPoints"
        '
        'lblHighestFouls
        '
        Me.lblHighestFouls.AutoSize = True
        Me.lblHighestFouls.Location = New System.Drawing.Point(560, 623)
        Me.lblHighestFouls.Name = "lblHighestFouls"
        Me.lblHighestFouls.Size = New System.Drawing.Size(68, 13)
        Me.lblHighestFouls.TabIndex = 18
        Me.lblHighestFouls.Text = "HighestFouls"
        '
        'lblGrandPoint
        '
        Me.lblGrandPoint.AutoSize = True
        Me.lblGrandPoint.Location = New System.Drawing.Point(797, 574)
        Me.lblGrandPoint.Name = "lblGrandPoint"
        Me.lblGrandPoint.Size = New System.Drawing.Size(60, 13)
        Me.lblGrandPoint.TabIndex = 21
        Me.lblGrandPoint.Text = "GrandPoint"
        '
        'lblGrandFoul
        '
        Me.lblGrandFoul.AutoSize = True
        Me.lblGrandFoul.Location = New System.Drawing.Point(797, 623)
        Me.lblGrandFoul.Name = "lblGrandFoul"
        Me.lblGrandFoul.Size = New System.Drawing.Size(56, 13)
        Me.lblGrandFoul.TabIndex = 22
        Me.lblGrandFoul.Text = "GrandFoul"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label11.Location = New System.Drawing.Point(146, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(528, 63)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "CityHoopsBasketball"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(67, 664)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblmpoints
        '
        Me.lblmpoints.AutoSize = True
        Me.lblmpoints.Location = New System.Drawing.Point(469, 574)
        Me.lblmpoints.Name = "lblmpoints"
        Me.lblmpoints.Size = New System.Drawing.Size(59, 13)
        Me.lblmpoints.TabIndex = 29
        Me.lblmpoints.Text = "MostPoints"
        '
        'lblmfouls
        '
        Me.lblmfouls.AutoSize = True
        Me.lblmfouls.Location = New System.Drawing.Point(469, 623)
        Me.lblmfouls.Name = "lblmfouls"
        Me.lblmfouls.Size = New System.Drawing.Size(55, 13)
        Me.lblmfouls.TabIndex = 30
        Me.lblmfouls.Text = "MostFouls"
        '
        'lbltotalp
        '
        Me.lbltotalp.AutoSize = True
        Me.lbltotalp.Location = New System.Drawing.Point(712, 574)
        Me.lbltotalp.Name = "lbltotalp"
        Me.lbltotalp.Size = New System.Drawing.Size(60, 13)
        Me.lbltotalp.TabIndex = 31
        Me.lbltotalp.Text = "TotalPoints"
        '
        'lblTotalFoul
        '
        Me.lblTotalFoul.AutoSize = True
        Me.lblTotalFoul.Location = New System.Drawing.Point(712, 623)
        Me.lblTotalFoul.Name = "lblTotalFoul"
        Me.lblTotalFoul.Size = New System.Drawing.Size(56, 13)
        Me.lblTotalFoul.TabIndex = 32
        Me.lblTotalFoul.Text = "TotalFouls"
        '
        'frmCityHoops1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 699)
        Me.Controls.Add(Me.lblTotalFoul)
        Me.Controls.Add(Me.lbltotalp)
        Me.Controls.Add(Me.lblmfouls)
        Me.Controls.Add(Me.lblmpoints)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblGrandFoul)
        Me.Controls.Add(Me.lblGrandPoint)
        Me.Controls.Add(Me.lblHighestFouls)
        Me.Controls.Add(Me.lblHighestPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtPointsScored)
        Me.Controls.Add(Me.TxtNumberOfFouls)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblPointsScored)
        Me.Controls.Add(Me.lblNumberOfFouls)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbxGender)
        Me.Controls.Add(Me.lbxPointsScored)
        Me.Controls.Add(Me.lbxNumberOfFouls)
        Me.Controls.Add(Me.lbxName)
        Me.Name = "frmCityHoops1"
        Me.Text = "CityHoops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxName As ListBox
    Friend WithEvents lbxNumberOfFouls As ListBox
    Friend WithEvents lbxPointsScored As ListBox
    Friend WithEvents lbxGender As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblNumberOfFouls As Label
    Friend WithEvents lblPointsScored As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents TxtNumberOfFouls As TextBox
    Friend WithEvents txtPointsScored As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblHighestPoints As Label
    Friend WithEvents lblHighestFouls As Label
    Friend WithEvents lblGrandPoint As Label
    Friend WithEvents lblGrandFoul As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblmpoints As Label
    Friend WithEvents lblmfouls As Label
    Friend WithEvents lbltotalp As Label
    Friend WithEvents lblTotalFoul As Label
End Class
