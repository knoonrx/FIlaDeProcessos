Public Class Processo

    Public id 'ID
    Public tempo As Integer 'Tamanho (burst time)
    Public prioridade As Integer 'Prioridade
    Private status As String 'Estado (Pronto e Rodando)
    Public nome As String 'Nome do processo, para melhor identificação visual

    Public Sub New(id As Integer, tempo As Integer, nome As String, prioridade As Integer, status As String)
        Me.id = id
        Me.tempo = tempo
        Me.nome = nome
        Me.prioridade = prioridade
        Me.status = status
    End Sub

End Class
