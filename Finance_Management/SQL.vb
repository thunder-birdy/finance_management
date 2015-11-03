Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Imports Finance_Management.Definition

Module SQL
    Function Initial_Database(Optional DatabaseType As DatabaseType = DatabaseType.SQLite) As Boolean
        If DatabaseType = DatabaseType.SQLite Then          '当选择SQLite数据库时

        ElseIf DatabaseType = DatabaseType.MySQL            '当选择MySQL数据库时

        End If
        Return 0
    End Function
End Module
