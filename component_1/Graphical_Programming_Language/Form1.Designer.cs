namespace Graphical_Programming_Language
{
    partial class Form1
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
            this.display = new System.Windows.Forms.Panel();
            this.consoleup = new System.Windows.Forms.TextBox();
            this.consoledown = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Syntax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.SeaShell;
            this.display.Location = new System.Drawing.Point(546, 33);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(470, 459);
            this.display.TabIndex = 0;
            // 
            // consoleup
            // 
            this.consoleup.BackColor = System.Drawing.Color.Lavender;
            this.consoleup.Location = new System.Drawing.Point(12, 33);
            this.consoleup.Multiline = true;
            this.consoleup.Name = "consoleup";
            this.consoleup.Size = new System.Drawing.Size(450, 306);
            this.consoleup.TabIndex = 0;
            // 
            // consoledown
            // 
            this.consoledown.BackColor = System.Drawing.Color.Lavender;
            this.consoledown.Location = new System.Drawing.Point(16, 370);
            this.consoledown.Name = "consoledown";
            this.consoledown.Size = new System.Drawing.Size(450, 26);
            this.consoledown.TabIndex = 0;
            this.consoledown.TextChanged += new System.EventHandler(this.consoledown_TextChanged);
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.MistyRose;
            this.Run.Location = new System.Drawing.Point(16, 413);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(116, 34);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            // 
            // Syntax
            // 
            this.Syntax.BackColor = System.Drawing.Color.MistyRose;
            this.Syntax.Location = new System.Drawing.Point(184, 413);
            this.Syntax.Name = "Syntax";
            this.Syntax.Size = new System.Drawing.Size(131, 34);
            this.Syntax.TabIndex = 0;
            this.Syntax.Text = "Syntax";
            this.Syntax.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(546, 3);
            this.label1.MinimumSize = new System.Drawing.Size(470, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(470, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.MinimumSize = new System.Drawing.Size(450, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(450, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Console";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.MistyRose;
            this.Load.Location = new System.Drawing.Point(465, 89);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 37);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.MistyRose;
            this.Save.Location = new System.Drawing.Point(465, 142);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 35);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MistyRose;
            this.Exit.Location = new System.Drawing.Point(465, 247);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 35);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.MistyRose;
            this.Help.Location = new System.Drawing.Point(465, 194);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 37);
            this.Help.TabIndex = 6;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1028, 504);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.consoleup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Syntax);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.consoledown);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.TextBox consoleup;
        private System.Windows.Forms.TextBox consoledown;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Syntax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Help;
    }
}

