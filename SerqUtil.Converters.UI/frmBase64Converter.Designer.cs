namespace SerqUtil.Converters.UI
{
    partial class frmBase64Converter
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
            this.lblPlain = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.lblEncodedText = new System.Windows.Forms.Label();
            this.txtEncodedText = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cmbEncodings = new System.Windows.Forms.ComboBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(30, 62);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(57, 13);
            this.lblPlain.TabIndex = 0;
            this.lblPlain.Text = "Plain Text:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(108, 59);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(324, 54);
            this.txtPlainText.TabIndex = 1;
            // 
            // lblEncodedText
            // 
            this.lblEncodedText.AutoSize = true;
            this.lblEncodedText.Location = new System.Drawing.Point(30, 134);
            this.lblEncodedText.Name = "lblEncodedText";
            this.lblEncodedText.Size = new System.Drawing.Size(77, 13);
            this.lblEncodedText.TabIndex = 2;
            this.lblEncodedText.Text = "Encoded Text:";
            // 
            // txtEncodedText
            // 
            this.txtEncodedText.Location = new System.Drawing.Point(108, 131);
            this.txtEncodedText.Multiline = true;
            this.txtEncodedText.Name = "txtEncodedText";
            this.txtEncodedText.Size = new System.Drawing.Size(324, 54);
            this.txtEncodedText.TabIndex = 3;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(311, 14);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(121, 35);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cmbEncodings
            // 
            this.cmbEncodings.FormattingEnabled = true;
            this.cmbEncodings.Location = new System.Drawing.Point(108, 25);
            this.cmbEncodings.Name = "cmbEncodings";
            this.cmbEncodings.Size = new System.Drawing.Size(121, 21);
            this.cmbEncodings.TabIndex = 5;
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(30, 25);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblEncoding.TabIndex = 6;
            this.lblEncoding.Text = "Encoding:";
            // 
            // frmBase64Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 227);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.cmbEncodings);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtEncodedText);
            this.Controls.Add(this.lblEncodedText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblPlain);
            this.Name = "frmBase64Converter";
            this.Text = "Base64Converter";
            this.Load += new System.EventHandler(this.frmBase64Converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlain;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label lblEncodedText;
        private System.Windows.Forms.TextBox txtEncodedText;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cmbEncodings;
        private System.Windows.Forms.Label lblEncoding;
    }
}

