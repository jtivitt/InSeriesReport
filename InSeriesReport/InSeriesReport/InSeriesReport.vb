Public Class InSeriesReport
    'Private _partTypeID As Integer
    'Private _assemblyLine As Integer
    'Private _partLabel As String

    'Public Property PartTypeID() As Integer
    '    Get
    '        Return _partTypeID
    '    End Get
    '    Set(ByVal value As Integer)
    '        _partTypeID = value
    '    End Set
    'End Property
    'Public Property AssemblyLine() As Integer
    '    Get
    '        Return _assemblyLine
    '    End Get
    '    Set(ByVal value As Integer)
    '        _assemblyLine = value
    '    End Set
    'End Property
    'Public Property PartLabel() As String
    '    Get
    '        Return _partLabel
    '    End Get
    '    Set(ByVal value As String)
    '        _partLabel = value
    '    End Set
    'End Property
    'Private Sub CreatePartLabel()
    '    'CreatePartLabelForCommodity(12, 3, "MainHarness")
    '    'CreatePartLabelForCommodity(43, 4, "Alternators")
    '    'CreatePartLabelForCommodity(31, 3, "Main Wire Assy")
    '    'CreatePartLabelForCommodity(26, 3, "Consoles")
    '    'CreatePartLabelForCommodity(29, 3, "CabCorners")
    '    'CreatePartLabelForCommodity(33, 3, "LHDoorLooms")
    '    'CreatePartLabelForCommodity(32, 3, "RHDoorLooms")
    '    'CreatePartLabelForCommodity(42, 3, "LHMirrors")
    '    'CreatePartLabelForCommodity(41, 3, "RHMirrors")
    '    'CreatePartLabelForCommodity(45, 3, "RHDoorRegulators")
    '    'CreatePartLabelForCommodity(47, 3, "LHDoorRegulators")
    '    'CreatePartLabelForCommodity(44, 3, "RHSeatBelts")
    '    'CreatePartLabelForCommodity(48, 3, "LHSeatBelts")
    '    'CreatePartLabelForCommodity(36, 3, "RHDoorHandleFront")
    '    'CreatePartLabelForCommodity(37, 3, "LHDoorHandleFront")
    '    'CreatePartLabelForCommodity(38, 3, "RHDoorHandleRear")
    '    'CreatePartLabelForCommodity(39, 3, "LHDoorHandleRear")
    '    'CreatePartLabelForCommodity(40, 3, "SteeringColumnCovers")
    '    'CreatePartLabelForCommodity(13, 1, "RHWheelLips")
    '    'CreatePartLabelForCommodity(14, 1, "LHWheelLips")
    'End Sub
    'Private Sub CreatePartLabelForCommodity(ByVal _partType As Integer, ByVal _assemblyLine As Integer, ByVal _partLabel As String)
    '    Using sqlcon As New SqlClient.SqlConnection(My.Settings.InSeriesDB.ToString)
    '        Try
    '            sqlcon.Open()
    '            Dim cmd As New SqlClient.SqlCommand("dbo.usp_GetLogisticsStatusBoardInfo", sqlcon)
    '            Dim rd As SqlClient.SqlDataReader
    '            With cmd
    '                .CommandType = CommandType.StoredProcedure
    '                .Parameters.AddWithValue("@PartType", _partTypeID)
    '                .Parameters.AddWithValue("@AssemblyLine", _assemblyLine)
    '                rd = .ExecuteReader()

    '                If rd.Read Then

    '                End If
    '                rd.Close()

    '            End With
    '            cmd.Dispose()
    '            sqlcon.Close()

    '        Catch ex As Exception

    '        End Try
    '    End Using
    'End Sub

    Private Sub InseriesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectPartComboFill()
    End Sub
    Private Sub SelectPartComboFill()
        Using sqlcon As New SqlClient.SqlConnection(My.Settings.InSeriesDB.ToString)
            sqlcon.Open()
            Dim strSQL As String = "SELECT PartTypeID, PartType FROM tblPartType where PartTypeID >=12"
            Dim da As New SqlClient.SqlDataAdapter(strSQL, sqlcon)
            Dim ds As New DataSet

            da.Fill(ds)
            sqlcon.Close()

            SelectPartCombo.ValueMember = "PartTypeID"
            SelectPartCombo.DisplayMember = "PartType"
            SelectPartCombo.DataSource = ds.Tables(0)
        End Using
    End Sub
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SearchButton.Click
        Using sqlcon As New SqlClient.SqlConnection(My.Settings.InSeriesDB.ToString)

            sqlcon.Open()

            Dim sqlcmd As New SqlClient.SqlCommand("dbo.InSeriesReprint1", sqlcon)

            Dim SearchResultsDataAdapter As New SqlClient.SqlDataAdapter(sqlcmd)

            Dim SearchResultsDataSet As DataSet = New DataSet()

            With sqlcmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@PartTypeID", SelectPartCombo.SelectedValue.ToString)
                .Parameters.AddWithValue("@RotationNbrStart", RotationNbrStart.Text)
                .Parameters.AddWithValue("@RotationNbrEnd", RotationNbrEnd.Text)
                .Parameters.AddWithValue("@RackNbr", RackNbr.Text)
                .Parameters.AddWithValue("@RackID", RackID.Text)

                'If RotationNbrStart.Text.Trim() <> "" Then
                '    .Parameters.Add("@RotationNbrStart", SqlDbType.VarChar, 4).Value = RotationNbrStart.Text.Trim()
                'End If
                'If RotationNbrEnd.Text.Trim() <> "" Then
                '    .Parameters.Add("@RotationNbrEnd", SqlDbType.VarChar, 4).Value = RotationNbrEnd.Text.Trim()
                'End If
                'If RackID.Text.Trim() <> "" Then
                '    .Parameters.Add("@RackID", SqlDbType.VarChar, 10).Value = RackID.Text.Trim()
                'End If
                'If RackNbr.Text.Trim() <> "" Then
                '    .Parameters.Add("@RackNbr", SqlDbType.VarChar, 3).Value = RackNbr.Text.Trim()
                'End If
            End With

            SearchResultsDataAdapter.Fill(SearchResultsDataSet, "SearchResults")
            DataGridView1.DataSource = SearchResultsDataSet.Tables("SearchResults").DefaultView
            sqlcmd.Dispose()
            sqlcon.Close()
        End Using
    End Sub
End Class
