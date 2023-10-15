using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        ITIDBContext DB;
        public Form1()
        {
            InitializeComponent();
            DB = new ITIDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GV.DataSource = DB.Students.Include(a => a.Track).Select(a => new { Name = a.Name, Age = a.Age, TrackName = a.Track.Name }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GV.DataSource = DB.Students.ToList();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            var searchtext = Search_box.Text;
            GV.DataSource = DB.Students.Where(s => s.Name.Contains(searchtext)).ToList();
            searchtext = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addd_btn_Click(object sender, EventArgs e)
        {

            Student s = new Student
            {
                Id = int.Parse(id_box.Text),
                Name = name_box.Text,
                Age = int.Parse(age_box.Text),
                track_id = int.Parse(tbox.Text),
            };
            DB.Students.Add(s);
            DB.SaveChanges();
            id_box.Text = "";
            name_box.Text = "";
            age_box.Text = "";
            GV.DataSource = DB.Students.ToList();
            addd_txt.Text = "ADDED";
        }

        private void tbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}