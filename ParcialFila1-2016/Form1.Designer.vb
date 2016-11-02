<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLadoA = New System.Windows.Forms.TextBox()
        Me.txtLadoB = New System.Windows.Forms.TextBox()
        Me.txtLadoC = New System.Windows.Forms.TextBox()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.btnFiguras = New System.Windows.Forms.Button()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLado = New System.Windows.Forms.TextBox()
        Me.btnRegistros = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lado A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lado B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lado C"
        '
        'txtLadoA
        '
        Me.txtLadoA.Location = New System.Drawing.Point(386, 28)
        Me.txtLadoA.Name = "txtLadoA"
        Me.txtLadoA.Size = New System.Drawing.Size(100, 20)
        Me.txtLadoA.TabIndex = 4
        '
        'txtLadoB
        '
        Me.txtLadoB.Location = New System.Drawing.Point(386, 69)
        Me.txtLadoB.Name = "txtLadoB"
        Me.txtLadoB.Size = New System.Drawing.Size(100, 20)
        Me.txtLadoB.TabIndex = 5
        '
        'txtLadoC
        '
        Me.txtLadoC.Location = New System.Drawing.Point(386, 107)
        Me.txtLadoC.Name = "txtLadoC"
        Me.txtLadoC.Size = New System.Drawing.Size(100, 20)
        Me.txtLadoC.TabIndex = 6
        '
        'btnTriangulo
        '
        Me.btnTriangulo.Location = New System.Drawing.Point(323, 179)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(163, 23)
        Me.btnTriangulo.TabIndex = 8
        Me.btnTriangulo.Text = " Area y Perimetro del Triangulo"
        Me.btnTriangulo.UseVisualStyleBackColor = True
        '
        'btnFiguras
        '
        Me.btnFiguras.Location = New System.Drawing.Point(62, 179)
        Me.btnFiguras.Name = "btnFiguras"
        Me.btnFiguras.Size = New System.Drawing.Size(163, 23)
        Me.btnFiguras.TabIndex = 7
        Me.btnFiguras.Text = "Area y Perimetros de la Fifuras"
        Me.btnFiguras.UseVisualStyleBackColor = True
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(125, 107)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 3
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(125, 69)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 20)
        Me.txtBase.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Altura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Base"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Lado"
        '
        'txtLado
        '
        Me.txtLado.Location = New System.Drawing.Point(125, 28)
        Me.txtLado.Name = "txtLado"
        Me.txtLado.Size = New System.Drawing.Size(100, 20)
        Me.txtLado.TabIndex = 1
        '
        'btnRegistros
        '
        Me.btnRegistros.Location = New System.Drawing.Point(62, 233)
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Size = New System.Drawing.Size(163, 23)
        Me.btnRegistros.TabIndex = 21
        Me.btnRegistros.Text = "Ver Registros"
        Me.btnRegistros.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(323, 233)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(163, 23)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 286)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistros)
        Me.Controls.Add(Me.txtLado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnFiguras)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.txtLadoC)
        Me.Controls.Add(Me.txtLadoB)
        Me.Controls.Add(Me.txtLadoA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLadoA As TextBox
    Friend WithEvents txtLadoB As TextBox
    Friend WithEvents txtLadoC As TextBox
    Friend WithEvents btnTriangulo As Button
    Friend WithEvents btnFiguras As Button
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLado As TextBox
    Friend WithEvents btnRegistros As Button
    Friend WithEvents btnSalir As Button
End Class
