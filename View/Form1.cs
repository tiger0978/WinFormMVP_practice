using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMVP練習.Contract;
using WinFormMVP練習.Model;
using WinFormMVP練習.Model.Models;
using WinFormMVP練習.Presenter;

namespace WinFormMVP練習
{
    public partial class Form1 : Form,  IProdcutSearchView, IProductListView, IProductGraphView
    {
        IProductSearchPresenter _productSearchPresenter = null;
        IProductListPresenter _prodcutListPresenter = null;
        IProductGraphPresenter _productGraphPresenter = null;
        public Form1()
        {
            InitializeComponent();
            _productSearchPresenter = new ProductSearchPresenter(this);
            _prodcutListPresenter = new ProductListPresenter(this);
            _productGraphPresenter = new ProductChartPresenter(this);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _productSearchPresenter.GetProductSerach();
        }

        public void PhoneResponse(Phone phone)
        {
            nameLab.Text = phone.Name;
            priceLab.Text = phone.Price.ToString();
            descLab.Text = phone.Description;
        }

        public void ProductResponse(List<KeyValue> productSeraches)
        {
            comboBox1.DataSource = productSeraches;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        public void ProductListResponse(List<ProductSaleRecord> products)
        {
            dataGridView1.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = comboBox1.Text;
            _prodcutListPresenter.GetProductList(productName);
            _productGraphPresenter.GetProductGraph(productName);
        }

        public void ProductGraphResponse(List<ProductSaleRecord> productSaleRecords)
        {
            chart1.Series[0].Points.DataBindXY(productSaleRecords.Select(x => x.name).ToArray(), productSaleRecords.Select(x => x.price).ToArray());
            chart2.Series[0].Points.DataBindXY(productSaleRecords.Select(x => x.name).ToArray(), productSaleRecords.Select(x => x.price).ToArray());
        }
    }
}
