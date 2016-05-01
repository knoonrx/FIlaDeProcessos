Imports System.Threading
Public Class Form1

    Private conta = 1
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

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAutoCriarProcesso.Click
        ToolStripStatusLabel2.Text = "Dependendo da quantidade de processos criados o sistema pode parar de responder por alguns momentos"

        Dim processoTempo As Integer

        If (txtAutoProcessNome.Text IsNot "" And txtAutoQuantidade.Text IsNot "" And txtAutoMaxTempo.Text IsNot "" And criado = False) Then
            listLog.Items.Clear()
            For k = 0 To Convert.ToInt32(txtAutoQuantidade.Text) - 1 Step 1
                Dim i = 0

                'esse looping é uma forma de atrazar a execução permitindo que o intervalo entre o número randomico gerado entre
                'o Tempo do processo e a prioridade sejam diferentes. não é muito elegante mas funciona :)
                While i < 1
                    processoTempo = RandomNumber(Convert.ToInt32(txtAutoMaxTempo.Text + 1)) 'com base no valor escolhido vamos gerar de forma randômica o tempo dos processos.
                    i += 1
                    Await Task.Delay(10) 'atrasa o programa de acordo com valor selecionado
                End While

                Await Task.Delay(10) 'atrasa o programa de acordo com valor selecionado
                FilaInicio.Add(New Processo(conta, processoTempo, txtAutoProcessNome.Text & conta, RandomNumber(21), "")) 'cria os processos de forma randomica
                conta += 1
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
        Dim r As Random = New Random 'initialize random number generator
        Return r.Next(1, n)
    End Function

    Public Function atraso() As Integer 'função que retorna o tempo de espera entre a execução de um processo e outro
        If rAtraso1.Checked = True Then
            Return 1000
        ElseIf rAtraso2.Checked = True Then
            Return 2000
        ElseIf rAtraso3.Checked = True Then
            Return 3000
        ElseIf rFast.Checked = True Then
            Return 10
        Else
            Return 10
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = "Bem vindo ao simulador de processo ProcesSIM"
    End Sub

    Public Sub distribuir()

        Dim processos = From item In FilaInicio
                        Order By item.prioridade Descending 'uso a sintax linq (sql) para ordenar os processos de acordo com a prioridade e ID

        For i = 0 To processos.Count - 1 Step 1
            If processos(i) IsNot Nothing Then 'verifica se o objeto atual existe ou não

                If processos(i).tempo <= 2 Then 'aqui eu começo a distribuir os processos, cada um para uma fila com um quantum mais adequado
                    listSaida1.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade}) 'carrego a lista de exibição
                    Fila1.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, "")) 'carrego a lista de dados
                ElseIf processos(i).tempo > 2 And processos(i).tempo <= 5 Then
                    listSaida2.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila2.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                ElseIf processos(i).tempo > 5 And processos(i).tempo <= 8 Then
                    listSaida3.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila3.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                ElseIf processos(i).tempo > 8 And processos(i).tempo <= 11 Then
                    listSaida4.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila4.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
                Else
                    listSaida5.Items.Add(processos(i).id).SubItems.AddRange(New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade})
                    Fila5.Add(New Processo(processos(i).id, processos(i).tempo, processos(i).nome, processos(i).prioridade, ""))
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
        If (chkAutoAll.Checked = True) Then

            Do While Fila1.Count > 0 Or Fila2.Count > 0 Or Fila3.Count > 0 Or Fila4.Count > 0 Or Fila5.Count > 0
                Select Case maiorProcesso()
                    Case 1
                        If Fila1.Count > 0 Then
                            PrimeiraFila.primeiro(listSaida1, Fila1, 1, 1)
                            Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                        End If
                    Case 2
                        If Fila2.Count > 0 Then
                            PrimeiraFila.primeiro(listSaida2, Fila2, 4, 2)
                            Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                        End If
                    Case 3
                        If Fila3.Count > 0 Then
                            PrimeiraFila.primeiro(listSaida3, Fila3, 7, 3)
                            Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                        End If
                    Case 4
                        If Fila4.Count > 0 Then
                            PrimeiraFila.primeiro(listSaida4, Fila4, 10, 4)
                            Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                        End If
                    Case 5
                        If Fila5.Count > 0 Then
                            PrimeiraFila.primeiro(listSaida5, Fila5, 15, 5)
                            Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                        End If
                End Select
            Loop
            ' chkAutoAll.Checked = False
            ToolStripStatusLabel2.Text = "Todos os processos foram finalizados" 'tchau :)
        End If

        If (chkAutoAll.Checked = False) Then
            Select Case maiorProcesso()
                Case 1
                    If Fila1.Count > 0 Then
                        PrimeiraFila.primeiro(listSaida1, Fila1, 1, 1)
                        Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                    End If
                Case 2
                    If Fila2.Count > 0 Then
                        PrimeiraFila.primeiro(listSaida2, Fila2, 4, 2)
                        Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                    End If
                Case 3
                    If Fila3.Count > 0 Then
                        PrimeiraFila.primeiro(listSaida3, Fila3, 7, 3)
                        Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                    End If
                Case 4
                    If Fila4.Count > 0 Then
                        PrimeiraFila.primeiro(listSaida4, Fila4, 10, 4)
                        Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                    End If
                Case 5
                    If Fila5.Count > 0 Then
                        PrimeiraFila.primeiro(listSaida5, Fila5, 15, 5)
                        Await Task.Delay(atraso()) 'atrasa o programa de acordo com valor selecionado
                    End If
            End Select
        End If
    End Sub

    Public Function maiorProcesso() As Integer

        Dim listTemporaria As New List(Of Tempo)() 'crio uma lista de processos temporária 

        'começo a enfileirar pelo primeiro processo da fila 5 até a fila 1 ou seja, da fila de maior quantum até a fila de menor.
        'Desse modo vai processar sempre os processo com maior Tempo primeiro, quando houverem dois processos em filas diferentes com prioridades igueis
        'criando dessa forma o critério de desempate.
        If Fila5.Count > 0 Then
            Dim process = (From currentProcess In Fila5 Order By currentProcess.prioridade Descending).FirstOrDefault
            listTemporaria.Add(New Tempo(5, process.prioridade)) 'adiciono o primeiro na lista temporária com o Número da Fila e o valor de sua prioridade (obj da class Tempo) ...
        End If
        If Fila4.Count > 0 Then
            Dim process = (From currentProcess In Fila4 Order By currentProcess.prioridade Descending).FirstOrDefault
            listTemporaria.Add(New Tempo(4, process.prioridade))
        End If
        If Fila3.Count > 0 Then
            Dim process = (From currentProcess In Fila3 Order By currentProcess.prioridade Descending).FirstOrDefault
            listTemporaria.Add(New Tempo(3, process.prioridade))
        End If
        If Fila2.Count > 0 Then
            Dim process = (From currentProcess In Fila2 Order By currentProcess.prioridade Descending).FirstOrDefault
            listTemporaria.Add(New Tempo(2, process.prioridade))
        End If
        If Fila1.Count > 0 Then
            Dim process = (From currentProcess In Fila1 Order By currentProcess.prioridade Descending).FirstOrDefault
            listTemporaria.Add(New Tempo(1, process.prioridade))
        End If

        If Fila1.Count > 0 Or Fila2.Count > 0 Or Fila3.Count > 0 Or Fila4.Count > 0 Or Fila5.Count > 0 Then 'Verifique se pelo menos uma das filas ainda não está vazia
            Dim ultima = From item In listTemporaria Order By item.prioridade Descending 'se não estão vazias eu ordeno a lista temporária por prioridade de forma Descendente... Do maior para o menor.
            Return ultima.FirstOrDefault().list 'e finalmente retorno o numero da fila que deverá ser processada
        Else
            Return 0 'se todas as filas estiverem vazias não faça nada.
        End If
    End Function

End Class
