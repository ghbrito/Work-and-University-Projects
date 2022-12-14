using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ovveride of the class events used to set headers and page numbers when generating accounting book PDF
namespace Calcula_Custas.Classes
{
    class _events : PdfPageEventHelper
    {
        public int livro;
        public int pag;

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            string headerCellLeft = "Livro nº " + livro;
            string headerCellCenter = "Cartório do Registro Civil das Pessoas Naturais e de Notas de São Benedito - Santa Luzia/MG";
            string headerCellCenter2 = "Livro Diário Auxiliar da Receita e da Despesa";
            int pagina;
            if (document.PageNumber < 1)
            {
                pagina = pag;
            }
            else
            {
                pagina = document.PageNumber + pag - 1;
            }
            if(pagina == 300)
            {
                pag = 1 - document.PageNumber;
                livro++;
            }

            string headerCellRight = "Página nº " + pagina;
            var headerLeft = new PdfPCell(new Paragraph(new Chunk(headerCellLeft, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            var headerCenter = new PdfPCell(new Paragraph(new Chunk(headerCellCenter, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            var headerCenter2 = new PdfPCell(new Paragraph(new Chunk(headerCellCenter2, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            var headerRight = new PdfPCell(new Paragraph(new Chunk(headerCellRight, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            headerCenter.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            headerCenter.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            headerCenter.Border = 0;
            headerCenter2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            headerCenter2.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            headerCenter2.Border = 0;
            headerLeft.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
            headerLeft.Border = 0;
            headerRight.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
            headerRight.Border = 0;

            PdfPTable header = new PdfPTable(3);
            PdfPTable header2 = new PdfPTable(3);
            PdfPTable header3 = new PdfPTable(6);

            header.LockedWidth = true;
            header.TotalWidth = 500f;
            header.DefaultCell.Border = 0;
            header2.LockedWidth = true;
            header2.TotalWidth = 500f;
            header2.DefaultCell.Border = 0;
            header3.LockedWidth = true;
            header3.TotalWidth = 500f;

            float[] widths = new float[3];
            widths[0] = 20;
            widths[1] = 350;
            widths[2] = 20;
            header.SetWidths(widths);

            widths[0] = 50;
            widths[1] = 270;
            widths[2] = 50;
            header2.SetWidths(widths);

            widths = new float[6];
            widths[0] = 10.78f;
            widths[1] = 5.22f;
            widths[2] = 9.89f;
            widths[3] = 30.11f;
            widths[4] = 13.89f;
            widths[5] = 13.89f;
            header3.SetWidths(widths);

            header.AddCell("");
            header.AddCell(headerCenter);
            header.AddCell("");

            header2.AddCell(headerLeft);
            header2.AddCell(headerCenter2);
            header2.AddCell(headerRight);

            var p1 = new Paragraph(new Chunk("Data", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
            p1.IndentationLeft = document.LeftMargin;
            var header3_1 = new PdfPCell(p1);
            header3_1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_1.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            //header3_1.Border = 0;
            var header3_2 = new PdfPCell(new Paragraph(new Chunk("Qtd", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            header3_2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_2.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            //header3_2.Border = 0;
            var header3_3 = new PdfPCell(new Paragraph(new Chunk("Código", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            header3_3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_3.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            //header3_3.Border = 0;
            var header3_4 = new PdfPCell(new Paragraph(new Chunk("Termo/Lv.Fl./Descrição", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            header3_4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_4.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            //header3_4.Border = 0;
            var header3_5 = new PdfPCell(new Paragraph(new Chunk("Receita", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            header3_5.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_5.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            //header3_5.Border = 0;
            var header3_6 = new PdfPCell(new Paragraph(new Chunk("Despesa", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
            header3_6.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            header3_6.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;

            header3.AddCell(header3_1);
            header3.AddCell(header3_2);
            header3.AddCell(header3_3);
            header3.AddCell(header3_4);
            header3.AddCell(header3_5);
            header3.AddCell(header3_6);

            PdfPTable table2 = new PdfPTable(1);
            table2.DefaultCell.Border = 0;

            table2.AddCell(header);
            table2.AddCell(header2);
            table2.AddCell(header3);
            table2.TotalWidth = 500f;

            //MessageBox.Show("pg: " + pagina);
            table2.WriteSelectedRows(0, -1, 71.3f, 808f, writer.DirectContent);

        }

    }
}
