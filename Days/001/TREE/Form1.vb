Public Class Form1
    Dim TreeHeight As Integer
    Dim time As Decimal
    Dim wait

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TreeHeight = 20
        Me.Show()
        time = 1000 * 0.5

        Tree()
    End Sub

    Sub Tree()
        Dim TxtNumber As Integer
        Dim CurrentTreeHeight As Integer
        Dim Characters As String
        Dim INTCHAR = "/\"
        INTCHAR = InputBox("Please type the character you would like to generate the tree from")
        Characters = INTCHAR
        TreeHeight = 18
        TreeHeight = InputBox("Please type how many layers you would like your tree to have")
        CurrentTreeHeight = 1
        TxtNumber = 0
        RichTextBox1.Text = ""
        While CurrentTreeHeight <= TreeHeight

            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
            If CurrentTreeHeight <= 1 Then
                RichTextBox1.SelectionColor = Color.Green
                RichTextBox1.SelectedText = (RichTextBox1.SelectedText + Characters + vbCrLf)
                CurrentTreeHeight = CurrentTreeHeight + 1
                Characters = INTCHAR + INTCHAR
            Else
                RichTextBox1.SelectionColor = Color.Green
                RichTextBox1.SelectedText = (RichTextBox1.SelectedText + Characters + vbCrLf)
                CurrentTreeHeight = CurrentTreeHeight + 1
                Characters = Characters + INTCHAR + INTCHAR
            End If


        End While

        For index As Integer = 1 To 3
            RichTextBox1.SelectionColor = Color.Brown
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
            RichTextBox1.SelectedText = (RichTextBox1.SelectedText + INTCHAR + INTCHAR + vbCrLf)
        Next

        For index As Integer = 1 To 3
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
            RichTextBox1.SelectedText = (RichTextBox1.SelectedText + INTCHAR + INTCHAR + INTCHAR + INTCHAR + vbCrLf)
        Next
        TreeHeight = TreeHeight + 1
    End Sub


    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Tree()
    End Sub

End Class
