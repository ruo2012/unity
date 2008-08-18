﻿'===============================================================================
' Microsoft patterns & practices
' Unity Application Block
'===============================================================================
' Copyright © Microsoft Corporation.  All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
' FITNESS FOR A PARTICULAR PURPOSE.
'===============================================================================

Imports StopLight.ServiceInterfaces

Namespace StopLightTests.TestDoubles
	Friend Class MockLogger
		Implements ILogger
    Private lastMsg As String

    Public Property LastMessage() As String
      Get
        Return lastMsg
      End Get
      Private Set(ByVal value As String)
        lastMsg = value
      End Set
    End Property

#Region "ILogger Members"

    Public Sub Write(ByVal message As String) Implements ILogger.Write
      LastMessage = message
    End Sub

#End Region

  End Class
End Namespace


