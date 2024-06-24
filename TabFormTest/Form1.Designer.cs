namespace TabFormTest
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
            tabControl1 = new TabControl();
            menuStrip1 = new MenuStrip();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            form2ToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 426);
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseClick += tabControl1_MouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { form2ToolStripMenuItem, form2ToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(56, 20);
            form2ToolStripMenuItem.Text = "Form 2";
            form2ToolStripMenuItem.Click += form2ToolStripMenuItem_Click;
            // 
            // form2ToolStripMenuItem1
            // 
            form2ToolStripMenuItem1.Name = "form2ToolStripMenuItem1";
            form2ToolStripMenuItem1.Size = new Size(56, 20);
            form2ToolStripMenuItem1.Text = "Form 3";
            form2ToolStripMenuItem1.Click += form2ToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem form2ToolStripMenuItem1;
    }
}
