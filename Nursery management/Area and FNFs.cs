using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nursery_management
{
    public partial class Area_and_FNFs : Form
    {
        public Area_and_FNFs()
        {
            InitializeComponent();
        }

        private void distractAreaTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.distractAreaTblBindingSource.EndEdit();
                this.distractAreaTblTableAdapter.Update(this.databaseDataSet.DistractAreaTbl);
                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        

        private void Area_and_FNFs_Load(object sender, EventArgs e)
        {
            // Load data into the 'databaseDataSet.DistractAreaTbl' table.
            this.distractAreaTblTableAdapter.Fill(this.databaseDataSet.DistractAreaTbl);
        }

        private void distractAreaTblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void distractAreaTblBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.distractAreaTblBindingSource.EndEdit();
                this.distractAreaTblTableAdapter.Update(this.databaseDataSet.DistractAreaTbl);
                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void distractAreaTblBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void distractAreaTblBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void distractAreaTblDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            // Update the database with the changes made in the DataGridView
            try
            {
                this.Validate();
                this.distractAreaTblBindingSource.EndEdit();
                this.distractAreaTblTableAdapter.Update(this.databaseDataSet.DistractAreaTbl);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // code for each box to be saved in the table against the reapective column
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\manso\\Desktop\\DataBase Project\\Nursery management\\Database.mdf\";Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into DistractAreaTbl ([id], [District], [Name_of_Fruit_Nursery_Farm], [Total_Area_(Acre)], [Cultivated_Area_(Acre)], [Waste/Uncultivated_Area_(Area)], [Area_under_Roads/Building_etc.(Acre)]) values (@id, @District, @NameOfFruitNurseryFarm, @TotalAreaAcre, @CultivatedAreaAcre, @WasteUncultivatedAreaArea, @AreaUnderRoadsBuildingEtcAcre)", connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@District", districtTextBox.Text);
            cmd.Parameters.AddWithValue("@NameOfFruitNurseryFarm", name_of_Fruit_Nursery_FarmTextBox.Text);
            cmd.Parameters.AddWithValue("@TotalAreaAcre", float.Parse(total_Area__Acre_TextBox.Text));
            cmd.Parameters.AddWithValue("@CultivatedAreaAcre", float.Parse(cultivated_Area__Acre_TextBox.Text));
            cmd.Parameters.AddWithValue("@WasteUncultivatedAreaArea", float.Parse(waste_Uncultivated_Area__Area_TextBox.Text));
            cmd.Parameters.AddWithValue("@AreaUnderRoadsBuildingEtcAcre", float.Parse(area_under_Roads_Building_etc__Acre_TextBox.Text));

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data updated successfully");

        }
    }
}
