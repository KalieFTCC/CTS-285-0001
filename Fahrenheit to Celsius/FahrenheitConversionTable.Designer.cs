namespace Fahrenheit_to_Celsius
{
    partial class FahrenheitConversionTable
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
            this.CreateTable = new System.Windows.Forms.Button();
            this.tempLst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateTable
            // 
            this.CreateTable.Location = new System.Drawing.Point(303, 496);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(108, 23);
            this.CreateTable.TabIndex = 1;
            this.CreateTable.Text = "Initialize Table";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tempLst
            // 
            this.tempLst.FormattingEnabled = true;
            this.tempLst.Location = new System.Drawing.Point(0, 0);
            this.tempLst.Name = "tempLst";
            this.tempLst.Size = new System.Drawing.Size(710, 498);
            this.tempLst.TabIndex = 2;
            // 
            // FahrenheitConversionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 531);
            this.Controls.Add(this.tempLst);
            this.Controls.Add(this.CreateTable);
            this.Name = "FahrenheitConversionTable";
            this.Text = "Table";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.ListBox tempLst;
    }
}

