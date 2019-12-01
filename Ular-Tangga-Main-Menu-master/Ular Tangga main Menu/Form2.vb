Public Class FormPlay
    Dim X(10, 10) As Button
    Dim Y(1) As Integer
    Dim Z(3) As Button
    Dim P(5, 1) As Integer
    Dim A As Integer
    Dim B As Integer = 0
    Dim C As Integer
    Dim D As Integer = 1
    Dim Rnd As New Random
    Dim F As String
    Dim G(5) As Integer
    Dim H As Integer = 0
    Dim Q(5) As Integer
    Private Sub FormPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            P(i, 0) = Rnd.Next(20, 98)
            For j = 0 To i - 1
                While P(i, 0) = P(j, 0)
                    P(i, 0) = Rnd.Next(20, 98)
                End While
            Next
            P(i, 1) = Rnd.Next(2, 90)
            While P(i, 1) >= P(i, 0)
                P(i, 1) = Rnd.Next(2, 90)
            End While
        Next
        For i = 0 To 3
            Z(i) = New Button
            Z(i).Height = 20
            Z(i).Width = 20
            If i = 0 Then
                Z(i).BackColor = Color.Red
                Z(i).Left = 0
                Z(i).Top = 360
            ElseIf i = 1 Then
                Z(i).BackColor = Color.Blue
                Z(i).Left = 20
                Z(i).Top = 360
            ElseIf i = 2 Then
                Z(i).BackColor = Color.Black
                Z(i).Left = 0
                Z(i).Top = 380
            ElseIf i = 3 Then
                Z(i).BackColor = Color.Brown
                Z(i).Left = 20
                Z(i).Top = 380
            End If
            Me.Controls.Add(Z(i))
        Next
        For i = 0 To 9
            For j = 0 To 9
                X(i, j) = New Button
                X(i, j).Height = 40
                X(i, j).Width = 40
                X(i, j).Top = 400 - (i + 1) * 40
                If i Mod 2 = 0 Then
                    X(i, j).Left = 40 * j
                Else
                    X(i, j).Left = 400 - (j + 1) * 40
                End If
                B = B + 1
                X(i, j).Text = B
                X(i, j).Name = "X(" & B & ")"
                If B = P(0, 0) Or B = P(1, 0) Or B = P(2, 0) Or B = P(3, 0) Or B = P(4, 0) Or B = P(5, 0) Then
                    X(i, j).BackColor = Color.Red
                ElseIf B = P(0, 1) Or B = P(1, 1) Or B = P(2, 1) Or B = P(3, 1) Or B = P(4, 1) Or B = P(5, 1) Then
                    X(i, j).BackColor = Color.Blue
                    G(H) = X(i, j).Left
                    Q(H) = X(i, j).Top
                    H = H + 1
                End If
                Me.Controls.Add(X(i, j))
            Next
        Next
    End Sub

    Private Sub BtnDadu_Click(sender As Object, e As EventArgs) Handles BtnDadu.Click
        Tm1.Enabled = True
        A = Rnd.Next(1, 7)
        LbDadu.Text = A
        C = 0
        BtnDadu.Enabled = False
        AddHandler Tm1.Tick, AddressOf Main
    End Sub
    Sub Main(ByVal sender As Object, ByVal e As EventArgs)
        If C < A Then
            If D Mod 10 = 0 Then
                Z(1).Top = Z(1).Top - 40
            ElseIf D > 10 And D < 20 Or D > 30 And D < 40 Or D > 50 And D < 60 Or D > 70 And D < 80 Or D > 90 And D < 100 Then
                Z(1).Left = Z(1).Left - 40
            Else
                Z(1).Left = Z(1).Left + 40
            End If
            D = D + 1
            C = C + 1
            'MsgBox(Z(1).Left.ToString)
        Else
            For i = 0 To 5
                If D = P(i, 0) Then
                    Z(1).Location = New Point(G(i) + 20, Q(i))
                End If
            Next
            Tm1.Enabled = False
            BtnDadu.Enabled = True
        End If
    End Sub
    Private Sub BtnCheat_Click(sender As Object, e As EventArgs) Handles BtnCheat.Click
        Tm1.Enabled = True
        A = TbCheat.Text
        C = 0
        AddHandler Tm1.Tick, AddressOf Main
    End Sub
End Class