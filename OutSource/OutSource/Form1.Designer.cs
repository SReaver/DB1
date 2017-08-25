namespace OutSource
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
            this.gvBooks = new System.Windows.Forms.DataGridView();
            this.btGetInfo = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBooks
            // 
            this.gvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvBooks.Location = new System.Drawing.Point(0, 0);
            this.gvBooks.Name = "gvBooks";
            this.gvBooks.Size = new System.Drawing.Size(601, 619);
            this.gvBooks.TabIndex = 0;
            // 
            // btGetInfo
            // 
            this.btGetInfo.Location = new System.Drawing.Point(704, 199);
            this.btGetInfo.Name = "btGetInfo";
            this.btGetInfo.Size = new System.Drawing.Size(111, 37);
            this.btGetInfo.TabIndex = 1;
            this.btGetInfo.Text = "Показать";
            this.btGetInfo.UseVisualStyleBackColor = true;
            this.btGetInfo.Click += new System.EventHandler(this.btGetInfo_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(715, 30);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 2;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(607, 33);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(102, 13);
            this.lbCode.TabIndex = 3;
            this.lbCode.Text = "Введите код книги";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 619);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btGetInfo);
            this.Controls.Add(this.gvBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBooks;
        private System.Windows.Forms.Button btGetInfo;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
    }
}

