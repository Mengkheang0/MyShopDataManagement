
namespace MyShopDataManagement.Views.Controls
{
    partial class History
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
            this.myListBox = new System.Windows.Forms.ListBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBt = new Guna.UI2.WinForms.Guna2Button();
            this.prop = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.prop.SuspendLayout();
            this.SuspendLayout();
            // 
            // myListBox
            // 
            this.myListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.myListBox.Font = new System.Drawing.Font("Ebrima", 9.818182F);
            this.myListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.myListBox.FormattingEnabled = true;
            this.myListBox.IntegralHeight = false;
            this.myListBox.ItemHeight = 17;
            this.myListBox.Location = new System.Drawing.Point(-1, 45);
            this.myListBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.myListBox.Name = "myListBox";
            this.myListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.myListBox.Size = new System.Drawing.Size(1369, 340);
            this.myListBox.TabIndex = 0;
            this.myListBox.SelectedIndexChanged += new System.EventHandler(this.myListBox_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Ebrima", 9.818182F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(-1, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(137, 34);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Restore";
            // 
            // deleteBt
            // 
            this.deleteBt.BorderRadius = 8;
            this.deleteBt.CheckedState.Parent = this.deleteBt;
            this.deleteBt.CustomImages.Parent = this.deleteBt;
            this.deleteBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBt.DisabledState.Parent = this.deleteBt;
            this.deleteBt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBt.Font = new System.Drawing.Font("Ebrima", 9.818182F);
            this.deleteBt.ForeColor = System.Drawing.Color.White;
            this.deleteBt.HoverState.Parent = this.deleteBt;
            this.deleteBt.Location = new System.Drawing.Point(142, 5);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.ShadowDecoration.Parent = this.deleteBt;
            this.deleteBt.Size = new System.Drawing.Size(137, 34);
            this.deleteBt.TabIndex = 1;
            this.deleteBt.Text = "Delete";
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // prop
            // 
            this.prop.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.prop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.prop.Name = "prop";
            this.prop.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.prop.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.prop.RenderStyle.ColorTable = null;
            this.prop.RenderStyle.RoundedEdges = true;
            this.prop.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.prop.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prop.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.prop.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.prop.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prop.Size = new System.Drawing.Size(134, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Ebrima", 9.818182F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(-1, 435);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(1369, 425);
            this.listBox1.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Ebrima", 10.12727F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(0, 407);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 21);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Output";
            // 
            // History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.myListBox);
            this.Font = new System.Drawing.Font("Ebrima", 9.818182F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "History";
            this.Size = new System.Drawing.Size(1350, 863);
            this.prop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox myListBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button deleteBt;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip prop;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ListBox listBox1;
    }
}
