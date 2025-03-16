using Econtact.econtactClasses;
using System.Data;

namespace Econtact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        contactClasses c = new contactClasses();
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxSearch.Text))
            {
                dgvContactList.DataSource = c.Select(); // Tüm verileri tekrar göster
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNumber = txtBoxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            bool success = c.Insert(c);
            if (success = true)
            {
                MessageBox.Show("Yeni Kiþi Baþarýyla Eklendi.");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Yeni Kiþi Eklenemedi. Tekrar Deneyin");
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtBoxContactNumber.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtboxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtboxContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNumber = txtboxContactID.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;
            bool success = c.Update(c);
            if (success = true)
            {

                MessageBox.Show("Kiþi Baþarýyla Güncellendi.");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Kiþi Güncellenemedi.");
            }

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
            bool succes = c.Delete(c);
            if (succes = true)

            {
                MessageBox.Show("Kiþi Baþarýyla Silindi");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Kiþi Silinemedi. Tekrar Deneyin.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtboxSearch.Text.Trim();
            dgvContactList.DataSource = c.Search(keyword);
        }

        
    }
}
