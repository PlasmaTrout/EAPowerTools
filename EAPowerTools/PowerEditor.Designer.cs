﻿namespace EAPowerTools
{
    partial class PowerEditor
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
            this.powerEditorControl1 = new EAPowerTools.PowerEditorControl();
            this.SuspendLayout();
            // 
            // powerEditorControl1
            // 
            this.powerEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.powerEditorControl1.Name = "powerEditorControl1";
            this.powerEditorControl1.Size = new System.Drawing.Size(784, 561);
            this.powerEditorControl1.TabIndex = 0;
            // 
            // PowerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.powerEditorControl1);
            this.Name = "PowerEditor";
            this.Text = "PowerEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private PowerEditorControl powerEditorControl1;
    }
}