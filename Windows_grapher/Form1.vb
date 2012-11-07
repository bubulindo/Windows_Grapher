Imports ZedGraph

Public Class Form1

    Public Structure dataPoint
        Public channel As Char
        Public value As Double
    End Structure

    Private alist = New PointPairList()
    Private blist = New PointPairList()
    Private clist = New PointPairList()
    Dim count As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SerialPort1.BaudRate = Integer.Parse(cmbBaud.SelectedItem)
        SerialPort1.PortName = cmbComPorts.SelectedItem




        SerialPort1.Open()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' count = count + 1

        'alist.add(count, 10 * Math.Sin(count * 6.28 * 100))
        'blist.add(count, 5 * Math.Sin(count * 6.28 * 50))
        'clist.add(count, 3 * Math.Sin(count * 6.28 * 10))




        Graph.AxisChange()
        Graph.Invalidate()
        Graph.Refresh()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        count = 0


        cmbBaud.SelectedItem = "19200"

        ' Get a list of serial port names.
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' Show a label with Action information on it
        Debug.Text = "The following serial ports were found:"
        ' Put each port name Into a comboBox control.
        Dim port As String
        For Each port In ports
            cmbComPorts.Items.Add(port)

        Next port
        ' Select the first item in the combo control
        'cmbComPorts.SelectedIndex = 1



        Dim myPane As GraphPane = Graph.GraphPane
        myPane.XAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.IsVisible = True
        myPane.XAxis.Type = AxisType.Linear

        myPane.AddY2Axis("signal 2")


        myPane.Y2AxisList(0).Scale.Max = 30
        myPane.Y2AxisList(0).Scale.Min = -30
        'myPane.Y2AxisList(0).Color = Color.Blue

        myPane.Y2AxisList(0).IsVisible = True

        myPane.XAxis.Scale.Max = 150
        myPane.XAxis.Scale.Min = 0
        myPane.YAxis.Scale.Max = 30
        myPane.YAxis.Scale.Min = -30
        myPane.XAxis.Scale.MinorStep = 1 '2
        myPane.XAxis.Scale.MajorStep = 10 '40

        myPane.XAxis.Scale.MinorUnit = DateUnit.Second
        myPane.XAxis.Scale.MajorUnit = DateUnit.Minute
        ' myPane.XAxis.Scale.Format = "mm:ss"
        myPane.Title.Text = "Arduino Grapher"
        myPane.XAxis.Title.Text = "Time"
        myPane.YAxis.Title.Text = "Values"
        myPane.CurveList.Clear()
        ' Generate three curves



        Graph.GraphPane.AddCurve(txtSigA.Text, alist, Color.Blue, SymbolType.None)
        Graph.GraphPane.AddCurve(txtSigB.Text, blist, Color.Red, SymbolType.None)
        Graph.GraphPane.AddCurve(txtSigC.Text, clist, Color.Green, SymbolType.None)

        Graph.AxisChange()
        Graph.Invalidate()
        Graph.Refresh()

        chkSigA.Checked = True
        chkSigB.Checked = True
        chkSigC.Checked = True



    End Sub

    Private Sub chkSigA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSigA.CheckedChanged

        Dim gL As New CurveList()

        gL = Graph.GraphPane.CurveList
        If chkSigA.Checked = True Then
            gL.Item(0).IsVisible = True
        Else
            gL.Item(0).IsVisible = False
        End If

        Graph.AxisChange()
        Graph.Invalidate()
        Graph.Refresh()

    End Sub

    Private Sub chkSigB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSigB.CheckedChanged
        Dim gL As New CurveList()

        gL = Graph.GraphPane.CurveList
        If chkSigB.Checked = True Then
            gL.Item(1).IsVisible = True
        Else
            gL.Item(1).IsVisible = False
        End If
        Graph.AxisChange()
        Graph.Invalidate()
        Graph.Refresh()

    End Sub

    Private Sub chkSigC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSigC.CheckedChanged
        Dim gL As New CurveList()

        gL = Graph.GraphPane.CurveList
        If chkSigC.Checked = True Then
            gL.Item(2).IsVisible = True
        Else
            gL.Item(2).IsVisible = False
        End If
        Graph.AxisChange()
        Graph.Invalidate()
        Graph.Refresh()

    End Sub

    Private Sub chkAutoScale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoScale.CheckedChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SerialPort1.Close()
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim point As dataPoint
        Dim test As String


        While SerialPort1.BytesToRead > 6
            count = count + 1
            test = SerialPort1.ReadLine
            'MessageBox.Show(SerialPort1.ReadLine, "lala", System.Windows.Forms.MessageBoxButtons.OK)
            point = ParseReceivedData(test)

            If point.channel = "A" Then
                alist.add(count, point.value)
            End If

        End While





    End Sub

    Private Function ParseReceivedData(ByVal Received As String) As dataPoint
        Dim ret As dataPoint
        Dim newStr As String

        ret.channel = Received.Chars(0)

        ' Ver se isto faz parte dos caracteres que o programa aceita. 

        newStr = Received.Remove(0, 1) ' remove the channel letter

        newStr = newStr.Remove(newStr.Length - 1, 1) 'remove the \n at the end

        newStr = newStr.Replace(".", ",") 'investigate this... it should work

        ret.value = Double.Parse(newStr)

        Return ret


    End Function
End Class
