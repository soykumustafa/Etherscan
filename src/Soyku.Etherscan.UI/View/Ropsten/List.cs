using Soyku.Etherscan.Core.Common;
using Soyku.Etherscan.Core.Domain.Ropsten;
using Soyku.Etherscan.Core.ResponseRequestModel.Ropsten;
using Soyku.Etherscan.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Soyku.Etherscan.UI.View.Ropsten
{
    public partial class List : Form
    {
        private readonly RopstenService service = new RopstenService();
        public List()
        {
            InitializeComponent();
        }

        private async void m_btnGetAll_Click(object sender, EventArgs e)
        {
            var request = new Request
            {
                Module = m_txtModule.Text,
                Action = m_txtAction.Text,
                Address = m_txtAddres.Text,
                Startblock = m_txtStartBlock.Text,
                Endblock = m_txtEndBlock.Text,
                Page = m_txtPage.Text,
                Offset = m_txtOffset.Text,
                Sort = m_comboSort.Text,
                Apikey = m_txtApiKey.Text
            };

            var employeeData=await GetAllEmployeeAsync(request);
            m_gridView.DataSource = employeeData;
        }

        private async Task<IEnumerable<Employee>> GetAllEmployeeAsync(Request request)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("module={0}&", request.Module);
            sb.AppendFormat("action={0}&", request.Action);
            sb.AppendFormat("address={0}&", request.Address);
            sb.AppendFormat("startblock={0}&", request.Startblock);
            sb.AppendFormat("endblock={0}&", request.Endblock);
            sb.AppendFormat("page={0}&", request.Page);
            sb.AppendFormat("offset={0}&", request.Offset);
            sb.AppendFormat("sort={0}&", request.Sort);
            sb.AppendFormat("apikey={0}", request.Apikey);
            var result = await service.GetAllEmployees(sb.ToString());
            return result;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
