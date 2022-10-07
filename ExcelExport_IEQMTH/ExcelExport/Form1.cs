using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        List<Flat> flats;

        RealEstateEntities context = new RealEstateEntities();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex)
            {
                string message = $"Error:{ex.Message} / {ex.Source}";
                MessageBox.Show(message,"Hiba");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;

                
            }
        }

        private void CreateTable()
        {


            string[] headers = new string[] {
                 "Kód",
                 "Eladó",
                 "Oldal",
                 "Kerület",
                 "Lift",
                 "Szobák száma",
                 "Alapterület (m2)",
                 "Ár (mFt)",
                 "Négyzetméter ár (Ft/m2)"};

            object[,] values = new object[flats.Count, headers.Length];

            for (int i = 1; i < headers.Length + 1; i++)
            {
                xlSheet.Cells[1, i] = headers[i-1];
            }

            int counter = 0;
            foreach (var flat in flats)
            {
                values[counter, 0] = flat.Code;
                values[counter, 1] = flat.Vendor;
                values[counter, 2] = flat.Side;
                values[counter, 3] = flat.District;
                values[counter, 4] = flat.Elevator;
                values[counter, 5] = flat.NumberOfRooms;
                values[counter, 6] = flat.FloorArea;
                values[counter, 7] = flat.Price;
                values[counter, 8] = $"={GetCell(counter+2,8 )} * 1000000 / {GetCell(counter + 2, 7)}";

                counter++;

            }

            Excel.Range dataRange = xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0), values.GetLength(1)));

            Excel.Range firstColumnRange = xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0),1));

            Excel.Range lastColumnRange = xlSheet.get_Range(
             GetCell(2, 9),
             GetCell(1 + values.GetLength(0), 9));

            dataRange.Value2 = values;

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            dataRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            firstColumnRange.Interior.Color = Color.LightYellow;
            firstColumnRange.Font.Bold = true;
            lastColumnRange.Interior.Color = Color.LightGreen;
            
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
        private void LoadData()
        {
            flats = context.Flats.ToList();
        }
    }
}
