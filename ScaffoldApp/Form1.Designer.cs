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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pMain = new System.Windows.Forms.Panel();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bUpdateAllModelAbstractClass = new System.Windows.Forms.Button();
            this.bUpdateAllEntityAbstractClass = new System.Windows.Forms.Button();
            this.bUpdateAbstractClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bDbContext = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.bViewOpen = new System.Windows.Forms.Button();
            this.tbViewPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bControllerOpen = new System.Windows.Forms.Button();
            this.tbControllerPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bUpdateInterface = new System.Windows.Forms.Button();
            this.tbUserPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.bLoginAsVisitor = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tbVersion);
            this.pMain.Controls.Add(this.label6);
            this.pMain.Controls.Add(this.bUpdateAllModelAbstractClass);
            this.pMain.Controls.Add(this.bUpdateAllEntityAbstractClass);
            this.pMain.Controls.Add(this.bUpdateAbstractClass);
            this.pMain.Controls.Add(this.label5);
            this.pMain.Controls.Add(this.label4);
            this.pMain.Controls.Add(this.bDbContext);
            this.pMain.Controls.Add(this.bBackup);
            this.pMain.Controls.Add(this.bViewOpen);
            this.pMain.Controls.Add(this.tbViewPath);
            this.pMain.Controls.Add(this.label3);
            this.pMain.Controls.Add(this.bControllerOpen);
            this.pMain.Controls.Add(this.tbControllerPath);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.bReset);
            this.pMain.Controls.Add(this.bBrowse);
            this.pMain.Controls.Add(this.bUpdateInterface);
            this.pMain.Controls.Add(this.tbUserPath);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(967, 275);
            this.pMain.TabIndex = 20;
            this.pMain.Visible = false;
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(381, 35);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(125, 23);
            this.tbVersion.TabIndex = 39;
            this.tbVersion.TextChanged += new System.EventHandler(this.tbVersion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Microsoft.VisualStudio.Web.CodeGeneration.Design Package Version:";
            // 
            // bUpdateAllModelAbstractClass
            // 
            this.bUpdateAllModelAbstractClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateAllModelAbstractClass.ForeColor = System.Drawing.Color.Red;
            this.bUpdateAllModelAbstractClass.Location = new System.Drawing.Point(575, 64);
            this.bUpdateAllModelAbstractClass.Name = "bUpdateAllModelAbstractClass";
            this.bUpdateAllModelAbstractClass.Size = new System.Drawing.Size(388, 23);
            this.bUpdateAllModelAbstractClass.TabIndex = 37;
            this.bUpdateAllModelAbstractClass.Text = "Update Using Abstract Model Service Class for AppCoreLite";
            this.bUpdateAllModelAbstractClass.UseVisualStyleBackColor = true;
            this.bUpdateAllModelAbstractClass.Visible = false;
            this.bUpdateAllModelAbstractClass.Click += new System.EventHandler(this.bUpdateAllModelAbstractClass_Click);
            // 
            // bUpdateAllEntityAbstractClass
            // 
            this.bUpdateAllEntityAbstractClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateAllEntityAbstractClass.ForeColor = System.Drawing.Color.Red;
            this.bUpdateAllEntityAbstractClass.Location = new System.Drawing.Point(575, 93);
            this.bUpdateAllEntityAbstractClass.Name = "bUpdateAllEntityAbstractClass";
            this.bUpdateAllEntityAbstractClass.Size = new System.Drawing.Size(388, 23);
            this.bUpdateAllEntityAbstractClass.TabIndex = 36;
            this.bUpdateAllEntityAbstractClass.Text = "Update Using Abstract Entity Service Class for AppCoreLite";
            this.bUpdateAllEntityAbstractClass.UseVisualStyleBackColor = true;
            this.bUpdateAllEntityAbstractClass.Visible = false;
            this.bUpdateAllEntityAbstractClass.Click += new System.EventHandler(this.bUpdateAllEntityAbstractClass_Click);
            // 
            // bUpdateAbstractClass
            // 
            this.bUpdateAbstractClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateAbstractClass.ForeColor = System.Drawing.Color.Red;
            this.bUpdateAbstractClass.Location = new System.Drawing.Point(319, 64);
            this.bUpdateAbstractClass.Name = "bUpdateAbstractClass";
            this.bUpdateAbstractClass.Size = new System.Drawing.Size(250, 23);
            this.bUpdateAbstractClass.TabIndex = 35;
            this.bUpdateAbstractClass.Text = "Update Using Abstract Service Class";
            this.bUpdateAbstractClass.UseVisualStyleBackColor = true;
            this.bUpdateAbstractClass.Visible = false;
            this.bUpdateAbstractClass.Click += new System.EventHandler(this.bUpdateAbstractClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "If the problem is not solved, update Visual Studio with Visual Studio Installer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(947, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "If you have any problems about scaffolding with Entity Framework in your MVC Appl" +
    "ication, first update all your Nuget Packages in all projects in the solution to" +
    " the latest version.";
            // 
            // bDbContext
            // 
            this.bDbContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDbContext.ForeColor = System.Drawing.Color.Red;
            this.bDbContext.Location = new System.Drawing.Point(319, 93);
            this.bDbContext.Name = "bDbContext";
            this.bDbContext.Size = new System.Drawing.Size(250, 23);
            this.bDbContext.TabIndex = 32;
            this.bDbContext.Text = "Update With DbContext";
            this.bDbContext.UseVisualStyleBackColor = true;
            this.bDbContext.Visible = false;
            this.bDbContext.Click += new System.EventHandler(this.bDbContext_Click);
            // 
            // bBackup
            // 
            this.bBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBackup.ForeColor = System.Drawing.Color.Red;
            this.bBackup.Location = new System.Drawing.Point(3, 93);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(310, 23);
            this.bBackup.TabIndex = 31;
            this.bBackup.Text = "Restore Microsoft Backup Files";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bViewOpen
            // 
            this.bViewOpen.Location = new System.Drawing.Point(888, 174);
            this.bViewOpen.Name = "bViewOpen";
            this.bViewOpen.Size = new System.Drawing.Size(75, 23);
            this.bViewOpen.TabIndex = 30;
            this.bViewOpen.Text = "Open";
            this.bViewOpen.UseVisualStyleBackColor = true;
            this.bViewOpen.Click += new System.EventHandler(this.bViewOpen_Click);
            // 
            // tbViewPath
            // 
            this.tbViewPath.Location = new System.Drawing.Point(171, 174);
            this.tbViewPath.Name = "tbViewPath";
            this.tbViewPath.ReadOnly = true;
            this.tbViewPath.Size = new System.Drawing.Size(711, 23);
            this.tbViewPath.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Scaffolding View Folder:";
            // 
            // bControllerOpen
            // 
            this.bControllerOpen.Location = new System.Drawing.Point(888, 145);
            this.bControllerOpen.Name = "bControllerOpen";
            this.bControllerOpen.Size = new System.Drawing.Size(75, 23);
            this.bControllerOpen.TabIndex = 27;
            this.bControllerOpen.Text = "Open";
            this.bControllerOpen.UseVisualStyleBackColor = true;
            this.bControllerOpen.Click += new System.EventHandler(this.bControllerOpen_Click);
            // 
            // tbControllerPath
            // 
            this.tbControllerPath.Location = new System.Drawing.Point(171, 145);
            this.tbControllerPath.Name = "tbControllerPath";
            this.tbControllerPath.ReadOnly = true;
            this.tbControllerPath.Size = new System.Drawing.Size(711, 23);
            this.tbControllerPath.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Scaffolding Controller Folder:";
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(888, 5);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 24;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(807, 5);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 23;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bUpdateInterface
            // 
            this.bUpdateInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateInterface.ForeColor = System.Drawing.Color.Red;
            this.bUpdateInterface.Location = new System.Drawing.Point(3, 64);
            this.bUpdateInterface.Name = "bUpdateInterface";
            this.bUpdateInterface.Size = new System.Drawing.Size(310, 23);
            this.bUpdateInterface.TabIndex = 22;
            this.bUpdateInterface.Text = "Update Using Service Interface";
            this.bUpdateInterface.UseVisualStyleBackColor = true;
            this.bUpdateInterface.Click += new System.EventHandler(this.bUpdateInterface_Click);
            // 
            // tbUserPath
            // 
            this.tbUserPath.Location = new System.Drawing.Point(130, 6);
            this.tbUserPath.Name = "tbUserPath";
            this.tbUserPath.ReadOnly = true;
            this.tbUserPath.Size = new System.Drawing.Size(671, 23);
            this.tbUserPath.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Windows User Folder:";
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.bLoginAsVisitor);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbUserName);
            this.pLogin.Controls.Add(this.label8);
            this.pLogin.Controls.Add(this.label7);
            this.pLogin.Location = new System.Drawing.Point(12, 293);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(967, 95);
            this.pLogin.TabIndex = 21;
            // 
            // bLoginAsVisitor
            // 
            this.bLoginAsVisitor.Location = new System.Drawing.Point(77, 64);
            this.bLoginAsVisitor.Name = "bLoginAsVisitor";
            this.bLoginAsVisitor.Size = new System.Drawing.Size(106, 23);
            this.bLoginAsVisitor.TabIndex = 43;
            this.bLoginAsVisitor.Text = "Login as Visitor";
            this.bLoginAsVisitor.UseVisualStyleBackColor = true;
            this.bLoginAsVisitor.Click += new System.EventHandler(this.bLoginAsVisitor_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(189, 64);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(88, 23);
            this.bLogin.TabIndex = 42;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(77, 35);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(200, 23);
            this.tbPassword.TabIndex = 41;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(77, 6);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(200, 23);
            this.tbUserName.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "User Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 394);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scaffold App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel pMain;
        private Panel pLogin;
        private Button bLogin;
        private TextBox tbPassword;
        private TextBox tbUserName;
        private Label label8;
        private Label label7;
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
        private Button bLoginAsVisitor;
    }
}