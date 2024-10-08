﻿using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();

        }

        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
