using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace course_work4
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            this.ShowDB_fill();
        }

        public void ShowDB_fill() {
            this.dgv_dataBase.DataSource = DB.Entities.View_InfoSclad.ToList();
        }

        private void Editing_button_Click(object sender, EventArgs e)
        {
            EditingForm editingForm = new EditingForm();
            editingForm.ShowDialog();
        }

        //добавление
        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }
        }


        //удаление
        private void Remove_button_Click(object sender, EventArgs e)
        {
            try {
                if (dgv_dataBase.SelectedRows.Count != 0)
                {
                    int index = dgv_dataBase.SelectedRows[0].Index;
                    int id = 0;
                    bool conv = Int32.TryParse(dgv_dataBase[0, index].Value.ToString(), out id);
                    if (!conv) { return; }

                    MessageBox.Show("Запись удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
