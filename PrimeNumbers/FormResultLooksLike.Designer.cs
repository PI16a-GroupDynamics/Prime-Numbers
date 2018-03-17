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
            this.BoxPreview = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BoxResultSeparator = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CBoxNewLines = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxPreview
            // 
            this.BoxPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BoxPreview.Location = new System.Drawing.Point(12, 148);
            this.BoxPreview.Multiline = true;
            this.BoxPreview.Name = "BoxPreview";
            this.BoxPreview.ReadOnly = true;
            this.BoxPreview.Size = new System.Drawing.Size(679, 309);
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
            this.BoxResultSeparator.Location = new System.Drawing.Point(12, 65);
            this.BoxResultSeparator.Name = "BoxResultSeparator";
            this.BoxResultSeparator.Size = new System.Drawing.Size(142, 20);
            this.BoxResultSeparator.TabIndex = 18;
            this.BoxResultSeparator.TextChanged += new System.EventHandler(this.ChangeResultSeparator);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Разделитель чисел";
            // 
            // CBoxNewLines
            // 
            this.CBoxNewLines.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBoxNewLines.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxNewLines.FormattingEnabled = true;
            this.CBoxNewLines.Items.AddRange(new object[] {
            "Ничего",
            "Новая строка",
            "Две новых строки"});
            this.CBoxNewLines.Location = new System.Drawing.Point(184, 64);
            this.CBoxNewLines.Name = "CBoxNewLines";
            this.CBoxNewLines.Size = new System.Drawing.Size(121, 21);
            this.CBoxNewLines.TabIndex = 20;
            this.CBoxNewLines.SelectedIndexChanged += new System.EventHandler(this.ChangeResultSeparator);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(160, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 25);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "+";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ButtonBack
            // 
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Image = global::MetroFramework_test_at_a_new_project.Properties.Resources.back1;
            this.ButtonBack.Location = new System.Drawing.Point(12, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(65, 38);
            this.ButtonBack.TabIndex = 22;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormResultLooksLike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(703, 467);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CBoxNewLines);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BoxResultSeparator);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.BoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "FormResultLooksLike";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxPreview;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox BoxResultSeparator;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox CBoxNewLines;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button ButtonBack;
    }
}