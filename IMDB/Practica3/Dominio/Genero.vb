﻿Public Class Genero

    Private idGenero As Integer
    Private descripcion As String

    Public Sub New()

    End Sub

    Public Sub New(descripcion As String)
        Me.descripcion = descripcion
    End Sub

    Public Property _idGenero As Integer
        Get
            Return Me.idGenero
        End Get
        Set(value As Integer)
            Me.idGenero = value
        End Set
    End Property

    Public Property _descripcion As String
        Get
            Return Me.descripcion
        End Get
        Set(value As String)
            Me.descripcion = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return descripcion
    End Function

    Public Sub eliminar(g)
        g.delete(Me)
    End Sub

    Public Sub insertar(g)
        g.insert(Me)
    End Sub

    Public Sub leerGenero(ByVal titulo, g)
        g.read(Me)
    End Sub

    Public Sub leerTodos(g)
        g.readAll()
    End Sub

    Public Sub modificar(g)
        g.update(Me)
    End Sub

End Class
