namespace GUIWIN
{
    partial class ApplicationForm
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
            dgvRooms = new DataGridView();
            btnApply = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(26, 22);
            dgvRooms.Margin = new Padding(3, 2, 3, 2);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowTemplate.Height = 29;
            dgvRooms.Size = new Size(481, 225);
            dgvRooms.TabIndex = 0;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(201, 262);
            btnApply.Margin = new Padding(3, 2, 3, 2);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(131, 26);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply For Room";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnBack
            btnBack = new Button();
            btnBack.Location = new Point(50, 262);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 26);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            this.Controls.Add(btnBack);

            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 308);
            Controls.Add(btnApply);
            Controls.Add(dgvRooms);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            Load += ApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;

    }
}
