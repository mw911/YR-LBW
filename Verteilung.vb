Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.Serialization.Formatters.Binary


Public Class Verteilung
    Enum Months
        Januar = 1
        Februar = 2
        März = 3
        April = 4
        Mai = 5
        Juni = 6
        July = 7
        August = 8
        September = 9
        Oktober = 10
        November = 11
        Dezember = 12
    End Enum

    Dim days = {"Stunde", "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag"}
    Dim coll As New Dictionary(Of Months, List(Of Double()))
    Dim arrDS As Double(,) = New Double(13, 6) {}

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Verteilung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DataGridView1.SuspendLayout()
        Initialisieren()
        datum.Value = Now
        Exit Sub

        'Dim col As DataGridViewColumn
        'col = New DataGridViewTextBoxColumn With {
        '    .HeaderText = "Hour",
        '    .ValueType = GetType(Decimal)
        '}
        'Me.DataGridView1.Columns.Add(col)
        'Me.DataGridView1.Columns(0).DefaultCellStyle.Format = "#"
        'For Each day In days
        '    col = New DataGridViewTextBoxColumn With {
        '        .HeaderText = day,
        '        .ValueType = GetType(Decimal)
        '    }
        '    Dim i = Me.DataGridView1.Columns.Add(col)
        '    Me.DataGridView1.Columns(i).DefaultCellStyle.Format = "N2"
        'Next

    End Sub

    Sub Initialisieren()
        Dim list As New List(Of Double())

        Try
            coll = loadFromFile()
            Exit Sub
        Catch ex As Exception

        End Try


        list.Add({8, 0, 0, 0, 0, 0, 0})
        list.Add({9, 5.74, 3.2, 5.01, 5.27, 5.05, 3.95})
        list.Add({10, 9.29, 8.32, 8.02, 8.62, 7.49, 7.63})
        list.Add({11, 7.26, 9.81, 8.55, 9.51, 8.52, 9.45})
        list.Add({12, 10.7, 10.14, 9.58, 10.08, 9.23, 13.48})
        list.Add({13, 11.7, 12.45, 9.38, 9.28, 8.68, 11.91})
        list.Add({14, 11.25, 12.25, 10.99, 10.23, 11.01, 13.39})
        list.Add({15, 10.74, 9.49, 11.87, 11.86, 11.82, 15.34})
        list.Add({16, 11.65, 12.02, 11.22, 11.36, 12.36, 12.72})
        list.Add({17, 10.42, 11.48, 12.05, 11.13, 13.81, 11.12})
        list.Add({18, 8.88, 8.03, 10.63, 9.52, 9.39, 1.01})
        list.Add({19, 2.37, 2.81, 2.7, 3.14, 2.64, 0})
        list.Add({20, 0, 0, 0, 0, 0, 0})
        coll.Add(Months.März, list)
        coll.Add(Months.April, list)
        coll.Add(Months.Mai, list)
        coll.Add(Months.Juni, list)



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles datum.ValueChanged
        Me.DataGridView1.SuspendLayout()
        Dim monat = CType(datum.Value.Month, Months)
        Dim tag = datum.Value.DayOfWeek
        If Not coll.Keys.Contains(CType(datum.Value.Month, Months)) Then
            For i = 0 To 12
                For j = 1 To 6
                    arrDS(i, j) = 0
                Next
            Next

        Else
            Dim mmm = coll.Where(Function(x) x.Key = CType(datum.Value.Month, Months)).First.Value
            For i As Integer = 0 To mmm.Count() - 1
                For j As Integer = 0 To mmm(i).Count() - 1
                    arrDS(i, j) = mmm(i)(j)
                Next
            Next

        End If
        Me.DataGridView1.DataSource = New Mommo.Data.ArrayDataView(arrDS, days)
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ResumeLayout()
        Total2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim _VON = IIf(datum.Value.DayOfWeek = 6, vonSA.Value, von.Value)
            Dim _BIS = IIf(datum.Value.DayOfWeek = 6, bisSA.Value, bis.Value)

            Dim monat = CType(datum.Value.Month, Months)
            Dim tag = datum.Value.DayOfWeek
            Dim dtStart As New Date(datum.Value.Year, datum.Value.Month, datum.Value.Day, _VON.Hour, _VON.Minute, _VON.Second)
            Dim dtEnde As New Date(datum.Value.Year, datum.Value.Month, datum.Value.Day, _BIS.Hour, _BIS.Minute, _BIS.Second)
            Dim kumuliert As Decimal = 0.0

            Me.TextBox1.Text = ""
            Me.DataGridView2.Rows.Clear()

            Dim _zuVerteilenStart = getBeforeStart(monat, tag, dtStart) + getAnteilAusserhalb(getValue(monat, tag, dtStart), dtStart)
            Dim _zuVerteilenEndeDanach = getAnteilInnerhalb(getValue(monat, tag, dtEnde), dtEnde) + getAfterEnde(monat, tag, dtEnde.AddHours(0))
            Dim zuVerteilen = _zuVerteilenStart + _zuVerteilenEndeDanach

            Me.TextBox1.Text += $"TotalVerteilen: {Math.Round(zuVerteilen, 2)}{ControlChars.CrLf}{ControlChars.CrLf}"

            Me.TextBox1.Text += $"Vor Öffnung: {Math.Round(_zuVerteilenStart, 2)}{ControlChars.CrLf}"

            Dim _aktstart = getAnteilInnerhalb(getValue(monat, tag, dtStart), dtStart)
            Me.TextBox1.Text += $"Öffnung: {Math.Round(_aktstart, 2)}{ControlChars.CrLf}"

            kumuliert += getVal(_aktstart, zuVerteilen, ziel.Text)
            Me.DataGridView2.Rows.Add({dtStart.Hour, Math.Round(getVal(_aktstart, zuVerteilen, ziel.Text), 0), Math.Round(kumuliert, 0)})

            dtStart = dtStart.AddMinutes(-dtStart.Minute)
            While dtStart.AddMinutes(_VON.Minute).AddHours(1).Hour < dtEnde.Hour
                dtStart = dtStart.AddHours(1)
                Dim act = getValue(monat, tag, dtStart)
                Me.TextBox1.Text += $"{dtStart.Hour}: {Math.Round(act, 2)}{ControlChars.CrLf}"

                kumuliert += getVal(act, zuVerteilen, ziel.Text)
                Me.DataGridView2.Rows.Add({dtStart.Hour, Math.Round(getVal(act, zuVerteilen, ziel.Text), 0), Math.Round(kumuliert, 0)})
            End While

            Dim _aktEnde = getAnteilAusserhalb(getValue(monat, tag, dtEnde), dtEnde)
            Me.TextBox1.Text += $"Schliessung: {Math.Round(_aktEnde, 2)}{ControlChars.CrLf}"
            Me.TextBox1.Text += $"Nach Schliessung: {Math.Round(_zuVerteilenEndeDanach, 2)}{ControlChars.CrLf}"

            If getVal(_aktEnde, zuVerteilen, ziel.Text) = 0 Then
                Total()
                Exit Sub
            Else
                kumuliert += getVal(_aktEnde, zuVerteilen, ziel.Text)
                Me.DataGridView2.Rows.Add({dtEnde.AddHours(0).Hour, Math.Round(getVal(_aktEnde, zuVerteilen, ziel.Text), 0), Math.Round(kumuliert, 0)})
                Total()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Function getVal(pct As Decimal, zuVerteilen As Decimal, betrag As Decimal) As Decimal
        Return pct / (100 - zuVerteilen) * betrag
    End Function

    Function getBeforeStart(_monat As Months, _tag As Integer, _refDt As DateTime) As Decimal
        Dim data = coll(_monat)
        Return data.Where(Function(x) x(0) < _refDt.Hour).Sum(Function(x) x(_tag))
    End Function

    Function getAfterEnde(_monat As Months, _tag As Integer, _refDt As DateTime) As Decimal
        Dim data = coll(_monat)
        Return data.Where(Function(x) x(0) > _refDt.Hour).Sum(Function(x) x(_tag))
    End Function

    Function getValue(_monat As Months, _tag As Integer, _refDt As DateTime) As Decimal
        Dim data = coll(_monat)
        Return data.Where(Function(x) x(0) = _refDt.Hour).Sum(Function(x) x(_tag))
    End Function

    Function getAnteilInnerhalb(val As Decimal, _refDt As DateTime) As Decimal
        Dim pct = (60 - _refDt.Minute) / 60
        Return val * pct
    End Function

    Function getAnteilAusserhalb(val As Decimal, _refDt As DateTime) As Decimal
        Dim pct = _refDt.Minute / 60
        Return val * pct
    End Function


    Sub Total()
        Dim total As Decimal = 0
        For Each r As DataGridViewRow In Me.DataGridView2.Rows
            total += r.Cells(1).Value
        Next

        If total <> Me.ziel.Text Then
            Me.DataGridView2.Rows(Me.DataGridView2.Rows.Count - 1).Cells.Item(1).Value -= (total - Me.ziel.Text)
            Me.Total()
        Else
            Me.DataGridView2.Rows(Me.DataGridView2.Rows.Count - 1).Cells.Item(2).Value = Me.ziel.Text

            Dim i = Me.DataGridView2.Rows.Add({Nothing, total, Nothing})
            Dim c = New DataGridViewCellStyle()
            Me.DataGridView2.Rows(i).Cells(1).Style.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
        End If
    End Sub

    Sub Total2()
        Try
            Dim i = Me.DataGridView1.Rows.Count - 1
            Dim c = New DataGridViewCellStyle()
            Me.DataGridView1.Rows(i).DefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)

            For cnt = 1 To Me.DataGridView1.Columns.Count - 1
                Dim total As Decimal = 0
                For r = 0 To Me.DataGridView1.Rows.Count - 2
                    total += Me.DataGridView1.Rows(r).Cells(cnt).Value
                Next
                For Each r As DataGridViewRow In Me.DataGridView1.Rows
                    'total += r.Cells(cnt).Value
                Next
                Me.DataGridView1.Rows(i).Cells(cnt).Value = total
            Next
            Me.DataGridView1.Rows(i).Cells(0).Value = Double.NaN
        Catch ex As Exception
        End Try
        Exit Sub

        Try
            Dim i = Me.DataGridView1.Rows.Add()
            Dim c = New DataGridViewCellStyle()
            Me.DataGridView1.Rows(i).DefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)

            For cnt = 1 To Me.DataGridView1.Columns.Count - 1
                Dim total As Decimal = 0
                For Each r As DataGridViewRow In Me.DataGridView1.Rows
                    total += r.Cells(cnt).Value
                Next
                Me.DataGridView1.Rows(i).Cells(cnt).Value = total
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ziel_TextChanged(sender As Object, e As EventArgs) Handles ziel.TextChanged, datum.ValueChanged, von.ValueChanged, bis.ValueChanged, vonSA.ValueChanged, bisSA.ValueChanged
        Me.Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        coll(CType(datum.Value.Month, Months)) = getList(arrDS)
        saveToFile()
    End Sub

    Function getList(o As Double(,)) As List(Of Double())
        getList = New List(Of Double())
        For i = 0 To 13
            Dim dbl(6) As Double
            For j = 0 To 6
                dbl(j) = o(i, j)
            Next
            getList.Add(dbl)
        Next
    End Function



    Public Sub saveToFile()
        Dim counter As Integer = 0
        Try
