
namespace MyShopDataManagement.Views.Controls
{
    partial class CRUD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.deleteBt = new Guna.UI2.WinForms.Guna2Button();
            this.updateBt = new Guna.UI2.WinForms.Guna2Button();
            this.addBt = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGrid
            // 
            this.myDataGrid.AllowUserToAddRows = false;
            this.myDataGrid.AllowUserToDeleteRows = false;
            this.myDataGrid.AllowUserToResizeColumns = false;
            this.myDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.myDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.myDataGrid.ColumnHeadersHeight = 30;
            this.myDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.myDataGrid.EnableHeadersVisualStyles = false;
            this.myDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.Location = new System.Drawing.Point(0, 158);
            this.myDataGrid.MultiSelect = false;
            this.myDataGrid.Name = "myDataGrid";
            this.myDataGrid.ReadOnly = true;
            this.myDataGrid.RowHeadersVisible = false;
            this.myDataGrid.RowHeadersWidth = 55;
            this.myDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDataGrid.Size = new System.Drawing.Size(1350, 705);
            this.myDataGrid.TabIndex = 3;
            this.myDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.myDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.myDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.myDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.myDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.myDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.myDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.myDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.myDataGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.myDataGrid.ThemeStyle.ReadOnly = true;
            this.myDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.myDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.myDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.myDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.myDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.myDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGrid_CellClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("!Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(601, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(160, 36);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "ទិន្ននយ័របស់ហាងខ្ញុំ";
            // 
            // deleteBt
            // 
            this.deleteBt.BorderRadius = 4;
            this.deleteBt.BorderThickness = 1;
            this.deleteBt.CheckedState.Parent = this.deleteBt;
            this.deleteBt.CustomImages.Parent = this.deleteBt;
            this.deleteBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBt.DisabledState.Parent = this.deleteBt;
            this.deleteBt.FillColor = System.Drawing.Color.Maroon;
            this.deleteBt.Font = new System.Drawing.Font("!Khmer OS Siemreap", 11.25F);
            this.deleteBt.ForeColor = System.Drawing.Color.White;
            this.deleteBt.HoverState.Parent = this.deleteBt;
            this.deleteBt.Location = new System.Drawing.Point(1170, 90);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.ShadowDecoration.Parent = this.deleteBt;
            this.deleteBt.Size = new System.Drawing.Size(180, 45);
            this.deleteBt.TabIndex = 5;
            this.deleteBt.Text = "លុបពត័មាន";
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.BorderRadius = 4;
            this.updateBt.BorderThickness = 1;
            this.updateBt.CheckedState.Parent = this.updateBt;
            this.updateBt.CustomImages.Parent = this.updateBt;
            this.updateBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBt.DisabledState.Parent = this.updateBt;
            this.updateBt.FillColor = System.Drawing.Color.Teal;
            this.updateBt.Font = new System.Drawing.Font("!Khmer OS Siemreap", 11.25F);
            this.updateBt.ForeColor = System.Drawing.Color.White;
            this.updateBt.HoverState.Parent = this.updateBt;
            this.updateBt.Location = new System.Drawing.Point(968, 90);
            this.updateBt.Name = "updateBt";
            this.updateBt.ShadowDecoration.Parent = this.updateBt;
            this.updateBt.Size = new System.Drawing.Size(180, 45);
            this.updateBt.TabIndex = 5;
            this.updateBt.Text = "កែរពត៏មាន";
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.BorderRadius = 4;
            this.addBt.BorderThickness = 1;
            this.addBt.CheckedState.Parent = this.addBt;
            this.addBt.CustomImages.Parent = this.addBt;
            this.addBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBt.DisabledState.Parent = this.addBt;
            this.addBt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addBt.Font = new System.Drawing.Font("!Khmer OS Siemreap", 11.25F);
            this.addBt.ForeColor = System.Drawing.Color.White;
            this.addBt.HoverState.Parent = this.addBt;
            this.addBt.Location = new System.Drawing.Point(772, 90);
            this.addBt.Name = "addBt";
            this.addBt.ShadowDecoration.Parent = this.addBt;
            this.addBt.Size = new System.Drawing.Size(180, 45);
            this.addBt.TabIndex = 5;
            this.addBt.Text = "បញ្ចូលពត៏មាន";
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // CRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.myDataGrid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CRUD";
            this.Size = new System.Drawing.Size(1353, 863);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView myDataGrid;
        private Guna.UI2.WinForms.Guna2Button deleteBt;
        private Guna.UI2.WinForms.Guna2Button updateBt;
        private Guna.UI2.WinForms.Guna2Button addBt;
    }
}
