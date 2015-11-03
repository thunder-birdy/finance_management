Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Imports Finance_Management.Definition

Module SQL
    Function Initial_Database(Optional DatabaseType As DatabaseType = DatabaseType.SQLite)
        If DatabaseType = DatabaseType.SQLite Then

        End If
        Return 0
    End Function
End Module
