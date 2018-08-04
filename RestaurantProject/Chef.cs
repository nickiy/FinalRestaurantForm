using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet2);
   
           
        }

        private void Chef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet2.Ready_Table' table. You can move, or remove it, as needed.
            this.ready_TableTableAdapter.Fill(this.restaurantDataSet2.Ready_Table);
            // TODO: This line of code loads data into the 'restaurantDataSet2.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.restaurantDataSet2.Order_Details);
            // TODO: This line of code loads data into the 'restaurantDataSet2.Ready_Table' table. You can move, or remove it, as needed.
            this.ready_TableTableAdapter.Fill(this.restaurantDataSet2.Ready_Table);
            // TODO: This line of code loads data into the 'restaurantDataSet2.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.restaurantDataSet2.Order_Details);
            // TODO: This line of code loads data into the 'restaurantDataSet1.Final' table. You can move, or remove it, as needed.
            //this.finalTableAdapter.Fill(this.restaurantDataSet1.Final);
            
            // TODO: This line of code loads data into the 'restaurantDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.restaurantDataSet.Orders);

        }

        private void ordersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.order_DetailsTableAdapter.Fill(restaurantDataSet2.Order_Details);
            this.ready_TableTableAdapter.Fill(restaurantDataSet2.Ready_Table);
            this.tableAdapterManager.UpdateAll(restaurantDataSet2);
            

        } 

        private void btn_edit_Click(object sender, EventArgs e)
        {
            



        }

        private void order_DetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet2);

        }
    }
}
