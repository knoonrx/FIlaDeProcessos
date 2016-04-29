Imports System.Threading
Public Class Form1
    Private conta = 0
    Private Sub btnNovoProcesso_Click(sender As Object, e As EventArgs) Handles btnNovoProcesso.Click
        If (txtTempo.Text IsNot "" And txtNome.Text IsNot "" And txtPrioridade.Text IsNot "") Then
            FilaInicio.Add(New Processo(conta, txtTempo.Text, txtNome.Text, txtPrioridade.Text, ""))
            conta += 1
            reloadList()
        Else
            MsgBox("Por favor, preencha o formulário")
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs)
        reloadList()
    End Sub
    Public Sub reloadList()
        listProcess.Items.Clear()
        For Each processo In FilaInicio
            listProcess.Items.Add(processo.id).SubItems.AddRange(New String() {processo.nome, processo.tempo, processo.prioridade})
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAutoCriarProcesso.Click
        ToolStripStatusLabel2.Text = "Dependendo da quantidade de processos criados o sistema pode parar de responder por alguns momentos"
        Dim Conta2 As Integer
        If (txtAutoProcessNome.Text IsNot "" And txtAutoQuantidade.Text IsNot "" And txtAutoMaxTempo.Text IsNot "" And criado = False) Then
            listLog.Items.Clear()
            For k = 0 To Convert.ToInt32(txtAutoQuantidade.Text) Step 1
                Conta2 = conta
                conta += 1
                FilaInicio.Add(New Processo(Conta2, RandomNumber(Convert.ToInt32(txtAutoMaxTempo.Text)), txtAutoProcessNome.Text & conta, RandomNumber(20), "")) 'cria os processos de forma randomica
                reloadList()
            Next
            criado = True
        ElseIf criado = True Then
            MsgBox("A fila já foi preechida automaticamente uma vez, você ainda pode adicionar processos manualmente. o.O")
        Else
            MsgBox("Por favor, preencha o formulário")
        End If
    End Sub

    Public Function RandomNumber(ByVal n As Integer) As Integer
        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)
        Return r.Next(1, n)
    End Function
    Public Function atraso() As Integer
        If rAtraso1.Checked = True Then
            Return 1000
        ElseIf rAtraso2.Checked = True Then
            Return 2000
        ElseIf rAtraso3.Checked = True Then
            Return 3000
        ElseIf rFast.Checked = True Then
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = "Bem vindo ao simulador de processo ProcesSIM"
    End Sub

    Public Sub distribuir()
        Dim c1 = 0
        Dim c2 = 0
        Dim c3 = 0
        Dim c4 = 0
        Dim c5 = 0
        Dim processos = From item In FilaInicio
                        Order By item.prioridade Descending 'Or item.id Descending 'uso a sintax linq (sql) para ordenar os processos de acordo com a prioridade e ID

        For i = 0 To processos.Count - 1 Step 1
            If processos(i) IsNot Nothing Then 'verifica se o objeto atual existe ou não

                If processos(i).prioridade <= 2 Then 'aqui eu começo a distribuir os processos, cada um para uma fila com um quantum mais adequado
                    listSaida1.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade}) 'carrego a lista de exibição
                    Fila1.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, "")) 'carrego a lista de dados
                    c1 += 1
                ElseIf processos(i).prioridade > 2 And processos(i).prioridade <= 5 Then
                    listSaida2.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila2.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                    c2 += 1
                ElseIf processos(i).prioridade > 5 And processos(i).prioridade <= 8 Then
                    listSaida3.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila3.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                    c3 += 1
                ElseIf processos(i).prioridade > 8 And processos(i).prioridade <= 11 Then
                    listSaida4.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila4.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                    c4 += 1
                Else
                    listSaida5.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila5.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                    c5 += 1
                End If

            End If
        Next

    End Sub

    Private Sub btnDecisao_Click(sender As Object, e As EventArgs) Handles btnDistribui.Click
        distribuir()
    End Sub

    Private Sub btnTestefila1_Click(sender As Object, e As EventArgs) Handles btnTestefila1.Click
        PrimeiraFila.primeiro(listSaida1, Fila1, 1, 1)
    End Sub

    Private Sub btnTestefila2_Click(sender As Object, e As EventArgs) Handles btnTestefila2.Click
        PrimeiraFila.primeiro(listSaida2, Fila2, 4, 2)
    End Sub

    Private Sub btnTestefila3_Click(sender As Object, e As EventArgs) Handles btnTestefila3.Click
        PrimeiraFila.primeiro(listSaida3, Fila3, 7, 3)
    End Sub

    Private Sub btnTestefila4_Click(sender As Object, e As EventArgs) Handles btnTestefila4.Click
        PrimeiraFila.primeiro(listSaida4, Fila4, 10, 4)
    End Sub

    Private Sub btnTestefila5_Click(sender As Object, e As EventArgs) Handles btnTestefila5.Click
        PrimeiraFila.primeiro(listSaida5, Fila5, 15, 5)
    End Sub

    Private Async Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If chkAutoAll.Checked = True Then
            Do While Fila1.Count > 0 Or Fila2.Count > 0 Or Fila3.Count > 0 Or Fila4.Count > 0 Or Fila5.Count > 0

                If Fila1.Count > 0 Then
                    PrimeiraFila.primeiro(listSaida1, Fila1, 1, 1)
                    Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                End If
                If Fila2.Count > 0 Then
                    PrimeiraFila.primeiro(listSaida2, Fila2, 4, 2)
                    Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                End If
                If Fila3.Count > 0 Then
                    PrimeiraFila.primeiro(listSaida3, Fila3, 7, 3)
                    Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                End If
                If Fila4.Count > 0 Then
                    PrimeiraFila.primeiro(listSaida4, Fila4, 10, 4)
                    Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                End If
                If Fila5.Count > 0 Then
                    PrimeiraFila.primeiro(listSaida5, Fila5, 15, 5)
                    Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                End If

            Loop
            chkAutoAll.Checked = False
            ToolStripStatusLabel2.Text = "Todos os processos foram finalizados" 'tchau :)
        Else
            If Fila1.Count > 0 Then
                PrimeiraFila.primeiro(listSaida1, Fila1, 1, 1)
                Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
            End If
            If Fila2.Count > 0 Then
                PrimeiraFila.primeiro(listSaida2, Fila2, 4, 2)
                Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
            End If
            If Fila3.Count > 0 Then
                PrimeiraFila.primeiro(listSaida3, Fila3, 7, 3)
                Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
            End If
            If Fila4.Count > 0 Then
                PrimeiraFila.primeiro(listSaida4, Fila4, 10, 4)
                Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
            End If
            If Fila5.Count > 0 Then
                PrimeiraFila.primeiro(listSaida5, Fila5, 15, 5)
                Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
            End If
        End If
    End Sub

End Class
