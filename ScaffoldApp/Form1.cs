using System.Diagnostics;

namespace ScaffoldApp
{
    public partial class Form1 : Form
    {
        string startupPath;
        string userPath;
        string nuget;
        string _backup;
        string _dbContext;
        string _interface;
        string _abstractClass;
        string _entityAll;
        string _modelAll;
        string _templates;
        string[] userDirectories;
        string nugetPath;
        string controllerGeneratorPath;
        string controllerGeneratorUpdatePath;
        string viewGeneratorPath;
        string viewGeneratorUpdatePath;
        string lastVersionedDirectory;
        string sourceFileName;
        string destinationFileName;
        string[] files;
        List<string> versionedDirectories;
        List<string> controllerGeneratorUpdateFolders;
        List<string> viewGeneratorUpdateFolders;
        const string ADMINUSERNAME = "admin";
        const string ADMINPASSWORD = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pLogin.Location = new Point(12, 12);
                this.Size = new Size(1005, 333);
                startupPath = Application.StartupPath.Replace(@"bin\Debug\net6.0-windows", "").Replace(@"bin\Release\net6.0-windows", "");
                userPath = @"C:\Users\" + Environment.UserName;
                nuget = ".nuget";
                _backup = "_Backup";
                _dbContext = "_DbContext";
                _interface = "_Interface";
                _abstractClass = "_AbstractClass";
                _entityAll = "_EntityAll";
                _modelAll = "_ModelAll";
                _templates = "Templates";
                nugetPath = nuget + @"\packages\microsoft.visualstudio.web.codegenerators.mvc";
                controllerGeneratorPath = _templates + @"\ControllerGenerator";
                viewGeneratorPath = _templates + @"\ViewGenerator";
                tbUserPath.Text = userPath;
                UpdateControllerAndViewPaths();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        void UpdateControllerAndViewPaths(bool formLoad = true)
        {
            if (formLoad)
            {
                userDirectories = Directory.GetDirectories(tbUserPath.Text);
                if (!userDirectories.Any(ud => ud.EndsWith(nuget)))
                {
                    MessageBox.Show(nuget + " folder could not be found!\n\nPlease use Entity Framework controller scaffolding once in your project!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    tbUserPath.Text = userPath;
                    return;
                }
                versionedDirectories = Directory.GetDirectories(tbUserPath.Text + @"\" + nugetPath).OrderBy(d => Convert.ToInt32(d.Split('\\').LastOrDefault().Split('.')[0])).ToList();
                if (versionedDirectories == null || versionedDirectories.Count == 0)
                {
                    MessageBox.Show("Version directories could not be found!\n\nPlease use Entity Framework controller scaffolding once in your project!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    tbUserPath.Text = userPath;
                    return;
                }
                lastVersionedDirectory = versionedDirectories.LastOrDefault();
                if (lastVersionedDirectory == null)
                {
                    MessageBox.Show("Version directory could not be found!\n\nPlease use Entity Framework controller scaffolding once in your project!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    tbUserPath.Text = userPath;
                    return;
                }
                tbVersion.Text = lastVersionedDirectory.Split('\\').LastOrDefault();
                controllerGeneratorUpdatePath = lastVersionedDirectory + @"\" + controllerGeneratorPath;
                viewGeneratorUpdatePath = lastVersionedDirectory + @"\" + viewGeneratorPath;
                tbControllerPath.Text = controllerGeneratorUpdatePath;
                tbViewPath.Text = viewGeneratorUpdatePath;
                controllerGeneratorUpdateFolders = controllerGeneratorUpdatePath.Split('\\').ToList();
                viewGeneratorUpdateFolders = viewGeneratorUpdatePath.Split('\\').ToList();
            }
            else
            {
                controllerGeneratorUpdatePath = tbControllerPath.Text;
                viewGeneratorUpdatePath = tbViewPath.Text;
            }
        }

        private void bUpdateInterface_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_interface)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_interface, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    tbUserPath.Text = folderBrowserDialog1.SelectedPath;
                    UpdateControllerAndViewPaths();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            try
            {
                tbUserPath.Text = userPath;
                UpdateControllerAndViewPaths();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bControllerOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tbControllerPath.Text))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = tbControllerPath.Text,
                        FileName = "explorer.exe"
                    };
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("Directory could not be found!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bViewOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tbViewPath.Text))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = tbViewPath.Text,
                        FileName = "explorer.exe"
                    };
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("Directory could not be found!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bBackup_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_backup)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_backup, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_backup)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_backup, ""));
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bDbContext_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_dbContext)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_dbContext, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bUpdateAbstractClass_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_abstractClass)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_abstractClass, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bUpdateAllEntityAbstractClass_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_entityAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_entityAll, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_entityAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_entityAll, ""));
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bUpdateAllModelAbstractClass_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths(false);
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_modelAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_modelAll, ""));
                    File.Copy(file, destinationFileName, true);
                }
                files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_modelAll)).ToArray();
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_modelAll, ""));
                    File.Copy(file, destinationFileName, true);
                }
                MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void tbVersion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(controllerGeneratorUpdatePath))
            {
                controllerGeneratorUpdateFolders[controllerGeneratorUpdateFolders.IndexOf(_templates) - 1] = tbVersion.Text.Trim();
                controllerGeneratorUpdatePath = string.Join(@"\", controllerGeneratorUpdateFolders);
                tbControllerPath.Text = controllerGeneratorUpdatePath;
            }
            if (!string.IsNullOrWhiteSpace(viewGeneratorUpdatePath))
            {
                viewGeneratorUpdateFolders[viewGeneratorUpdateFolders.IndexOf(_templates) - 1] = tbVersion.Text.Trim();
                viewGeneratorUpdatePath = string.Join(@"\", viewGeneratorUpdateFolders);
                tbViewPath.Text = viewGeneratorUpdatePath;
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (!(tbUserName.Text == ADMINUSERNAME && tbPassword.Text == ADMINPASSWORD))
            {
                MessageBox.Show("Invalid user name or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            bDbContext.Visible = true;
            bUpdateAbstractClass.Visible = true;
            bUpdateAllModelAbstractClass.Visible = true;
            bUpdateAllEntityAbstractClass.Visible = true;
            pLogin.Visible = false;
            pMain.Visible = true;
        }

        private void bLoginAsVisitor_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pMain.Visible = true;
        }

        private void bUpdateInterface_Click_1(object sender, EventArgs e)
        {

        }

        private void bBackup_Click_1(object sender, EventArgs e)
        {

        }

        private void bUpdateAbstractClass_Click_1(object sender, EventArgs e)
        {

        }
    }
}