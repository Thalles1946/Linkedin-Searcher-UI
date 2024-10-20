using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO.Packaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Linkedin_Searcher_UI
{
    public partial class Main : Form
    {

        private string email = "";
        private string password = "";
        private string searchTerms = "";
        private int pages = 0;
        static List<Perfil> perfis = [];
        private int maxPages = 1;



        static WebDriver driver = new ChromeDriver();

        public Main()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchTerms = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button3.Enabled = false;
            numericUpDown1.Enabled = false;
            button2.Enabled = true;
            navigation();

        }

        private void navigation()
        {
            driver.Navigate().GoToUrl("https://linkedin.com/login");
            var usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys(email);
            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys(password);
            var loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            loginButton.Click();
            progressBar1.Maximum = maxPages;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            try
            {

                while (pages < maxPages)
                {
                    if (pages == 0)
                    {

                        driver.Navigate().GoToUrl($"https://www.linkedin.com/search/results/people/?keywords={System.Web.HttpUtility.UrlEncode(searchTerms)}");
                    }
                    else
                    {
                        driver.Navigate().GoToUrl($"https://www.linkedin.com/search/results/people/?keywords={System.Web.HttpUtility.UrlEncode(searchTerms)}&page={pages + 1}");

                    }
                    Thread.Sleep(3000);
                    getNames();
                    pages++;
                    progressBar1.Value = progressBar1.Value + 1;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                driver.Close();
            }
            finally
            {
                driver.Close();
                label10.Text = "Busca concluída! Selecione o local para salvar o arquivo excel com os perfis";

                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {


                    ExcelPackage package = new ExcelPackage();

                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Perfis");

                    worksheet.Cells[1, 1].Value = "Nome";
                    worksheet.Cells[1, 2].Value = "URL";

                    for (int i = 0; i < perfis.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = perfis[i].Name;

                        worksheet.Cells[i + 2, 2].Hyperlink = new Uri(perfis[i].Url);

                        worksheet.Cells[i + 2, 2].Value = perfis[i].Url;

                    }

                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    {


                        string filePath = System.IO.Path.Combine(dialog.SelectedPath, "Perfis.xlsx");

                        package.SaveAs(filePath);
                    }
                }

            }
        }

        static void getNames()
        {

            List<string> newNames = new List<string>();


            var profileNames = driver.FindElements(By.XPath("//a[@class='app-aware-link ']/span/span"));
            var profileLinks = driver.FindElements(By.XPath("//div[@class='t-roman t-sans']/div/span/span/a"));
            foreach (var item in profileNames)
            {
                if (!item.Text.Contains("Ver perfil"))
                {
                    newNames.Add(item.Text);
                }
            }

            for (int i = 0; i < newNames.Count; i++)
            {
                if (!newNames[i].Equals("Usuário do LinkedIn"))
                {

                    Perfil newPerfil = new Perfil();
                    newPerfil.Name = newNames[i];
                    newPerfil.Url = profileLinks[i].GetAttribute("href");
                    perfis.Add(newPerfil);
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            //progressBar1.
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            maxPages = (int)numericUpDown1.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
