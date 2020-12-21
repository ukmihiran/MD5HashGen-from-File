
namespace MD5HashVerifier
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
            this.txtBoxUpload = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtBoxVerify = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxUpGen = new System.Windows.Forms.TextBox();
            this.btnUpGen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenHash = new System.Windows.Forms.Button();
            this.lblGenResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxUpload
            // 
            this.txtBoxUpload.Location = new System.Drawing.Point(12, 175);
            this.txtBoxUpload.Name = "txtBoxUpload";
            this.txtBoxUpload.Size = new System.Drawing.Size(445, 20);
            this.txtBoxUpload.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(484, 175);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(106, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtBoxVerify
            // 
            this.txtBoxVerify.Location = new System.Drawing.Point(12, 240);
            this.txtBoxVerify.Name = "txtBoxVerify";
            this.txtBoxVerify.Size = new System.Drawing.Size(445, 20);
            this.txtBoxVerify.TabIndex = 2;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(484, 236);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(106, 23);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify Hash";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upload Your File :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Your MD5 Hash :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 276);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openDialog";
            // 
            // txtBoxUpGen
            // 
            this.txtBoxUpGen.Location = new System.Drawing.Point(12, 52);
            this.txtBoxUpGen.Name = "txtBoxUpGen";
            this.txtBoxUpGen.Size = new System.Drawing.Size(445, 20);
            this.txtBoxUpGen.TabIndex = 7;
            // 
            // btnUpGen
            // 
            this.btnUpGen.Location = new System.Drawing.Point(484, 48);
            this.btnUpGen.Name = "btnUpGen";
            this.btnUpGen.Size = new System.Drawing.Size(106, 23);
            this.btnUpGen.TabIndex = 8;
            this.btnUpGen.Text = "Upload File";
            this.btnUpGen.UseVisualStyleBackColor = true;
            this.btnUpGen.Click += new System.EventHandler(this.btnUpGen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(216, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generate Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(221, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Verify Hash";
            // 
            // btnGenHash
            // 
            this.btnGenHash.Location = new System.Drawing.Point(484, 85);
            this.btnGenHash.Name = "btnGenHash";
            this.btnGenHash.Size = new System.Drawing.Size(106, 23);
            this.btnGenHash.TabIndex = 12;
            this.btnGenHash.Text = "Generate Hash";
            this.btnGenHash.UseVisualStyleBackColor = true;
            this.btnGenHash.Click += new System.EventHandler(this.btnGenHash_Click);
            // 
            // lblGenResult
            // 
            this.lblGenResult.AutoSize = true;
            this.lblGenResult.Location = new System.Drawing.Point(15, 86);
            this.lblGenResult.Name = "lblGenResult";
            this.lblGenResult.Size = new System.Drawing.Size(0, 13);
            this.lblGenResult.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Upload Your File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(612, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGenResult);
            this.Controls.Add(this.btnGenHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpGen);
            this.Controls.Add(this.txtBoxUpGen);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtBoxVerify);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBoxUpload);
            this.Name = "Form1";
            this.Text = "MD5HashVerifier(By Udesh!)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtBoxVerify;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.TextBox txtBoxUpGen;
        private System.Windows.Forms.Button btnUpGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenHash;
        private System.Windows.Forms.Label lblGenResult;
        private System.Windows.Forms.Label label5;
    }
}

