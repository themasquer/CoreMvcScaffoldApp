namespace ScaffoldApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            pMain = new Panel();
            pOther = new Panel();
            bUpdateAbstractClass = new Button();
            bUpdateInterface = new Button();
            bDbContext = new Button();
            bUpdateAllModelAbstractClass = new Button();
            bUpdateAllEntityAbstractClass = new Button();
            bUpdateEntityService = new Button();
            tbVersion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            bBackup = new Button();
            bViewOpen = new Button();
            tbViewPath = new TextBox();
            label3 = new Label();
            bControllerOpen = new Button();
            tbControllerPath = new TextBox();
            label2 = new Label();
            bReset = new Button();
            bBrowse = new Button();
            tbUserPath = new TextBox();
            label1 = new Label();
            pMain.SuspendLayout();
            pOther.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(pOther);
            pMain.Controls.Add(bUpdateEntityService);
            pMain.Controls.Add(tbVersion);
            pMain.Controls.Add(label6);
            pMain.Controls.Add(label5);
            pMain.Controls.Add(label4);
            pMain.Controls.Add(bBackup);
            pMain.Controls.Add(bViewOpen);
            pMain.Controls.Add(tbViewPath);
            pMain.Controls.Add(label3);
            pMain.Controls.Add(bControllerOpen);
            pMain.Controls.Add(tbControllerPath);
            pMain.Controls.Add(label2);
            pMain.Controls.Add(bReset);
            pMain.Controls.Add(bBrowse);
            pMain.Controls.Add(tbUserPath);
            pMain.Controls.Add(label1);
            pMain.Location = new Point(12, 12);
            pMain.Name = "pMain";
            pMain.Size = new Size(967, 320);
            pMain.TabIndex = 20;
            // 
            // pOther
            // 
            pOther.Controls.Add(bUpdateAbstractClass);
            pOther.Controls.Add(bUpdateInterface);
            pOther.Controls.Add(bDbContext);
            pOther.Controls.Add(bUpdateAllModelAbstractClass);
            pOther.Controls.Add(bUpdateAllEntityAbstractClass);
            pOther.Location = new Point(8, 102);
            pOther.Name = "pOther";
            pOther.Size = new Size(955, 76);
            pOther.TabIndex = 41;
            pOther.Visible = false;
            // 
            // bUpdateAbstractClass
            // 
            bUpdateAbstractClass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdateAbstractClass.ForeColor = Color.Red;
            bUpdateAbstractClass.Location = new Point(9, 12);
            bUpdateAbstractClass.Name = "bUpdateAbstractClass";
            bUpdateAbstractClass.Size = new Size(350, 23);
            bUpdateAbstractClass.TabIndex = 35;
            bUpdateAbstractClass.Text = "Update Using Abstract Service Class";
            bUpdateAbstractClass.UseVisualStyleBackColor = true;
            bUpdateAbstractClass.Click += bUpdateAbstractClass_Click;
            // 
            // bUpdateInterface
            // 
            bUpdateInterface.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdateInterface.ForeColor = Color.Red;
            bUpdateInterface.Location = new Point(365, 12);
            bUpdateInterface.Name = "bUpdateInterface";
            bUpdateInterface.Size = new Size(350, 23);
            bUpdateInterface.TabIndex = 22;
            bUpdateInterface.Text = "Update Using Service Interface";
            bUpdateInterface.UseVisualStyleBackColor = true;
            bUpdateInterface.Click += bUpdateInterface_Click;
            // 
            // bDbContext
            // 
            bDbContext.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bDbContext.ForeColor = Color.Red;
            bDbContext.Location = new Point(721, 12);
            bDbContext.Name = "bDbContext";
            bDbContext.Size = new Size(226, 23);
            bDbContext.TabIndex = 32;
            bDbContext.Text = "Update With DbContext";
            bDbContext.UseVisualStyleBackColor = true;
            bDbContext.Click += bDbContext_Click;
            // 
            // bUpdateAllModelAbstractClass
            // 
            bUpdateAllModelAbstractClass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdateAllModelAbstractClass.ForeColor = Color.Red;
            bUpdateAllModelAbstractClass.Location = new Point(365, 41);
            bUpdateAllModelAbstractClass.Name = "bUpdateAllModelAbstractClass";
            bUpdateAllModelAbstractClass.Size = new Size(350, 23);
            bUpdateAllModelAbstractClass.TabIndex = 37;
            bUpdateAllModelAbstractClass.Text = "Update Using Abstract Model Service Class for AppCoreLite";
            bUpdateAllModelAbstractClass.UseVisualStyleBackColor = true;
            bUpdateAllModelAbstractClass.Click += bUpdateAllModelAbstractClass_Click;
            // 
            // bUpdateAllEntityAbstractClass
            // 
            bUpdateAllEntityAbstractClass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdateAllEntityAbstractClass.ForeColor = Color.Red;
            bUpdateAllEntityAbstractClass.Location = new Point(9, 41);
            bUpdateAllEntityAbstractClass.Name = "bUpdateAllEntityAbstractClass";
            bUpdateAllEntityAbstractClass.Size = new Size(350, 23);
            bUpdateAllEntityAbstractClass.TabIndex = 36;
            bUpdateAllEntityAbstractClass.Text = "Update Using Abstract Entity Service Class for AppCoreLite";
            bUpdateAllEntityAbstractClass.UseVisualStyleBackColor = true;
            bUpdateAllEntityAbstractClass.Click += bUpdateAllEntityAbstractClass_Click;
            // 
            // bUpdateEntityService
            // 
            bUpdateEntityService.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdateEntityService.ForeColor = Color.Red;
            bUpdateEntityService.Location = new Point(12, 73);
            bUpdateEntityService.Name = "bUpdateEntityService";
            bUpdateEntityService.Size = new Size(350, 23);
            bUpdateEntityService.TabIndex = 40;
            bUpdateEntityService.Text = "Update Using Entity Service Class";
            bUpdateEntityService.UseVisualStyleBackColor = true;
            bUpdateEntityService.Click += bUpdateEntityService_Click;
            // 
            // tbVersion
            // 
            tbVersion.Location = new Point(381, 35);
            tbVersion.Name = "tbVersion";
            tbVersion.Size = new Size(125, 23);
            tbVersion.TabIndex = 39;
            tbVersion.TextChanged += tbVersion_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 38);
            label6.Name = "label6";
            label6.Size = new Size(372, 15);
            label6.TabIndex = 38;
            label6.Text = "Microsoft.VisualStudio.Web.CodeGeneration.Design Package Version:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 295);
            label5.Name = "label5";
            label5.Size = new Size(409, 15);
            label5.TabIndex = 34;
            label5.Text = "If the problem is not solved, update Visual Studio with Visual Studio Installer.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 271);
            label4.Name = "label4";
            label4.Size = new Size(947, 15);
            label4.TabIndex = 33;
            label4.Text = "If you have any problems about scaffolding with Entity Framework in your MVC Application, first update all your Nuget Packages in all projects in the solution to the latest version.";
            // 
            // bBackup
            // 
            bBackup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bBackup.ForeColor = Color.Red;
            bBackup.Location = new Point(368, 73);
            bBackup.Name = "bBackup";
            bBackup.Size = new Size(350, 23);
            bBackup.TabIndex = 31;
            bBackup.Text = "Restore Microsoft Backup Files";
            bBackup.UseVisualStyleBackColor = true;
            bBackup.Click += bBackup_Click;
            // 
            // bViewOpen
            // 
            bViewOpen.Location = new Point(888, 219);
            bViewOpen.Name = "bViewOpen";
            bViewOpen.Size = new Size(75, 23);
            bViewOpen.TabIndex = 30;
            bViewOpen.Text = "Open";
            bViewOpen.UseVisualStyleBackColor = true;
            bViewOpen.Click += bViewOpen_Click;
            // 
            // tbViewPath
            // 
            tbViewPath.Location = new Point(171, 219);
            tbViewPath.Name = "tbViewPath";
            tbViewPath.ReadOnly = true;
            tbViewPath.Size = new Size(711, 23);
            tbViewPath.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 222);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 28;
            label3.Text = "Scaffolding View Folder:";
            // 
            // bControllerOpen
            // 
            bControllerOpen.Location = new Point(888, 190);
            bControllerOpen.Name = "bControllerOpen";
            bControllerOpen.Size = new Size(75, 23);
            bControllerOpen.TabIndex = 27;
            bControllerOpen.Text = "Open";
            bControllerOpen.UseVisualStyleBackColor = true;
            bControllerOpen.Click += bControllerOpen_Click;
            // 
            // tbControllerPath
            // 
            tbControllerPath.Location = new Point(171, 190);
            tbControllerPath.Name = "tbControllerPath";
            tbControllerPath.ReadOnly = true;
            tbControllerPath.Size = new Size(711, 23);
            tbControllerPath.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 193);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 25;
            label2.Text = "Scaffolding Controller Folder:";
            // 
            // bReset
            // 
            bReset.Location = new Point(888, 5);
            bReset.Name = "bReset";
            bReset.Size = new Size(75, 23);
            bReset.TabIndex = 24;
            bReset.Text = "Reset";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // bBrowse
            // 
            bBrowse.Location = new Point(807, 5);
            bBrowse.Name = "bBrowse";
            bBrowse.Size = new Size(75, 23);
            bBrowse.TabIndex = 23;
            bBrowse.Text = "Browse";
            bBrowse.UseVisualStyleBackColor = true;
            bBrowse.Click += bBrowse_Click;
            // 
            // tbUserPath
            // 
            tbUserPath.Location = new Point(130, 6);
            tbUserPath.Name = "tbUserPath";
            tbUserPath.ReadOnly = true;
            tbUserPath.Size = new Size(671, 23);
            tbUserPath.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 20;
            label1.Text = "Windows User Folder:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 341);
            Controls.Add(pMain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scaffold App";
            Load += Form1_Load;
            pMain.ResumeLayout(false);
            pMain.PerformLayout();
            pOther.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel pMain;
        private TextBox tbVersion;
        private Label label6;
        private Button bUpdateAllModelAbstractClass;
        private Button bUpdateAllEntityAbstractClass;
        private Button bUpdateAbstractClass;
        private Label label5;
        private Label label4;
        private Button bDbContext;
        private Button bBackup;
        private Button bViewOpen;
        private TextBox tbViewPath;
        private Label label3;
        private Button bControllerOpen;
        private TextBox tbControllerPath;
        private Label label2;
        private Button bReset;
        private Button bBrowse;
        private Button bUpdateInterface;
        private TextBox tbUserPath;
        private Label label1;
        private Button bUpdateEntityService;
        private Panel pOther;
    }
}