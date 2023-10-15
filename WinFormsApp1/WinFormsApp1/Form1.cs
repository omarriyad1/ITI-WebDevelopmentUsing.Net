using WinFormsApp1.Models;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class add_btn : Form
    {
        ItiSummerTrainingContext DB;
        public add_btn()
        {
            InitializeComponent();
            DB = new ItiSummerTrainingContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GV.DataSource = DB.Students.ToList();
            dept_box.DataSource = DB.Departments.ToList();
            dept_box.DisplayMember = "name";
            dept_box.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchtext = Search_box.Text;
            GV.DataSource = DB.Students.Where(s => s.Name.Contains(searchtext)).ToList();
            searchtext = "";
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            GV.DataSource = DB.Students.ToList();
        }

        private void addd_btn_Click(object sender, EventArgs e)
        {

            Student s = new Student
            {
                Id = int.Parse(id_box.Text),
                Name = name_box.Text,
                Addresse = add_box.Text,
                Deptid = (int)dept_box.SelectedValue,
            };
            DB.Students.Add(s);
            DB.SaveChanges();
            id_box.Text = "";
            name_box.Text = "";
            add_box.Text = "";
            GV.DataSource = DB.Students.ToList();
            addd_txt.Text = "ADDED";


        }


    }
}