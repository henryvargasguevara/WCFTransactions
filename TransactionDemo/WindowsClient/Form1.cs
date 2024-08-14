using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.ProductsServiceReference;
using System.Transactions;
using System.ServiceModel;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CategoryId = 0;
            int Counter = 0;

            try
            {

                using(TransactionScope ts= new TransactionScope(TransactionScopeOption.Required))
                {
                    ProductsClient proxy = new ProductsClient();
                    CategoryId = proxy.AddCategory("Electronic Products");
                    Counter = proxy.AddProducts(CategoryId);

                    MessageBox.Show("Number of Products inserted are : "+ Counter.ToString());
                    proxy.Close();
                    ts.Complete();
                }

            }
            catch(FaultException fex)
            {


            }



        }
    }
}
