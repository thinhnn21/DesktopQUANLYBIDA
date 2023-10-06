using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBIDA
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DialogResult SaveChanges()
        {
            DialogResult result = DialogResult.Cancel;

            try
            {
                // Logic to save changes
                // If save is successful, set result to OK
                result = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // If there is an error while saving, show a message box and set result to Cancel
                MessageBox.Show("An error occurred while saving: " + ex.Message);
                result = DialogResult.Cancel;
            }

            return result;
        }
        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("KẾT THÚC CHƯƠNG TRÌNH BẠN CÓ MUỐN LƯU KHÔNG", "Closing", MessageBoxButtons.YesNoCancel);

            if (dg == DialogResult.Yes)
            {
                // Logic to save changes
                // If save is cancelled, then cancel the form close
                if (SaveChanges() == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else if (dg == DialogResult.Cancel)
            {
                // If 'Cancel' is clicked on the MessageBox, then cancel the form close
                e.Cancel = true;
            }
        }

        private void btsignin_Click(object sender, EventArgs e)
        {
            FTableMessage fTableMessage = new FTableMessage();
            this.Hide();
            fTableMessage.ShowDialog();
            this.Show();
        }
    }
}
