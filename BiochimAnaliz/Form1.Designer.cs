namespace BiochimAnaliz
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lbDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbPH = new System.Windows.Forms.Label();
            this.lbGlucose = new System.Windows.Forms.Label();
            this.lbAlbumen = new System.Windows.Forms.Label();
            this.lbKetones = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.tbGlucose = new System.Windows.Forms.TextBox();
            this.tbAlbumen = new System.Windows.Forms.TextBox();
            this.tbKetones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPregnancy = new System.Windows.Forms.CheckBox();
            this.tbCreatinine = new System.Windows.Forms.TextBox();
            this.tbUrobilinogen = new System.Windows.Forms.TextBox();
            this.tbNitrite = new System.Windows.Forms.TextBox();
            this.lbCreatinine = new System.Windows.Forms.Label();
            this.lbUrobilinogen = new System.Windows.Forms.Label();
            this.lbNitrite = new System.Windows.Forms.Label();
            this.tbSodium = new System.Windows.Forms.TextBox();
            this.lbSodium = new System.Windows.Forms.Label();
            this.tbPotassium = new System.Windows.Forms.TextBox();
            this.tbChlorides = new System.Windows.Forms.TextBox();
            this.lbPotassium = new System.Windows.Forms.Label();
            this.lbChlorides = new System.Windows.Forms.Label();
            this.gbElectrolytes = new System.Windows.Forms.GroupBox();
            this.tbPH = new System.Windows.Forms.TextBox();
            this.menuStrip3.SuspendLayout();
            this.gbElectrolytes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1264, 56);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem,
            this.exportFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(132, 52);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(456, 66);
            this.importFileToolStripMenuItem.Text = "Імпорт даних";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.ImportFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(456, 66);
            this.exportFileToolStripMenuItem.Text = "Експорт даних";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.ExportFileToolStripMenuItem_Click);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(52, 74);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(68, 37);
            this.lbFullName.TabIndex = 6;
            this.lbFullName.Text = "ПІБ";
            // 
            // tbFullName
            // 
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Location = new System.Drawing.Point(59, 126);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(551, 44);
            this.tbFullName.TabIndex = 7;
            this.tbFullName.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullName_KeyPress);
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(52, 211);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(269, 37);
            this.lbDOB.TabIndex = 8;
            this.lbDOB.Text = "Дата народження";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd.MM.yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(59, 267);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 7, 5, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(262, 44);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.Value = new System.DateTime(2023, 7, 5, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(792, 74);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(101, 37);
            this.lbGender.TabIndex = 10;
            this.lbGender.Text = "Стать";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(799, 126);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(379, 45);
            this.cbGender.TabIndex = 11;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.SetGender);
            this.cbGender.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lbPH
            // 
            this.lbPH.AutoSize = true;
            this.lbPH.Location = new System.Drawing.Point(52, 435);
            this.lbPH.Margin = new System.Windows.Forms.Padding(3);
            this.lbPH.Name = "lbPH";
            this.lbPH.Size = new System.Drawing.Size(235, 37);
            this.lbPH.TabIndex = 12;
            this.lbPH.Text = "Кислотність pH";
            // 
            // lbGlucose
            // 
            this.lbGlucose.AutoSize = true;
            this.lbGlucose.Location = new System.Drawing.Point(52, 535);
            this.lbGlucose.Margin = new System.Windows.Forms.Padding(3);
            this.lbGlucose.Name = "lbGlucose";
            this.lbGlucose.Size = new System.Drawing.Size(261, 37);
            this.lbGlucose.TabIndex = 14;
            this.lbGlucose.Text = "Глюкоза ммоль/л";
            // 
            // lbAlbumen
            // 
            this.lbAlbumen.AutoSize = true;
            this.lbAlbumen.Location = new System.Drawing.Point(52, 635);
            this.lbAlbumen.Margin = new System.Windows.Forms.Padding(3);
            this.lbAlbumen.Name = "lbAlbumen";
            this.lbAlbumen.Size = new System.Drawing.Size(139, 37);
            this.lbAlbumen.TabIndex = 16;
            this.lbAlbumen.Text = "Білок г/л";
            // 
            // lbKetones
            // 
            this.lbKetones.AutoSize = true;
            this.lbKetones.Location = new System.Drawing.Point(52, 737);
            this.lbKetones.Margin = new System.Windows.Forms.Padding(3);
            this.lbKetones.Name = "lbKetones";
            this.lbKetones.Size = new System.Drawing.Size(245, 37);
            this.lbKetones.TabIndex = 18;
            this.lbKetones.Text = "Кетони ммоль/л";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(649, 1045);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(551, 137);
            this.btnGenerateReport.TabIndex = 52;
            this.btnGenerateReport.Text = "Створити звіт";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(59, 1045);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(551, 137);
            this.btnClearForm.TabIndex = 53;
            this.btnClearForm.Text = "Очистити форму";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // tbGlucose
            // 
            this.tbGlucose.Location = new System.Drawing.Point(360, 530);
            this.tbGlucose.Name = "tbGlucose";
            this.tbGlucose.Size = new System.Drawing.Size(250, 44);
            this.tbGlucose.TabIndex = 55;
            this.tbGlucose.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbGlucose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // tbAlbumen
            // 
            this.tbAlbumen.Location = new System.Drawing.Point(360, 630);
            this.tbAlbumen.Name = "tbAlbumen";
            this.tbAlbumen.Size = new System.Drawing.Size(250, 44);
            this.tbAlbumen.TabIndex = 56;
            this.tbAlbumen.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbAlbumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // tbKetones
            // 
            this.tbKetones.Location = new System.Drawing.Point(360, 730);
            this.tbKetones.Name = "tbKetones";
            this.tbKetones.Size = new System.Drawing.Size(250, 44);
            this.tbKetones.TabIndex = 57;
            this.tbKetones.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbKetones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(60, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1140, 3);
            this.label6.TabIndex = 76;
            // 
            // cbPregnancy
            // 
            this.cbPregnancy.AutoSize = true;
            this.cbPregnancy.Location = new System.Drawing.Point(799, 267);
            this.cbPregnancy.Name = "cbPregnancy";
            this.cbPregnancy.Size = new System.Drawing.Size(200, 41);
            this.cbPregnancy.TabIndex = 77;
            this.cbPregnancy.Text = "Вагітність";
            this.cbPregnancy.UseVisualStyleBackColor = true;
            this.cbPregnancy.Visible = false;
            // 
            // tbCreatinine
            // 
            this.tbCreatinine.Location = new System.Drawing.Point(950, 432);
            this.tbCreatinine.Name = "tbCreatinine";
            this.tbCreatinine.Size = new System.Drawing.Size(250, 44);
            this.tbCreatinine.TabIndex = 84;
            this.tbCreatinine.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbCreatinine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // tbUrobilinogen
            // 
            this.tbUrobilinogen.Location = new System.Drawing.Point(360, 930);
            this.tbUrobilinogen.Name = "tbUrobilinogen";
            this.tbUrobilinogen.Size = new System.Drawing.Size(250, 44);
            this.tbUrobilinogen.TabIndex = 83;
            this.tbUrobilinogen.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbUrobilinogen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // tbNitrite
            // 
            this.tbNitrite.Location = new System.Drawing.Point(360, 830);
            this.tbNitrite.Name = "tbNitrite";
            this.tbNitrite.Size = new System.Drawing.Size(250, 44);
            this.tbNitrite.TabIndex = 82;
            this.tbNitrite.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbNitrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // lbCreatinine
            // 
            this.lbCreatinine.AutoSize = true;
            this.lbCreatinine.Location = new System.Drawing.Point(642, 435);
            this.lbCreatinine.Margin = new System.Windows.Forms.Padding(3);
            this.lbCreatinine.Name = "lbCreatinine";
            this.lbCreatinine.Size = new System.Drawing.Size(279, 37);
            this.lbCreatinine.TabIndex = 80;
            this.lbCreatinine.Text = "Креатин мкмоль/л";
            // 
            // lbUrobilinogen
            // 
            this.lbUrobilinogen.AutoSize = true;
            this.lbUrobilinogen.Location = new System.Drawing.Point(52, 935);
            this.lbUrobilinogen.Margin = new System.Windows.Forms.Padding(3);
            this.lbUrobilinogen.Name = "lbUrobilinogen";
            this.lbUrobilinogen.Size = new System.Drawing.Size(259, 37);
            this.lbUrobilinogen.TabIndex = 79;
            this.lbUrobilinogen.Text = "Уробіліноген мг/л";
            // 
            // lbNitrite
            // 
            this.lbNitrite.AutoSize = true;
            this.lbNitrite.Location = new System.Drawing.Point(52, 835);
            this.lbNitrite.Margin = new System.Windows.Forms.Padding(3);
            this.lbNitrite.Name = "lbNitrite";
            this.lbNitrite.Size = new System.Drawing.Size(191, 37);
            this.lbNitrite.TabIndex = 78;
            this.lbNitrite.Text = "Нітрити мг/л";
            // 
            // tbSodium
            // 
            this.tbSodium.Location = new System.Drawing.Point(290, 84);
            this.tbSodium.Name = "tbSodium";
            this.tbSodium.Size = new System.Drawing.Size(250, 44);
            this.tbSodium.TabIndex = 87;
            this.tbSodium.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbSodium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // lbSodium
            // 
            this.lbSodium.AutoSize = true;
            this.lbSodium.Location = new System.Drawing.Point(21, 89);
            this.lbSodium.Margin = new System.Windows.Forms.Padding(3);
            this.lbSodium.Name = "lbSodium";
            this.lbSodium.Size = new System.Drawing.Size(181, 37);
            this.lbSodium.TabIndex = 86;
            this.lbSodium.Text = "Натрію мг/л";
            // 
            // tbPotassium
            // 
            this.tbPotassium.Location = new System.Drawing.Point(290, 186);
            this.tbPotassium.Name = "tbPotassium";
            this.tbPotassium.Size = new System.Drawing.Size(250, 44);
            this.tbPotassium.TabIndex = 89;
            this.tbPotassium.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbPotassium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // tbChlorides
            // 
            this.tbChlorides.Location = new System.Drawing.Point(290, 284);
            this.tbChlorides.Name = "tbChlorides";
            this.tbChlorides.Size = new System.Drawing.Size(250, 44);
            this.tbChlorides.TabIndex = 91;
            this.tbChlorides.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbChlorides.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // lbPotassium
            // 
            this.lbPotassium.AutoSize = true;
            this.lbPotassium.Location = new System.Drawing.Point(21, 191);
            this.lbPotassium.Margin = new System.Windows.Forms.Padding(3);
            this.lbPotassium.Name = "lbPotassium";
            this.lbPotassium.Size = new System.Drawing.Size(163, 37);
            this.lbPotassium.TabIndex = 92;
            this.lbPotassium.Text = "Калію мг/л";
            // 
            // lbChlorides
            // 
            this.lbChlorides.AutoSize = true;
            this.lbChlorides.Location = new System.Drawing.Point(21, 289);
            this.lbChlorides.Margin = new System.Windows.Forms.Padding(3);
            this.lbChlorides.Name = "lbChlorides";
            this.lbChlorides.Size = new System.Drawing.Size(204, 37);
            this.lbChlorides.TabIndex = 93;
            this.lbChlorides.Text = "Хлориду мг/л";
            // 
            // gbElectrolytes
            // 
            this.gbElectrolytes.Controls.Add(this.lbChlorides);
            this.gbElectrolytes.Controls.Add(this.lbPotassium);
            this.gbElectrolytes.Controls.Add(this.tbChlorides);
            this.gbElectrolytes.Controls.Add(this.tbPotassium);
            this.gbElectrolytes.Controls.Add(this.tbSodium);
            this.gbElectrolytes.Controls.Add(this.lbSodium);
            this.gbElectrolytes.Location = new System.Drawing.Point(638, 544);
            this.gbElectrolytes.Name = "gbElectrolytes";
            this.gbElectrolytes.Size = new System.Drawing.Size(562, 388);
            this.gbElectrolytes.TabIndex = 95;
            this.gbElectrolytes.TabStop = false;
            this.gbElectrolytes.Text = "Електроліти";
            // 
            // tbPH
            // 
            this.tbPH.Location = new System.Drawing.Point(360, 432);
            this.tbPH.Name = "tbPH";
            this.tbPH.Size = new System.Drawing.Size(250, 44);
            this.tbPH.TabIndex = 98;
            this.tbPH.TextChanged += new System.EventHandler(this.ValueChanged);
            this.tbPH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 1235);
            this.Controls.Add(this.tbPH);
            this.Controls.Add(this.gbElectrolytes);
            this.Controls.Add(this.tbCreatinine);
            this.Controls.Add(this.tbUrobilinogen);
            this.Controls.Add(this.tbNitrite);
            this.Controls.Add(this.lbCreatinine);
            this.Controls.Add(this.lbUrobilinogen);
            this.Controls.Add(this.lbNitrite);
            this.Controls.Add(this.cbPregnancy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKetones);
            this.Controls.Add(this.tbAlbumen);
            this.Controls.Add(this.tbGlucose);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lbKetones);
            this.Controls.Add(this.lbAlbumen);
            this.Controls.Add(this.lbGlucose);
            this.Controls.Add(this.lbPH);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.menuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Біохімічний аналіз сечі";
            this.TextChanged += new System.EventHandler(this.ValueChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametersForAnalysis_KeyPress);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.gbElectrolytes.ResumeLayout(false);
            this.gbElectrolytes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbPH;
        private System.Windows.Forms.Label lbGlucose;
        private System.Windows.Forms.Label lbAlbumen;
        private System.Windows.Forms.Label lbKetones;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.TextBox tbGlucose;
        private System.Windows.Forms.TextBox tbAlbumen;
        private System.Windows.Forms.TextBox tbKetones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbPregnancy;
        private System.Windows.Forms.TextBox tbCreatinine;
        private System.Windows.Forms.TextBox tbUrobilinogen;
        private System.Windows.Forms.TextBox tbNitrite;
        private System.Windows.Forms.Label lbCreatinine;
        private System.Windows.Forms.Label lbUrobilinogen;
        private System.Windows.Forms.Label lbNitrite;
        private System.Windows.Forms.TextBox tbSodium;
        private System.Windows.Forms.Label lbSodium;
        private System.Windows.Forms.TextBox tbPotassium;
        private System.Windows.Forms.TextBox tbChlorides;
        private System.Windows.Forms.Label lbPotassium;
        private System.Windows.Forms.Label lbChlorides;
        private System.Windows.Forms.GroupBox gbElectrolytes;
        private System.Windows.Forms.TextBox tbPH;
    }
}

