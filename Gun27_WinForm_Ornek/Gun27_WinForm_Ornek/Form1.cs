using Gun27_WinForm_Ornek.Data;

namespace Gun27_WinForm_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NorthwindContext context = new NorthwindContext();

            Category c = new Category();
            c.CategoryName = txtCategoryName.Text;
            c.Description = txtDescription.Text;

            context.Categories.Add(c);
            context.SaveChanges();

            MessageBox.Show(c.CategoryID + " id li kayýt eklendi");

            txtCategoryName.Text = "";
            txtDescription.Text = "";

        }
    }
}
