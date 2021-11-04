<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DxfDocument2 As DXFReaderNET.DxfDocument = New DXFReaderNET.DxfDocument()
        Dim AciColor2 As DXFReaderNET.AciColor = New DXFReaderNET.AciColor()
        Dim RasterVariables2 As DXFReaderNET.Objects.RasterVariables = New DXFReaderNET.Objects.RasterVariables()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button()
        Me.DxfReaderNETControl1 = New DXFReaderNET.DXFReaderNETControl()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(174, 20)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Add line"
        Me.button1.UseVisualStyleBackColor = True
        '
        'DxfReaderNETControl1
        '
        Me.DxfReaderNETControl1.AutoSize = True
        Me.DxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None
        DxfDocument2.ActiveLayout = "Model"
        DxfDocument2.Comments = Nothing
        AciColor2.Index = CType(256, Short)
        AciColor2.IsByBlock = False
        AciColor2.IsByLayer = True
        AciColor2.UseTrueColor = False
        DxfDocument2.CurrentColor = AciColor2
        DxfDocument2.CurrentElevation = 0R
        DxfDocument2.CurrentLayer = "0"
        DxfDocument2.CurrentLineTypeName = "ByLayer"
        DxfDocument2.CurrentLineTypeScale = 1.0R
        DxfDocument2.CurrentTextSize = 2.5R
        DxfDocument2.CurrentTextStyle = "STANDARD"
        DxfDocument2.CurrentThickness = 0R
        DxfDocument2.DateCreated = New Date(2020, 1, 29, 10, 2, 41, 612)
        DxfDocument2.DateLastEdited = New Date(2020, 1, 29, 10, 2, 41, 612)
        DxfDocument2.Handle = "0"
        DxfDocument2.IsBinary = False
        DxfDocument2.Modified = False
        DxfDocument2.Name = Nothing
        DxfDocument2.Owner = Nothing
        RasterVariables2.DisplayFrame = True
        RasterVariables2.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High
        RasterVariables2.Handle = "2D"
        RasterVariables2.Owner = Nothing
        RasterVariables2.Units = DXFReaderNET.ImageUnits.Unitless
        DxfDocument2.RasterVariables = RasterVariables2
        DxfDocument2.ThumbnailImage = Nothing
        DxfDocument2.TotalEditTime = New Date(2020, 1, 29, 0, 0, 0, 0)
        DxfDocument2.TotalEditTimeDays = 0
        DxfDocument2.UserTimer = New Date(2020, 1, 29, 0, 0, 0, 0)
        DxfDocument2.UserTimerDays = 0
        Me.DxfReaderNETControl1.DXF = DxfDocument2
        Me.DxfReaderNETControl1.FileName = Nothing
        Me.DxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta
        Me.DxfReaderNETControl1.Location = New System.Drawing.Point(12, 38)
        Me.DxfReaderNETControl1.Name = "DxfReaderNETControl1"
        Me.DxfReaderNETControl1.ShowGrid = True
        Me.DxfReaderNETControl1.ShowGridRuler = False
        Me.DxfReaderNETControl1.Size = New System.Drawing.Size(776, 400)
        Me.DxfReaderNETControl1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DxfReaderNETControl1)
        Me.Controls.Add(Me.button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DXFReader.NET Component - ShowRubberBand Sample "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Friend WithEvents DxfReaderNETControl1 As DXFReaderNET.DXFReaderNETControl
End Class
