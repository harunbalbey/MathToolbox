﻿namespace mat2_projee
{
    partial class MatematikseİslemlerProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatematikseİslemlerProje));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.Black;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.Black;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Black;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            resources.ApplyResources(button4, "button4");
            button4.ForeColor = Color.Black;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MatematikseİslemlerProje
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MatematikseİslemlerProje";
            Load += MatematikseİslemlerProje_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
