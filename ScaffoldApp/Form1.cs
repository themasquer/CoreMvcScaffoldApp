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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                startupPath = Application.StartupPath.Replace(@"bin\Debug\net6.0-windows", "").Replace(@"bin\Release\net6.0-windows", "");
                userPath = @"C:\Users\" + Environment.UserName;
                nuget = ".nuget";
                _backup = "_Backup";
                _dbContext = "_DbContext";
                _interface = "_Interface";
                _abstractClass = "_AbstractClass";
                _entityAll = "_EntityAll";
                _modelAll = "_ModelAll";
                nugetPath = nuget + @"\packages\microsoft.visualstudio.web.codegenerators.mvc";
                controllerGeneratorPath = @"Templates\ControllerGenerator";
                viewGeneratorPath = @"Templates\ViewGenerator";
                tbUserPath.Text = userPath;
                UpdateControllerAndViewPaths();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        void UpdateControllerAndViewPaths()
        {
            userDirectories = Directory.GetDirectories(tbUserPath.Text);
            if (!userDirectories.Any(ud => ud.EndsWith(nuget)))
            {
                MessageBox.Show(nuget + " folder could not be found!\n\nPlease use Entity Framework controller scaffolding once in your project for downloading necessary Nuget packages!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbUserPath.Text = userPath;
                return;
            }
            versionedDirectories = Directory.GetDirectories(tbUserPath.Text + @"\" + nugetPath).OrderBy(d => d).ToList();
            lastVersionedDirectory = versionedDirectories.LastOrDefault();
            if (lastVersionedDirectory == null)
            {
                MessageBox.Show("Version directory could not be found!\n\nPlease use Entity Framework controller scaffolding once in your project for downloading necessary Nuget packages!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                tbUserPath.Text = userPath;
                return;
            }
            controllerGeneratorUpdatePath = lastVersionedDirectory + @"\" + controllerGeneratorPath;
            viewGeneratorUpdatePath = lastVersionedDirectory + @"\" + viewGeneratorPath;
            tbControllerPath.Text = controllerGeneratorUpdatePath;
            tbViewPath.Text = viewGeneratorUpdatePath;
        }

        private void bUpdateInterface_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_interface)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_interface, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
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
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_backup)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_backup, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_backup)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_backup, ""));
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
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
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_dbContext)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_dbContext, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
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
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_abstractClass)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_abstractClass, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => !f.Contains(_backup) && !f.Contains(_entityAll) && !f.Contains(_modelAll)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName);
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
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
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_entityAll)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_entityAll, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_entityAll)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_entityAll, ""));
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
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
                UpdateControllerAndViewPaths();
                files = Directory.GetFiles(startupPath + @"\Generators\Controller").Where(f => f.Contains(_modelAll)).ToArray();
                bool found = true;
                foreach (var file in files)
                {
                    sourceFileName = Path.GetFileName(file);
                    destinationFileName = Path.Combine(controllerGeneratorUpdatePath, sourceFileName.Replace(_modelAll, ""));
                    if (!File.Exists(destinationFileName))
                    {
                        found = false;
                        break;
                    }
                    File.Copy(file, destinationFileName, true);
                }
                if (!found)
                {
                    MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    files = Directory.GetFiles(startupPath + @"\Generators\View").Where(f => f.Contains(_modelAll)).ToArray();
                    found = true;
                    foreach (var file in files)
                    {
                        sourceFileName = Path.GetFileName(file);
                        destinationFileName = Path.Combine(viewGeneratorUpdatePath, sourceFileName.Replace(_modelAll, ""));
                        if (!File.Exists(destinationFileName))
                        {
                            found = false;
                            break;
                        }
                        File.Copy(file, destinationFileName, true);
                    }
                    if (!found)
                    {
                        MessageBox.Show("Files copy canceled! Files not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Files copied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured during copying files!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}