lb_retry:

            Dim bf As New BinaryFormatter()
            Using ms As Stream = File.Create("matrix.bin")
                Using gz As New GZipStream(ms, CompressionMode.Compress)
                    bf.Serialize(gz, coll)
                    ms.Flush()
                End Using
            End Using
        Catch ex As IOException
            counter += 1
            If counter < 1000 Then GoTo lb_retry Else Throw ex
        End Try
    End Sub


    Public Shared Function loadFromFile() As Dictionary(Of Months, List(Of Double()))
        ' Deserialize from file to a Task Object
        Dim bf As BinaryFormatter = New BinaryFormatter()
        Using aStream As Stream = File.OpenRead("matrix.bin")
            Using gz As New GZipStream(aStream, CompressionMode.Decompress)
                loadFromFile = bf.Deserialize(gz)
            End Using
        End Using
    End Function

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Dim a As String = Clipboard.GetData("UnicodeText")
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    If Clipboard.ContainsText() Then
                        ' Get all the rows and cells from the clipboard
                        Dim list As List(Of String()) = Me.GetClipboardText()

                        ' Paste the values into the DataGridView.
                        Me.PasteClipboardText(sender, list)

                        ' Don't continue to process the keypress.
                        e.Handled = True
                    End If
            End Select
        End If

    End Sub


    Private Function GetClipboardText() As List(Of String())

        Dim list As New List(Of String())

        Dim text As String = Clipboard.GetText()
        Using reader As New IO.StringReader(text)
            Using parser As New FileIO.TextFieldParser(reader)
                parser.Delimiters = New String() {vbTab}

                While Not parser.EndOfData
                    list.Add(parser.ReadFields())
                End While
            End Using
        End Using

        Return list
    End Function

    Private Sub PasteClipboardText(ByRef dgv As DataGridView, ByVal list As List(Of String()))
        Dim rowIndex As Integer = dgv.CurrentCell.RowIndex
        Dim colIndex As Integer = dgv.CurrentCell.ColumnIndex

        If dgv.SelectedCells.Count = 1 Or (dgv.SelectedRows.Count = 1 And dgv.SelectedColumns.Count = 0) Then

            For Each fields As String() In list
                For index As Integer = 0 To fields.Length - 1
                    If colIndex + index < dgv.ColumnCount Then
                        dgv.Rows(rowIndex).Cells(colIndex + index).Value = fields(index)
                    End If
                Next index
                rowIndex += 1
            Next fields
        ElseIf dgv.SelectedCells.Count > 1 Then
            For Each cell In dgv.SelectedCells
                cell.value = list(0)(0)
            Next
        End If
        dgv.RefreshEdit()
    End Sub

    Private Sub DataGridView1_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles DataGridView1.CellParsing
        Try
            e.Value = CType(e.Value.ToString.Replace(",", "."), Double)
            e.ParsingApplied = True
        Catch ex As Exception
        End Try
    End Sub
End Class
