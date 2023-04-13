using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _authorService = new AuthorManager(new AuthorDal());
        }
        IAuthorService _authorService;
        private void dgwAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            dgwAuthors.DataSource = _authorService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _authorService.Add(new Author
            {
                FirstName=tbxFirstname.Text,
                LastName=tbxLastname.Text,
                PhoneNumber=tbxPhonenumber.Text
            });
            MessageBox.Show("Yazar eklendi!");
            LoadAuthors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _authorService.Update(new Author
            {
                Au_id=dgwAuthors.CurrentRow.Cells[0].Value.ToString(),
                FirstName=tbxFirstname2.Text,
                LastName=tbxLastname2.Text,
                PhoneNumber=tbxPhonenumber2.Text
            });
            MessageBox.Show("Yazar güncellendi!");
            LoadAuthors();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwAuthors.CurrentRow!=null)
            {
                try
                {
                    _authorService.Delete(new Author
                    {
                        Au_id = dgwAuthors.CurrentRow.Cells[0].Value.ToString()
                    }) ;
                }
                catch (Exception exception)
                {

                    throw new Exception(exception.Message);
                }
            }
            
        }

        private void dgwAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFirstname2 = dgwAuthors.CurrentRow.Cells[1].Value.ToString();
            tbxLastname2 = dgwAuthors.CurrentRow.Cells[2].Value.ToString();
            tbxPhonenumber2 = dgwAuthors.CurrentRow.Cells[3].Value.ToString();

        }
    }
}