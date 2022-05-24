
namespace switch_user_controls
{
    partial class MainActivity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config34ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config12ToolStripMenuItem,
            this.config34ToolStripMenuItem});
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.switchToolStripMenuItem.Text = "Switch";
            // 
            // config12ToolStripMenuItem
            // 
            this.config12ToolStripMenuItem.Name = "config12ToolStripMenuItem";
            this.config12ToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.config12ToolStripMenuItem.Text = "Config 1-2";
            this.config12ToolStripMenuItem.Click += new System.EventHandler(this.config12ToolStripMenuItem_Click);
            // 
            // config34ToolStripMenuItem
            // 
            this.config34ToolStripMenuItem.Name = "config34ToolStripMenuItem";
            this.config34ToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.config34ToolStripMenuItem.Text = "Config 3-4";
            this.config34ToolStripMenuItem.Click += new System.EventHandler(this.config34ToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 249);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 114);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Button 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 114);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Button 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 115);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Button 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 115);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.Text = "Button 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch Buttons";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config34ToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

