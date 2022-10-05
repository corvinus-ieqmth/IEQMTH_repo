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
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            flats = context.Flats.ToList();
        }
    }
}
