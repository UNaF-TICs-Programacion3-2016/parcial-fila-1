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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdCargar = New System.Windows.Forms.Button()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.CmdMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Calculo De Area Y Perimetro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Lado C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Lado B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Lado A"
        '
        'CmdCargar
        '
        Me.CmdCargar.Location = New System.Drawing.Point(153, 192)
        Me.CmdCargar.Name = "CmdCargar"
        Me.CmdCargar.Size = New System.Drawing.Size(81, 37)
        Me.CmdCargar.TabIndex = 13
        Me.CmdCargar.Text = "Cargar Superficies"
        Me.CmdCargar.UseVisualStyleBackColor = True
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(134, 129)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(100, 20)
        Me.TxtC.TabIndex = 12
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(134, 103)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(100, 20)
        Me.TxtB.TabIndex = 11
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(134, 77)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(100, 20)
        Me.TxtA.TabIndex = 10
        '
        'CmdMostrar
        '
        Me.CmdMostrar.Location = New System.Drawing.Point(34, 192)
        Me.CmdMostrar.Name = "CmdMostrar"
        Me.CmdMostrar.Size = New System.Drawing.Size(75, 37)
        Me.CmdMostrar.TabIndex = 9
        Me.CmdMostrar.Text = "Mostrar Area Y Perimetro"
        Me.CmdMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdCargar)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.CmdMostrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdCargar As Button
    Friend WithEvents TxtC As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents TxtA As TextBox
    Friend WithEvents CmdMostrar As Button
End Class
