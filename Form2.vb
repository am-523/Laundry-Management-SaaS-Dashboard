Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf

Public Class Form2



    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Application.ExitThread()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CartesianChart1.Series = New SeriesCollection From {
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 10),
                        New ObservablePoint(4, 7),
                        New ObservablePoint(5, 3),
                        New ObservablePoint(7, 6),
                        New ObservablePoint(10, 8)
                    },
                    .PointGeometrySize = 10
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 2),
                        New ObservablePoint(2, 5),
                        New ObservablePoint(3, 6),
                        New ObservablePoint(6, 8),
                        New ObservablePoint(10, 5)
                    },
                    .PointGeometrySize = 15
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                }
            }
    End Sub
End Class