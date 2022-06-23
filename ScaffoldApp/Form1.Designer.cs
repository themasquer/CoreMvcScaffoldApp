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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserPath = new System.Windows.Forms.TextBox();
            this.bUpdateInterface = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbControllerPath = new System.Windows.Forms.TextBox();
            this.bControllerOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbViewPath = new System.Windows.Forms.TextBox();
            this.bViewOpen = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.bDbContext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bUpdateAbstractClass = new System.Windows.Forms.Button();
            this.bUpdateAllAbstractClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows User Folder:";
            // 
            // tbUserPath
            // 
            this.tbUserPath.Location = new System.Drawing.Point(139, 12);
            this.tbUserPath.Name = "tbUserPath";
            this.tbUserPath.ReadOnly = true;
            this.tbUserPath.Size = new System.Drawing.Size(671, 23);
            this.tbUserPath.TabIndex = 1;
            // 
            // bUpdateInterface
            // 
            this.bUpdateInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateInterface.ForeColor = System.Drawing.Color.Red;
            this.bUpdateInterface.Location = new System.Drawing.Point(12, 99);
            this.bUpdateInterface.Name = "bUpdateInterface";
            this.bUpdateInterface.Size = new System.Drawing.Size(403, 23);
            this.bUpdateInterface.TabIndex = 2;
            this.bUpdateInterface.Text = "Update Modified Files Using Service Interface";
            this.bUpdateInterface.UseVisualStyleBackColor = true;
            this.bUpdateInterface.Click += new System.EventHandler(this.bUpdateInterface_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(816, 11);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 3;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(897, 11);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scaffolding Controller Folder:";
            // 
            // tbControllerPath
            // 
            this.tbControllerPath.Location = new System.Drawing.Point(180, 151);
            this.tbControllerPath.Name = "tbControllerPath";
            this.tbControllerPath.ReadOnly = true;
            this.tbControllerPath.Size = new System.Drawing.Size(711, 23);
            this.tbControllerPath.TabIndex = 6;
            // 
            // bControllerOpen
            // 
            this.bControllerOpen.Location = new System.Drawing.Point(897, 151);
            this.bControllerOpen.Name = "bControllerOpen";
            this.bControllerOpen.Size = new System.Drawing.Size(75, 23);
            this.bControllerOpen.TabIndex = 7;
            this.bControllerOpen.Text = "Open";
            this.bControllerOpen.UseVisualStyleBackColor = true;
            this.bControllerOpen.Click += new System.EventHandler(this.bControllerOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scaffolding View Folder:";
            // 
            // tbViewPath
            // 
            this.tbViewPath.Location = new System.Drawing.Point(180, 180);
            this.tbViewPath.Name = "tbViewPath";
            this.tbViewPath.ReadOnly = true;
            this.tbViewPath.Size = new System.Drawing.Size(711, 23);
            this.tbViewPath.TabIndex = 9;
            // 
            // bViewOpen
            // 
            this.bViewOpen.Location = new System.Drawing.Point(897, 180);
            this.bViewOpen.Name = "bViewOpen";
            this.bViewOpen.Size = new System.Drawing.Size(75, 23);
            this.bViewOpen.TabIndex = 10;
            this.bViewOpen.Text = "Open";
            this.bViewOpen.UseVisualStyleBackColor = true;
            this.bViewOpen.Click += new System.EventHandler(this.bViewOpen_Click);
            // 
            // bBackup
            // 
            this.bBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBackup.ForeColor = System.Drawing.Color.Red;
            this.bBackup.Location = new System.Drawing.Point(677, 41);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(295, 23);
            this.bBackup.TabIndex = 11;
            this.bBackup.Text = "Restore Microsoft Backup Files";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bDbContext
            // 
            this.bDbContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDbContext.ForeColor = System.Drawing.Color.Red;
            this.bDbContext.Location = new System.Drawing.Point(421, 41);
            this.bDbContext.Name = "bDbContext";
            this.bDbContext.Size = new System.Drawing.Size(250, 23);
            this.bDbContext.TabIndex = 12;
            this.bDbContext.Text = "Update Modified Files With DbContext";
            this.bDbContext.UseVisualStyleBackColor = true;
            this.bDbContext.Click += new System.EventHandler(this.bDbContext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(947, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "If you have any problems about scaffolding with Entity Framework in your MVC Appl" +
    "ication, first update all your Nuget Packages in all projects in the solution to" +
    " the latest version.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "If the problem is not solved, update Visual Studio with Visual Studio Installer.";
            // 
            // bUpdateAbstractClass
            // 
            this.bUpdateAbstractClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateAbstractClass.ForeColor = System.Drawing.Color.Red;
            this.bUpdateAbstractClass.Location = new System.Drawing.Point(12, 70);
            this.bUpdateAbstractClass.Name = "bUpdateAbstractClass";
            this.bUpdateAbstractClass.Size = new System.Drawing.Size(403, 23);
            this.bUpdateAbstractClass.TabIndex = 15;
            this.bUpdateAbstractClass.Text = "Update Modified Files Using Abstract Service Class";
            this.bUpdateAbstractClass.UseVisualStyleBackColor = true;
            this.bUpdateAbstractClass.Click += new System.EventHandler(this.bUpdateAbstractClass_Click);
            // 
            // bUpdateAllAbstractClass
            // 
            this.bUpdateAllAbstractClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdateAllAbstractClass.ForeColor = System.Drawing.Color.Red;
            this.bUpdateAllAbstractClass.Location = new System.Drawing.Point(12, 41);
            this.bUpdateAllAbstractClass.Name = "bUpdateAllAbstractClass";
            this.bUpdateAllAbstractClass.Size = new System.Drawing.Size(403, 23);
            this.bUpdateAllAbstractClass.TabIndex = 16;
            this.bUpdateAllAbstractClass.Text = "Update Modified Files Using Abstract Service Class for AppCore";
            this.bUpdateAllAbstractClass.UseVisualStyleBackColor = true;
            this.bUpdateAllAbstractClass.Click += new System.EventHandler(this.bUpdateAllAbstractClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 281);
            this.Controls.Add(this.bUpdateAllAbstractClass);
            this.Controls.Add(this.bUpdateAbstractClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bDbContext);
            this.Controls.Add(this.bBackup);
            this.Controls.Add(this.bViewOpen);
            this.Controls.Add(this.tbViewPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bControllerOpen);
            this.Controls.Add(this.tbControllerPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bUpdateInterface);
            this.Controls.Add(this.tbUserPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Scaffold App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbUserPath;
        private Button bUpdateInterface;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button bBrowse;
        private Button bReset;
        private Label label2;
        private TextBox tbControllerPath;
        private Button bControllerOpen;
        private Label label3;
        private TextBox tbViewPath;
        private Button bViewOpen;
        private Button bBackup;
        private Button bDbContext;
        private Label label4;
        private Label label5;
        private Button bUpdateAbstractClass;
        private Button bUpdateAllAbstractClass;
    }
}