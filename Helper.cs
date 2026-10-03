using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app_prakerin.Config;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DrawingFont = System.Drawing.Font;

namespace app_prakerin
{
    class Helper
    {
        static DataTable dataPrint;
        static string judulPrint;
        static int barisPrint;

        public static void UntukForm(Form FormApa, Panel PanelApa)
        {
            PanelApa.Controls.Clear();
            FormApa.TopLevel = false;
            FormApa.FormBorderStyle = FormBorderStyle.None;
            FormApa.Dock = DockStyle.Fill;
            PanelApa.Controls.Add(FormApa);
            FormApa.Show();
        }

        public static void Pindah(params Control[] controls)
        {
            for (int i = 0; i < controls.Length - 1; i++)
            {
                int next = i + 1;
                controls[i].KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true;
                        controls[next].Focus();
                    }
                };
            }
        }

        public static void CSV(DataTable dt, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(EscapeCSV(dt.Columns[i].ColumnName));
                    if (i < dt.Columns.Count - 1) sw.Write(",");
                }
                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sw.Write(EscapeCSV(row[i].ToString()));
                        if (i < dt.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }

        static string EscapeCSV(string value)
        {
            if (value == null) return "";
            value = value.Replace("\"", "\"\"");
            return value.Contains(",") || value.Contains("\"") || value.Contains("\r") || value.Contains("\n")
                ? "\"" + value + "\""
                : value;
        }

        //excel
        public static void Excel(DataTable dt, string path, string judul)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                IXLWorksheet ws = wb.Worksheets.Add("Laporan");
                ws.Cell(1, 1).Value = judul;

                if (dt.Columns.Count > 1) ws.Range(1, 1, 1, dt.Columns.Count).Merge();

                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Font.FontSize = 16;
                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cell(3, i + 1).Value = dt.Columns[i].ColumnName;
                    ws.Cell(3, i + 1).Style.Font.Bold = true;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                    for (int j = 0; j < dt.Columns.Count; j++)
                        ws.Cell(i + 4, j + 1).Value = dt.Rows[i][j].ToString();

                if (dt.Columns.Count > 0)
                {
                    int last = dt.Rows.Count + 3;
                    ws.Range(3, 1, last, dt.Columns.Count).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    ws.Range(3, 1, last, dt.Columns.Count).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                }

                ws.Columns().AdjustToContents();
                wb.SaveAs(path);
            }
        }

        //pdf
        public static void PDF(DataTable dt, string path, string judul)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 20, 20, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph(judul, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("Tanggal Cetak : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
            doc.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100;

            foreach (DataColumn col in dt.Columns)
                table.AddCell(new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9))));

            foreach (DataRow row in dt.Rows)
                foreach (object value in row.ItemArray)
                    table.AddCell(new Phrase(value == null ? "" : value.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 8)));

            doc.Add(table);
            doc.Close();
        }

        public static void Print(DataTable dt, string judul)
        {
            dataPrint = dt;
            judulPrint = judul;
            barisPrint = 0;

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += CetakHalaman;
            doc.Print();
        }

        public static void Preview(DataTable dt, string judul, Form form)
        {
            dataPrint = dt;
            judulPrint = judul;
            barisPrint = 0;

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += CetakHalaman;

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = doc,
                Width = 1000,
                Height = 700
            };

            preview.ShowDialog(form);
        }

        static void CetakHalaman(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawingFont judul = new DrawingFont("Arial", 16, FontStyle.Bold);
            DrawingFont header = new DrawingFont("Arial", 9, FontStyle.Bold);
            DrawingFont data = new DrawingFont("Arial", 8);

            float x = e.MarginBounds.Left, y = e.MarginBounds.Top, tinggi = 25;

            g.DrawString(judulPrint, judul, Brushes.Black, x, y);
            y += 35;
            g.DrawString("Tanggal Cetak : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), data, Brushes.Black, x, y);
            y += 30;

            if (dataPrint.Columns.Count == 0)
            {
                e.HasMorePages = false;
                return;
            }

            float lebar = (float)e.MarginBounds.Width / dataPrint.Columns.Count;

            for (int i = 0; i < dataPrint.Columns.Count; i++)
            {
                float px = x + i * lebar;
                g.DrawRectangle(Pens.Black, px, y, lebar, tinggi);
                g.DrawString(dataPrint.Columns[i].ColumnName, header, Brushes.Black, new RectangleF(px + 3, y + 5, lebar - 6, tinggi));
            }

            y += tinggi;

            while (barisPrint < dataPrint.Rows.Count)
            {
                if (y + tinggi > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                for (int i = 0; i < dataPrint.Columns.Count; i++)
                {
                    float px = x + i * lebar;
                    string value = dataPrint.Rows[barisPrint][i].ToString();

                    g.DrawRectangle(Pens.Black, px, y, lebar, tinggi);
                    g.DrawString(value, data, Brushes.Black, new RectangleF(px + 3, y + 5, lebar - 6, tinggi));
                }

                y += tinggi;
                barisPrint++;
            }

            e.HasMorePages = false;
        }
    }
}
