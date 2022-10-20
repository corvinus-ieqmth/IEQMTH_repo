using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            GetXCRates();

            dgw.DataSource = rates;

            
        }

        private void GetXCRates()
        {
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody() { currencyNames = "EUR", startDate = "2020-01-01", endDate = "2020-06-30" };
            var response = MNBArfolyamService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }
    }
}
