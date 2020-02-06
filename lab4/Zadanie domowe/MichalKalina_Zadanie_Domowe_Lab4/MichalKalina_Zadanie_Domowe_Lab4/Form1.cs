using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalKalina_Zadanie_Domowe_Lab4
{
    public partial class Form1 : Form
    {
       Table_Customer model = new Table_Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            Clear();
        }
        void Clear()//czysci textbox-y i wylacza przycisk Delete i Zmienia nazwe buttonSave na Save i resetuje CostumerID
        {
            textBoxName.Text = textBoxSurName.Text = textBoxCity.Text = textBoxAdress.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            buttonCancel.Enabled = false;
            model.CustomerID = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = true;
            model.Firstname = textBoxName.Text.Trim();
            model.LastName = textBoxSurName.Text.Trim();
            model.City = textBoxCity.Text.Trim();
            model.Adress = textBoxAdress.Text.Trim();
            using (ZD4Entities1 db = new ZD4Entities1())
            {
                if (model.CustomerID == 0)//dodawanie nowego
                {
                    db.Table_Customer.Add(model);
                    db.SaveChanges();
                }
                else//ulepszanie starego
                {
                    
                    db.Entry(model).State =EntityState.Modified;
                    db.SaveChanges();
                }
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Dodano pomyslnie");
        }
        void PopulateDataGridView()
        {
            //dataGridViewCostumer.AutoGenerateColumns = false;
            using (ZD4Entities1 db = new ZD4Entities1())
            {
                dataGridViewCostumer.DataSource = db.Table_Customer.ToList<Table_Customer>();

            }
        }

        private void dataGridViewCostumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCostumer_DoubleClick(object sender, EventArgs e)
        {
            buttonCancel.Enabled = true;

            if (dataGridViewCostumer.CurrentRow.Index != -1)
            {
                model.CustomerID = Convert.ToInt32(dataGridViewCostumer.CurrentRow.Cells ["CustomerID"].Value);
                using (ZD4Entities1 db = new ZD4Entities1())
                {
                    model = db.Table_Customer.Where(x => x.CustomerID == model.CustomerID).FirstOrDefault();
                    textBoxName.Text = model.Firstname;
                    textBoxSurName.Text = model.LastName;
                    textBoxCity.Text = model.City;
                    textBoxAdress.Text = model.Adress;
                }
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) //wraca do menu głównego
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ZD4Entities1 db = new ZD4Entities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State ==  System.Data.Entity.EntityState.Detached)
                        db.Table_Customer.Attach(model);
                    db.Table_Customer.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void buttonBackFromInstruction_Click(object sender, EventArgs e)
        {
            panelInstruction.Hide();
            dataGridViewCostumer.Show();
            panelUserData.Show();
            buttonCancel.Show();
            buttonDelete.Show();
            buttonSave.Show();
            buttonInstruction.Show();
            buttonExit.Show();
        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            panelInstruction.Show();
            dataGridViewCostumer.Hide();
            panelUserData.Hide();
            buttonCancel.Hide();
            buttonDelete.Hide();
            buttonSave.Hide();
            buttonInstruction.Hide();
            buttonExit.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInstruction_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
