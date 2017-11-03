namespace matrixOps
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
            this.MatAtxt = new System.Windows.Forms.TextBox();
            this.MatBtxt = new System.Windows.Forms.TextBox();
            this.MatCtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MatAbtn = new System.Windows.Forms.Button();
            this.MatBbtn = new System.Windows.Forms.Button();
            this.MatARow = new System.Windows.Forms.TextBox();
            this.MatACol = new System.Windows.Forms.TextBox();
            this.MatBRow = new System.Windows.Forms.TextBox();
            this.MatBCol = new System.Windows.Forms.TextBox();
            this.BIdentbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opbx = new System.Windows.Forms.GroupBox();
            this.Subtractrbtn = new System.Windows.Forms.RadioButton();
            this.Addrbtn = new System.Windows.Forms.RadioButton();
            this.Multiplyrbtn = new System.Windows.Forms.RadioButton();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.opbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatAtxt
            // 
            this.MatAtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatAtxt.Location = new System.Drawing.Point(11, 39);
            this.MatAtxt.Multiline = true;
            this.MatAtxt.Name = "MatAtxt";
            this.MatAtxt.ReadOnly = true;
            this.MatAtxt.Size = new System.Drawing.Size(144, 181);
            this.MatAtxt.TabIndex = 0;
            // 
            // MatBtxt
            // 
            this.MatBtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatBtxt.Location = new System.Drawing.Point(178, 39);
            this.MatBtxt.Multiline = true;
            this.MatBtxt.Name = "MatBtxt";
            this.MatBtxt.ReadOnly = true;
            this.MatBtxt.Size = new System.Drawing.Size(144, 181);
            this.MatBtxt.TabIndex = 1;
            // 
            // MatCtxt
            // 
            this.MatCtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatCtxt.Location = new System.Drawing.Point(345, 39);
            this.MatCtxt.Multiline = true;
            this.MatCtxt.Name = "MatCtxt";
            this.MatCtxt.ReadOnly = true;
            this.MatCtxt.Size = new System.Drawing.Size(144, 181);
            this.MatCtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrix A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrix B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matrix C";
            // 
            // MatAbtn
            // 
            this.MatAbtn.Location = new System.Drawing.Point(11, 244);
            this.MatAbtn.Name = "MatAbtn";
            this.MatAbtn.Size = new System.Drawing.Size(140, 22);
            this.MatAbtn.TabIndex = 6;
            this.MatAbtn.Text = "Make Matrix A";
            this.MatAbtn.UseVisualStyleBackColor = true;
            this.MatAbtn.Click += new System.EventHandler(this.MatAbtn_Click);
            // 
            // MatBbtn
            // 
            this.MatBbtn.Location = new System.Drawing.Point(12, 272);
            this.MatBbtn.Name = "MatBbtn";
            this.MatBbtn.Size = new System.Drawing.Size(140, 24);
            this.MatBbtn.TabIndex = 7;
            this.MatBbtn.Text = "Make Matrix B";
            this.MatBbtn.UseVisualStyleBackColor = true;
            this.MatBbtn.Click += new System.EventHandler(this.MatBbtn_Click);
            // 
            // MatARow
            // 
            this.MatARow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatARow.Location = new System.Drawing.Point(157, 246);
            this.MatARow.Name = "MatARow";
            this.MatARow.Size = new System.Drawing.Size(100, 20);
            this.MatARow.TabIndex = 8;
            // 
            // MatACol
            // 
            this.MatACol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatACol.Location = new System.Drawing.Point(263, 246);
            this.MatACol.Name = "MatACol";
            this.MatACol.Size = new System.Drawing.Size(100, 20);
            this.MatACol.TabIndex = 9;
            // 
            // MatBRow
            // 
            this.MatBRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatBRow.Location = new System.Drawing.Point(157, 272);
            this.MatBRow.Name = "MatBRow";
            this.MatBRow.Size = new System.Drawing.Size(100, 20);
            this.MatBRow.TabIndex = 10;
            // 
            // MatBCol
            // 
            this.MatBCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatBCol.Location = new System.Drawing.Point(263, 272);
            this.MatBCol.Name = "MatBCol";
            this.MatBCol.Size = new System.Drawing.Size(100, 20);
            this.MatBCol.TabIndex = 11;
            // 
            // BIdentbtn
            // 
            this.BIdentbtn.Location = new System.Drawing.Point(370, 272);
            this.BIdentbtn.Name = "BIdentbtn";
            this.BIdentbtn.Size = new System.Drawing.Size(119, 24);
            this.BIdentbtn.TabIndex = 12;
            this.BIdentbtn.Text = "Make B Identity";
            this.BIdentbtn.UseVisualStyleBackColor = true;
            this.BIdentbtn.Click += new System.EventHandler(this.BIdentbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rows";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cols";
            // 
            // opbx
            // 
            this.opbx.Controls.Add(this.Subtractrbtn);
            this.opbx.Controls.Add(this.Addrbtn);
            this.opbx.Controls.Add(this.Multiplyrbtn);
            this.opbx.Location = new System.Drawing.Point(15, 303);
            this.opbx.Name = "opbx";
            this.opbx.Size = new System.Drawing.Size(216, 52);
            this.opbx.TabIndex = 15;
            this.opbx.TabStop = false;
            this.opbx.Text = "Select Operation";
            // 
            // Subtractrbtn
            // 
            this.Subtractrbtn.AutoSize = true;
            this.Subtractrbtn.Location = new System.Drawing.Point(133, 20);
            this.Subtractrbtn.Name = "Subtractrbtn";
            this.Subtractrbtn.Size = new System.Drawing.Size(65, 17);
            this.Subtractrbtn.TabIndex = 2;
            this.Subtractrbtn.TabStop = true;
            this.Subtractrbtn.Text = "Subtract";
            this.Subtractrbtn.UseVisualStyleBackColor = true;
            // 
            // Addrbtn
            // 
            this.Addrbtn.AutoSize = true;
            this.Addrbtn.Location = new System.Drawing.Point(78, 20);
            this.Addrbtn.Name = "Addrbtn";
            this.Addrbtn.Size = new System.Drawing.Size(44, 17);
            this.Addrbtn.TabIndex = 1;
            this.Addrbtn.TabStop = true;
            this.Addrbtn.Text = "Add";
            this.Addrbtn.UseVisualStyleBackColor = true;
            // 
            // Multiplyrbtn
            // 
            this.Multiplyrbtn.AutoSize = true;
            this.Multiplyrbtn.Location = new System.Drawing.Point(7, 20);
            this.Multiplyrbtn.Name = "Multiplyrbtn";
            this.Multiplyrbtn.Size = new System.Drawing.Size(60, 17);
            this.Multiplyrbtn.TabIndex = 0;
            this.Multiplyrbtn.TabStop = true;
            this.Multiplyrbtn.Text = "Multiply";
            this.Multiplyrbtn.UseVisualStyleBackColor = true;
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(12, 361);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(119, 24);
            this.Calculatebtn.TabIndex = 16;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(266, 361);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(119, 24);
            this.Clearbtn.TabIndex = 17;
            this.Clearbtn.Text = "Clear Matrices";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbtn.Location = new System.Drawing.Point(391, 361);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(119, 24);
            this.Exitbtn.TabIndex = 18;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calculatebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbtn;
            this.ClientSize = new System.Drawing.Size(522, 392);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.opbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BIdentbtn);
            this.Controls.Add(this.MatBCol);
            this.Controls.Add(this.MatBRow);
            this.Controls.Add(this.MatACol);
            this.Controls.Add(this.MatARow);
            this.Controls.Add(this.MatBbtn);
            this.Controls.Add(this.MatAbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatCtxt);
            this.Controls.Add(this.MatBtxt);
            this.Controls.Add(this.MatAtxt);
            this.Name = "Form1";
            this.Text = "Matrix Ops";
            this.opbx.ResumeLayout(false);
            this.opbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MatAtxt;
        private System.Windows.Forms.TextBox MatBtxt;
        private System.Windows.Forms.TextBox MatCtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MatAbtn;
        private System.Windows.Forms.Button MatBbtn;
        private System.Windows.Forms.TextBox MatARow;
        private System.Windows.Forms.TextBox MatACol;
        private System.Windows.Forms.TextBox MatBRow;
        private System.Windows.Forms.TextBox MatBCol;
        private System.Windows.Forms.Button BIdentbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox opbx;
        private System.Windows.Forms.RadioButton Subtractrbtn;
        private System.Windows.Forms.RadioButton Addrbtn;
        private System.Windows.Forms.RadioButton Multiplyrbtn;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

