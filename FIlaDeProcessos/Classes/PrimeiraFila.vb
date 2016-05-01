Public Class PrimeiraFila

    Public Shared Sub primeiro(listaExibicao As ListView, fila As List(Of Processo), quantum As Integer, numerador As Integer)

        'Dim process = (From currentProcess In fila).FirstOrDefault()

        Dim process = (From currentProcess In fila Order By currentProcess.prioridade Descending).FirstOrDefault 'pego o processo de maior prioridade :)

        Dim filaAnterior As List(Of Processo)
        Dim listaSaida As ListView
        Dim filaPosterior As List(Of Processo)
        Dim listaEntrada As ListView
        Dim destino As String = ""
        Dim atual As String = ""

        Select Case numerador
            Case 1
                filaPosterior = Fila2
                listaEntrada = Form1.listSaida2
                destino = "2"
                atual = "1"
            Case 2
                filaPosterior = Fila3
                listaEntrada = Form1.listSaida3
                destino = "3"
                atual = "2"
            Case 3
                filaPosterior = Fila4
                listaEntrada = Form1.listSaida4
                destino = "4"
                atual = "3"
            Case 4
                filaPosterior = Fila5
                listaEntrada = Form1.listSaida5
                destino = "5"
                atual = "4"
            Case 5
                filaPosterior = Fila4
                listaEntrada = Form1.listSaida4
                destino = "4"
                atual = "5"
            Case Else
                filaPosterior = Nothing
                listaEntrada = Nothing
        End Select

        Select Case numerador
            Case 2
                filaAnterior = Fila1
                listaSaida = Form1.listSaida1
                destino = "1"
                atual = "2"
            Case 3
                filaAnterior = Fila2
                listaSaida = Form1.listSaida2
                destino = "2"
                atual = "3"
            Case 4
                filaAnterior = Fila3
                listaSaida = Form1.listSaida3
                destino = "3"
                atual = "4"
            Case 5
                filaAnterior = Fila4
                listaSaida = Form1.listSaida4
                destino = "4"
                atual = "5"
            Case Else
                filaAnterior = Nothing
                listaSaida = Nothing
        End Select

        If process IsNot Nothing Then
            Form1.lblCurrent.Text = ("Fila Atual: " & numerador & vbCrLf &
                                     "PID: " & process.id & vbCrLf &
                                     "Nome: " & process.nome & vbCrLf &
                                     "Tempo: " & process.tempo & vbCrLf &
                                     "Prioridade: " & process.prioridade) 'mostra qual é o proceso atual
            process.tempo = process.tempo - quantum
            listaExibicao.Items.Add(process.id).SubItems.AddRange((New String() {process.nome, process.tempo, process.prioridade})) 'coloca o processo no final da lista.
            listaExibicao.Items.RemoveAt(0) 'removo o primeiro item da lista
            listaExibicao.Items.Clear() 'limpo a lista

            If process.tempo <= 0 Then
                Form1.listLog.Items.Add(process.id).SubItems.AddRange((New String() {process.nome, process.tempo, process.prioridade})) 'joga o processo finalizado para a lista de log
                Form1.txtTrocandoFila.Text = "O processo " & process.nome & " terminou."
                If filaAnterior IsNot Nothing Then
                    limparLista(listaSaida, filaAnterior)
                End If
            ElseIf process.tempo > (2 * quantum) And Not numerador = 5 Then
                filaPosterior.Add(New Processo(process.id, process.tempo, process.nome, process.prioridade, "")) 'seu processo você é muito grande para esta fila, sai daqui e vai pra outra --'
                If numerador = 4 Then
                    Form1.txtTrocandoFila.Text = "O processo " & process.nome & " foi para a fila 5."
                Else
                    Form1.txtTrocandoFila.Text = "O processo " & process.nome & " foi para a fila " & destino & "."
                End If
                limparLista(listaEntrada, filaPosterior)
            ElseIf process.tempo < quantum Then
                filaAnterior.Add(New Processo(process.id, process.tempo, process.nome, process.prioridade, "")) 'seu processo você é muito pequeno para esta fila, sai daqui e vai pra outra --'
                Form1.txtTrocandoFila.Text = "O processo " & process.nome & " foi para a fila " & destino & "."
                limparLista(listaSaida, filaAnterior)
            ElseIf process.tempo > 0 Then
                fila.Add(New Processo(process.id, process.tempo, process.nome, process.prioridade, "")) 'coloco o primeiro item no final da fila já com o quantum subtraido ...
                Form1.txtTrocandoFila.Text = "O processo " & process.nome & "  continua na fila " & atual & "."
                limparLista(listaEntrada, filaPosterior)
            End If

            fila.Remove(process) 'e removo o processo

            Dim processos = From currentProcess In fila 'agora releio a fila toda já modificada :)
                            Order By currentProcess.prioridade Descending 'claro na ordem descendente ordenado por prioridade

            For i = 0 To processos.Count - 1 Step 1
                listaExibicao.Items.Add(processos(i).id).SubItems.AddRange((New String() {processos(i).nome, processos(i).tempo, processos(i).prioridade}))
            Next

        ElseIf fila.Count <= 0 Then 'terminou a lista está vazia é hora de dar tchau :)
            listaExibicao.Items.Clear()
            Form1.txtTrocandoFila.Text = ""
            Return
        End If

    End Sub

    Private Shared Sub limparLista(lista As ListView, fila As List(Of Processo))
        lista.Items.Clear() 'vamos limpar e reler a lista...

        Dim order = From item In fila Order By item.prioridade Descending 'ordenado por prioridade

        For Each item In order
            lista.Items.Add(item.id).SubItems.AddRange(New String() {item.nome, item.tempo, item.prioridade})
        Next
    End Sub
End Class
