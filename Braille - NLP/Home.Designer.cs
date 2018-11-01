namespace Braille___NLP
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Text_Input = new System.Windows.Forms.TextBox();
            this.Checker = new System.Windows.Forms.Button();
            this.Text_Input_Label = new System.Windows.Forms.Label();
            this.View_Shape = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Footer_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Input
            // 
            this.Text_Input.Location = new System.Drawing.Point(10, 56);
            this.Text_Input.Name = "Text_Input";
            this.Text_Input.Size = new System.Drawing.Size(860, 22);
            this.Text_Input.TabIndex = 0;
            // 
            // Checker
            // 
            this.Checker.Location = new System.Drawing.Point(382, 84);
            this.Checker.Name = "Checker";
            this.Checker.Size = new System.Drawing.Size(117, 38);
            this.Checker.TabIndex = 1;
            this.Checker.Text = "Translate";
            this.Checker.UseVisualStyleBackColor = true;
            this.Checker.Click += new System.EventHandler(this.Checker_Click);
            // 
            // Text_Input_Label
            // 
            this.Text_Input_Label.AutoSize = true;
            this.Text_Input_Label.Location = new System.Drawing.Point(9, 36);
            this.Text_Input_Label.Name = "Text_Input_Label";
            this.Text_Input_Label.Size = new System.Drawing.Size(77, 17);
            this.Text_Input_Label.TabIndex = 3;
            this.Text_Input_Label.Text = "Enter Text:";
            // 
            // View_Shape
            // 
            this.View_Shape.Location = new System.Drawing.Point(10, 128);
            this.View_Shape.Name = "View_Shape";
            this.View_Shape.Size = new System.Drawing.Size(860, 146);
            this.View_Shape.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_Button});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home_Button
            // 
            this.Home_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.Exit_Button});
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(62, 24);
            this.Home_Button.Text = "Home";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(125, 26);
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Footer_Label
            // 
            this.Footer_Label.AutoSize = true;
            this.Footer_Label.Location = new System.Drawing.Point(323, 277);
            this.Footer_Label.Name = "Footer_Label";
            this.Footer_Label.Size = new System.Drawing.Size(235, 17);
            this.Footer_Label.TabIndex = 6;
            this.Footer_Label.Text = "Copyright © 2018 - AhmedMohebCo";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 303);
            this.Controls.Add(this.Footer_Label);
            this.Controls.Add(this.View_Shape);
            this.Controls.Add(this.Text_Input_Label);
            this.Controls.Add(this.Checker);
            this.Controls.Add(this.Text_Input);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "English - To - Braille";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Input;
        private System.Windows.Forms.Button Checker;
        private System.Windows.Forms.Label Text_Input_Label;
        private System.Windows.Forms.Panel View_Shape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home_Button;
        private System.Windows.Forms.ToolStripMenuItem Exit_Button;
        private System.Windows.Forms.Label Footer_Label;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

