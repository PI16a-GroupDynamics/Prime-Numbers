namespace MetroFramework_test_at_a_new_project
{
    partial class FormResultLooksLike
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultLooksLike));
            this.BoxPreview = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BoxResultSeparator = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CBoxNewLines = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxPreview
            // 
            this.BoxPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BoxPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxPreview.Location = new System.Drawing.Point(12, 148);
            this.BoxPreview.Multiline = true;
            this.BoxPreview.Name = "BoxPreview";
            this.BoxPreview.ReadOnly = true;
            this.BoxPreview.Size = new System.Drawing.Size(679, 230);
            this.BoxPreview.TabIndex = 0;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(293, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 25);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Превью";
            // 
            // BoxResultSeparator
            // 
            this.BoxResultSeparator.AllowDrop = true;
            this.BoxResultSeparator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxResultSeparator.Location = new System.Drawing.Point(12, 65);
            this.BoxResultSeparator.Name = "BoxResultSeparator";
            this.BoxResultSeparator.Size = new System.Drawing.Size(150, 27);
            this.BoxResultSeparator.TabIndex = 18;
            this.BoxResultSeparator.TextChanged += new System.EventHandler(this.ChangeResultSeparator);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Разделитель чисел";
            // 
            // CBoxNewLines
            // 
            this.CBoxNewLines.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBoxNewLines.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxNewLines.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxNewLines.FormattingEnabled = true;
            this.CBoxNewLines.Items.AddRange(new object[] {
            "Ничего",
            "Новая строка",
            "Две новых строки"});
            this.CBoxNewLines.Location = new System.Drawing.Point(203, 64);
            this.CBoxNewLines.Name = "CBoxNewLines";
            this.CBoxNewLines.Size = new System.Drawing.Size(150, 28);
            this.CBoxNewLines.TabIndex = 20;
            this.CBoxNewLines.SelectedIndexChanged += new System.EventHandler(this.ChangeResultSeparator);
            // 
            // ButtonBack
            // 
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Image = global::MetroFramework_test_at_a_new_project.Properties.Resources.back1;
            this.ButtonBack.Location = new System.Drawing.Point(12, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(65, 38);
            this.ButtonBack.TabIndex = 22;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetroFramework_test_at_a_new_project.Properties.Resources._;
            this.pictureBox1.Location = new System.Drawing.Point(169, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormResultLooksLike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(703, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.CBoxNewLines);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BoxResultSeparator);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.BoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResultLooksLike";
            this.Text = "Настройка внешнего вида результата";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxPreview;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox BoxResultSeparator;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox CBoxNewLines;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}