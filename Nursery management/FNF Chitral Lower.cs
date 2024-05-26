using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_management
{
    public partial class FNF_Chitral_Lower : Form
    {
        public FNF_Chitral_Lower()
        {
            InitializeComponent();
        }

        private void FNF_Chitral_Lower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.FNFChitralLowerTbl' table. You can move, or remove it, as needed.
            this.fNFChitralLowerTblTableAdapter.Fill(this.databaseDataSet.FNFChitralLowerTbl);

        }

        private void fNFChitralLowerTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fNFChitralLowerTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DistrictsForm1 df = new DistrictsForm1();
            df.Show();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            // code for each box to be saved in the table against the reapective column
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\manso\\Desktop\\DataBase Project\\Nursery management\\Database.mdf\";Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into FNFChitralLowerTbl ([Id], [District], [Name_of_Fruit_Nursery_Farm], [Name_of_Fruit], [No_of_Fruit_Plants_Raised], [Total_No_of_Plants_available_for_season], [Under_Size_Plants]) values (@id, @District, @NameOfFruitNurseryFarm, @NameOfFruit, @NoOfFruitPlantsRaised, @TotalNoOfPlantsAvailableForSeason, @UnderSizePlants)", connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@District", districtTextBox.Text);
            cmd.Parameters.AddWithValue("@NameOfFruitNurseryFarm", name_of_Fruit_Nursery_FarmTextBox.Text);
            cmd.Parameters.AddWithValue("@NameOfFruit", name_of_FruitTextBox.Text);
            cmd.Parameters.AddWithValue("@NoOfFruitPlantsRaised", int.Parse(no_of_Fruit_Plants_RaisedTextBox.Text));
            cmd.Parameters.AddWithValue("@TotalNoOfPlantsAvailableForSeason", int.Parse(total_No_of_Plants_available_for_seasonTextBox.Text));
            cmd.Parameters.AddWithValue("@UnderSizePlants", int.Parse(under_Size_PlantsTextBox.Text));

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data updated successfully");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\manso\\Desktop\\DataBase Project\\Nursery management\\Database.mdf\";Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from FNFChitralLowerTbl where Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data deleted successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\manso\\Desktop\\DataBase Project\\Nursery management\\Database.mdf\";Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from FNFChitralLowerTbl ", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
