using Spire.Pdf.Graphics;
using Spire.Pdf;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf.Conversion;
using System.Drawing;
using System.Drawing.Imaging;

namespace CapaPresentacion
{
    public static class Exportar
    {
        public static void ExportarExcel(DataGridView dg)
        {

            //Create a Workbook instance
            Workbook workbook = new Workbook();
            //Remove default worksheets
            workbook.Worksheets.Clear();
            //Add a worksheet and name it
            Worksheet worksheet = workbook.Worksheets.Add("Tabla");
            //Create a DataTable object
            DataTable dataTable = new DataTable();
            //dataTable.Rows.Add();

            foreach (DataGridViewColumn column in dg.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dg.Rows)
            {
                dataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Write datatable to the worksheet
            worksheet.InsertDataTable(dataTable, true, 1, 1, true);
            workbook.SaveToFile("C:\\Users\\Mariana\\Downloads\\tablaExportada.xlsx", ExcelVersion.Version2016);


            Workbook workbook3 = new Workbook();
            workbook3.LoadFromFile("C:\\Users\\Mariana\\Downloads\\tablaExportada.xlsx");
            Worksheet sheet3 = workbook3.Worksheets[0];

            CellStyle style = workbook3.Styles.Add("newStyle");
            style.Font.Size = 12;
            style.HorizontalAlignment = HorizontalAlignType.Right;
            sheet3.ApplyStyle(style);

            Spire.Xls.CellStyle fontStyle = workbook3.Styles.Add("headerFontStyle");
            // Set the font color, size and style
            fontStyle.Font.Color = System.Drawing.Color.White;
            fontStyle.Font.IsBold = true;
            fontStyle.Font.Size = 13;
            fontStyle.HorizontalAlignment = HorizontalAlignType.Center;
            fontStyle.VerticalAlignment = VerticalAlignType.Center;
            // Create a CellStyleFlag object, setting the FontColor, FontBold, FontSize and HorizontalAlignment properties to true
            CellStyleFlag flag = new CellStyleFlag();
            flag.FontColor = true;
            flag.FontBold = true;
            flag.FontSize = true;
            flag.HorizontalAlignment = true;
            flag.VerticalAlignment = true;
            //Apply the cell style to header row
            sheet3.Range[1, 1, 1, 100].ApplyStyle(fontStyle, flag);

            sheet3.Range["A1:XX1"].Style.Color = System.Drawing.Color.Navy;
            sheet3.Range["A2:XX1000"].Style.Color = System.Drawing.Color.Azure;
            sheet3.HideColumn(1);
            sheet3.HideColumn(2);
            sheet3.HideColumn(3);
            sheet3.AllocatedRange.AutoFitRows();
            sheet3.AllocatedRange.AutoFitColumns();
            sheet3.SetRowHeight(1, 30);

            sheet3.Range["A1"].Style.VerticalAlignment = VerticalAlignType.Top;

            sheet3.InsertRow(1);
            sheet3.Rows[0].Merge();

            string picPath = "C:\\Users\\Mariana\\Downloads\\banner.png";
            ExcelPicture picture = sheet3.Pictures.Add(1, 1, picPath);
            sheet3.Columns[0].ColumnWidth = 50;
            sheet3.Rows[0].RowHeight = 100;
            picture.LeftColumnOffset = 100;
            picture.TopRowOffset = 25;


            workbook3.SaveToFile("C:\\Users\\Mariana\\Downloads\\tablaExportada.xlsx", ExcelVersion.Version2016);


            System.Diagnostics.Process.Start("C:\\Users\\Mariana\\Downloads\\tablaExportada.xlsx");

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest,
                                        int nWidth, int nHeight, IntPtr hdcSrc,
                                        int nXSrc, int nYSrc, int dwRop);
       
        public static void ExportarComoImagen(Form form)
        {
            Graphics mygraphics = form.CreateGraphics();
            Size sz = form.ClientRectangle.Size;
            Bitmap bmp = new Bitmap(sz.Width, sz.Height - 90, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, form.ClientRectangle.Width,
                    form.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

            bmp.Save("C:\\Users\\Mariana\\Downloads\\prueba.bmp", ImageFormat.Bmp);

            System.Diagnostics.Process.Start("C:\\Users\\Mariana\\Downloads\\prueba.bmp");
      
        }
    }
}
