using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Webservice.Entities;
using Webservice.MNBServiceReference;

namespace Webservice
{
    public partial class Form1 : Form
    {
        MNBArfolyamServiceSoapClient MNBArfolyamService = new MNBArfolyamServiceSoapClient();
        BindingList<RateData> rates = new BindingList<RateData>();
        BindingList<string> currencies = new BindingList<string>() ;

        public Form1()
        {

            InitializeComponent();
            
            rates.Clear();
            
            string resultTickers = RefreshCurrencies();
            ConvertFromCurrXML(resultTickers);
            
            comboBox.DataSource = currencies;
            RefreshData();
        }

        private void ConvertFromCurrXML(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement)
            {
                for (int i = 0; i < item.ChildNodes.Count; i++)
                {
                    var childElement = (XmlElement)item.ChildNodes[i];

                    if (childElement == null)
                    {
                        continue;
                    }
                    else
                    {
                        currencies.Add(childElement.InnerText);
                    }
                }
                
            }
        }

        private string RefreshCurrencies()
        {
            GetCurrenciesRequestBody request = new GetCurrenciesRequestBody();
           
            var response = MNBArfolyamService.GetCurrencies(request);
            return response.GetCurrenciesResult;
        }

        private void RefreshData()
        {
            foreach (var series in chartRateData.Series)
            {
                series.Points.Clear();
            }
            string result = GetXCRates();

            dgw.DataSource = rates;
            
            ConvertFromXML(result);

            chartRateData.DataSource = rates;
            

            CustomizeChart();
        }

        private void CustomizeChart()
        {
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void ConvertFromXML(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement)
            {
                var childElement = (XmlElement)item.ChildNodes[0];
                decimal val = 0;
                if (childElement != null)
                {
                     val = decimal.Parse(childElement.GetAttribute("unit"));

                }
                if (val != 0)
                {
                    rates.Add(new RateData(DateTime.Parse(item.GetAttribute("date")), childElement.GetAttribute("curr"), decimal.Parse(childElement.InnerText)));

                }
            }

        }

        private string GetXCRates()
        {
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox.SelectedValue.ToString(),
                startDate = dateFirst.Value.Date.ToString(),
                endDate = dateLast.Value.Date.ToString() 
            };
            var response = MNBArfolyamService.GetExchangeRates(request);
            return response.GetExchangeRatesResult;
        }

        private void dateFirst_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateLast_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
