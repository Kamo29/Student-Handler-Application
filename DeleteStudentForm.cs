using CRUD_LayeredApp.DataLayer;
using CRUD_LayeredApp.LogicLayer;

namespace CRUD_LayeredApp.Presentation
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            Student student = new Student();
            student.StudentNumber = int.Parse(textBox1.Text);
            handler.delete(student.StudentNumber);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
            Form1 form = new Form1();
            form.Show();
        }
    }
}
