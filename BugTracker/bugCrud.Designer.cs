
namespace BugTracker
{
    partial class bugCrud
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.dgvBugSQL = new System.Windows.Forms.DataGridView();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.txtBugText = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.btnRemove = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(694, 6);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // dgvBugSQL
            // 
            this.dgvBugSQL.AllowUserToOrderColumns = true;
            this.dgvBugSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugSQL.Location = new System.Drawing.Point(16, 101);
            this.dgvBugSQL.Name = "dgvBugSQL";
            this.dgvBugSQL.Size = new System.Drawing.Size(453, 285);
            this.dgvBugSQL.TabIndex = 1;
            this.dgvBugSQL.DoubleClick += new System.EventHandler(this.dgvBugSQL_DoubleClick);
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(518, 101);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(239, 27);
            this.txtBugName.TabIndex = 2;
            this.txtBugName.Enter += new System.EventHandler(this.txtBugName_Enter);
            this.txtBugName.Leave += new System.EventHandler(this.txtBugName_Leave);
            // 
            // txtBugText
            // 
            this.txtBugText.Location = new System.Drawing.Point(518, 134);
            this.txtBugText.Multiline = true;
            this.txtBugText.Name = "txtBugText";
            this.txtBugText.Size = new System.Drawing.Size(239, 220);
            this.txtBugText.TabIndex = 2;
            this.txtBugText.Enter += new System.EventHandler(this.txtBugText_Enter);
            this.txtBugText.Leave += new System.EventHandler(this.txtBugText_Leave);
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(518, 361);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(239, 28);
            this.cmbPriority.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.IsDerivedStyle = true;
            this.btnSave.Location = new System.Drawing.Point(667, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalTextColor = System.Drawing.Color.White;
            this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressTextColor = System.Drawing.Color.White;
            this.btnSave.Size = new System.Drawing.Size(90, 47);
            this.btnSave.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSave.StyleManager = null;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLite";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemove.HoverTextColor = System.Drawing.Color.White;
            this.btnRemove.IsDerivedStyle = true;
            this.btnRemove.Location = new System.Drawing.Point(567, 395);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.NormalTextColor = System.Drawing.Color.White;
            this.btnRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemove.PressTextColor = System.Drawing.Color.White;
            this.btnRemove.Size = new System.Drawing.Size(94, 47);
            this.btnRemove.Style = MetroSet_UI.Enums.Style.Light;
            this.btnRemove.StyleManager = null;
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.ThemeAuthor = "Narwin";
            this.btnRemove.ThemeName = "MetroLite";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // bugCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtBugText);
            this.Controls.Add(this.txtBugName);
            this.Controls.Add(this.dgvBugSQL);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "bugCrud";
            this.Text = "Bug report interface";
            this.Load += new System.EventHandler(this.bugCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.DataGridView dgvBugSQL;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.TextBox txtBugText;
        private System.Windows.Forms.ComboBox cmbPriority;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetButton btnRemove;
    }
}