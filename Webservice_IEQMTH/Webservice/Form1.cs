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


        public Form1()
        {
            InitializeComponent();

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
        }

        private void ConvertFromXML(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement)
            {
                var childElement = (XmlElement)item.ChildNodes[0];
                decimal val = decimal.Parse(childElement.GetAttribute("unit"));
                if (val != 0)
                {
                    rates.Add(new RateData(DateTime.Parse(item.GetAttribute("date")), childElement.GetAttribute("curr"), decimal.Parse(childElement.InnerText)));

                }
            }

        }

        private string GetXCRates()
        {
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody() { currencyNames = "EUR", startDate = "2020-01-01", endDate = "2020-06-30" };
            var response = MNBArfolyamService.GetExchangeRates(request);
            return response.GetExchangeRatesResult;
        }
    }
}
