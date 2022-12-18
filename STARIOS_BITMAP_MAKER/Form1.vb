Public Class Form1
    'using DLL called ImageMagnifier for better looking pixel art
    'https://www.codeproject.com/Articles/15925/Image-Magnifier-Control?PageFlow=FixedWidth
    Dim NUMROWS As Integer = 8
    Dim NUMCOLS As Integer = 16

    Dim xWidth = NUMCOLS
    Dim yHeight = NUMROWS
    Dim xMin As Integer = 8 'magic numbers found experimentally. not sure the issue
    Dim xMax As Integer = 327
    Dim yMin As Integer = 31
    Dim yMax As Integer = 175
    Dim Image_File As Integer = 1
    Dim BMP As New Drawing.Bitmap(NUMCOLS, NUMROWS) 'image size
    Dim GFX As Graphics = Graphics.FromImage(BMP)
    Dim myColor As Color = Color.Black
    Dim myMaskcolor As Color = Color.FromArgb(255, 100, 100, 100) ' dont chnage pixelColor.Name = "ff646464"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GFX.FillRectangle(Brushes.White, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
    End Sub


    Function myMap(ByVal x As Integer, ByVal in_min As Integer, ByVal in_max As Integer, ByVal out_min As Integer, ByVal out_max As Integer) As Integer
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function


    Private Sub BMPtoHEX(ByVal myBMP As Image) 'subroutine for the picturebox to hex conversion
        txtboxOut.Clear() 'clear the text box
        Dim LineCount As Integer = 0
        Dim LineCountOffset As Integer = 0

        '----------------------------------Image to byte stream (HEX)--------------------------------------------    
        Dim myImage As Image = myBMP 'declare and set image to load as hex data
        Dim imgByteArray As Byte() = Nothing
        Dim result As String
        Dim output() As String

        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Bmp)
        imgByteArray = imgMemoryStream.GetBuffer()
        result = BitConverter.ToString(imgByteArray, 0) 'CONVERS DATA BUFFER HEX to STRING DATA SEPERATED BY "-"

        result = result.Remove(0, 186) 'REMOVES HEADER INFO from hex file
        For LineCount = 1 To 15
            result = result.Remove(6 * LineCount, 6)
        Next

        result = result.Remove(48, 443) 'REMOVES FOOTER INFO from hex file
        result = result.TrimEnd("-")
        result = result.Replace("-", ",0x")
        result = "0x" + result
        output = Split(result, ",")
        'just gonna brute force this as I dont feel like abstracting this right now. 
        txtboxOut.Text = "const char " + TextBox3.Text + "[16] = { " + Environment.NewLine + output(14) + "," + output(12) + "," + output(10) + "," + output(8) + "," + output(6) + "," + output(4) + "," + output(2) + "," + output(0) + "," + Environment.NewLine + output(15) + "," + output(13) + "," + output(11) + "," + output(9) + "," + output(7) + "," + output(5) + "," + output(3) + "," + output(1) + "};"
        myImage.Dispose()

    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove 'raw mouse position
        Dim MPx As Point = MousePosition()
        TextBox2.Text = MPx.ToString
    End Sub


    Private Sub SetIndexedPixel(ByVal x As Integer, ByVal y As Integer, ByVal bmd As System.Drawing.Imaging.BitmapData, ByVal pixel As Boolean)
        Dim index As Integer = y * bmd.Stride + (x >> 3)
        Dim p As Byte = System.Runtime.InteropServices.Marshal.ReadByte(bmd.Scan0, index)
        Dim mask As Byte = &H80 >> (x And &H7)
        If pixel Then
            p = p Or mask
        Else
            p = p And CByte(mask ^ &HFF) '&HFF
        End If
        System.Runtime.InteropServices.Marshal.WriteByte(bmd.Scan0, index, p)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'clear screen
        txtboxOut.Clear() 'clear hex code window
        GFX.FillRectangle(Brushes.White, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
        ImageMagnifier.ImageToMagnify = BMP
    End Sub



    Private Sub ImageMagnifier_Hover(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ImageMagnifier.MouseMove, ImageMagnifier.MouseClick
        Dim myx As Integer = MousePosition.X - Me.Location.X - ImageMagnifier.Location.X
        Dim myy As Integer = MousePosition.Y - Me.Location.Y - ImageMagnifier.Location.Y
        myx = myMap(myx, xMin, xMax, 0, xWidth - 1)
        myy = myMap(myy, yMin, yMax, 0, yHeight - 1)
        TextBox5.Text = "x:" + myx.ToString + " , " + "y:" + myy.ToString
        Dim MPx As Point = MousePosition()
        TextBox2.Text = MPx.ToString

        If CheckBox1.Checked Then
            'Set the Panel Display Keepout area in grey
            For x As Integer = 0 To 1
                BMP.SetPixel(0 + (7 * x), 6, myMaskcolor)
                BMP.SetPixel(0 + (7 * x), 7, myMaskcolor)
                BMP.SetPixel(1 + (5 * x), 7, myMaskcolor)
            Next x
            For x As Integer = 0 To 1
                BMP.SetPixel(8 + (7 * x), 6, myMaskcolor)
                BMP.SetPixel(8 + (7 * x), 7, myMaskcolor)
                BMP.SetPixel(9 + (5 * x), 7, myMaskcolor)
            Next x
        End If


        If e.Button = MouseButtons.Left And myx >= 0 And myx < NUMCOLS And myy >= 0 And myy < NUMROWS Then
            BMP.SetPixel(myx, myy, Color.Black)
        End If
        If e.Button = MouseButtons.Right And myx >= 0 And myx < NUMCOLS And myy >= 0 And myy < NUMROWS Then
            BMP.SetPixel(myx, myy, Color.White)
        End If

        ImageMagnifier.ImageToMagnify = BMP

        'convert to monochrome
        Dim bm As New Bitmap(BMP.Width, BMP.Height, Imaging.PixelFormat.Format1bppIndexed) ' ITHINK THIS LINE IS MAKING THE MASK A BLACK PIXEL
        Dim bmdn As System.Drawing.Imaging.BitmapData = bm.LockBits(New Rectangle(0, 0, bm.Width, bm.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format1bppIndexed)

        Dim y As Integer
        For y = 0 To BMP.Height - 1

            Dim x As Integer
            For x = 0 To BMP.Width - 1
                Dim pixelColor As Color = BMP.GetPixel(x, y)
                If pixelColor.Name = "ffffffff" Or pixelColor.Name = "ff646464" Then
                    SetIndexedPixel(x, y, bmdn, True)
                End If

            Next x
        Next y
        bm.UnlockBits(bmdn)
        Call BMPtoHEX(bm) 'convert to hex code

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtbox2.Text = OpenFileDialog1.FileName
        End If

        Dim imagelocation As String = txtbox2.Text ' sets the image
        BMP = MyConverters.ConvertTo16bpp(Image.FromFile(imagelocation))
        GFX = Graphics.FromImage(BMP)
        ImageMagnifier.ImageToMagnify = BMP  ' update on load
        ImageMagnifier1.ImageToMagnify = BMP ' preview only gets updated on load
        txtboxOut.Clear()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "BMP Files (*.bmp*)|*.bmp"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim bm As New Bitmap(BMP.Width, BMP.Height, Imaging.PixelFormat.Format1bppIndexed)
            Dim bmdn As System.Drawing.Imaging.BitmapData = bm.LockBits(New Rectangle(0, 0, bm.Width, bm.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format1bppIndexed)

            For y As Integer = 0 To BMP.Height - 1
                For x As Integer = 0 To BMP.Width - 1
                    Dim pixelColor As Color = BMP.GetPixel(x, y)
                    If pixelColor.Name = "ffffffff" Or pixelColor.Name = "ff646464" Then
                        SetIndexedPixel(x, y, bmdn, True)
                    End If
                Next x
            Next y
            bm.UnlockBits(bmdn)
            bm.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            MsgBox("File probably Saved")
        End If

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtboxOut.Clear() 'clear hex code window
        GFX.FillRectangle(Brushes.Black, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
        ImageMagnifier.ImageToMagnify = BMP
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(txtboxOut.Text)
    End Sub


End Class