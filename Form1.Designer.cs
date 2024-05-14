
namespace ConsoleApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnsave_exit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(96, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(197, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(307, 35);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(428, 20);
            this.txtsearch.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(96, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(197, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(96, 104);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(197, 20);
            this.txtaddress.TabIndex = 3;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(96, 134);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(197, 20);
            this.txtsalary.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(209, 182);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 35);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.AliceBlue;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(34, 243);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(85, 33);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfind.Location = new System.Drawing.Point(752, 25);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(87, 32);
            this.btnfind.TabIndex = 11;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnsave_exit
            // 
            this.btnsave_exit.BackColor = System.Drawing.Color.LightCoral;
            this.btnsave_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave_exit.Location = new System.Drawing.Point(209, 243);
            this.btnsave_exit.Name = "btnsave_exit";
            this.btnsave_exit.Size = new System.Drawing.Size(83, 33);
            this.btnsave_exit.TabIndex = 12;
            this.btnsave_exit.Text = "Exit";
            this.btnsave_exit.UseVisualStyleBackColor = false;
            this.btnsave_exit.Click += new System.EventHandler(this.btnsave_exit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(125, 182);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 35);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(34, 182);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(85, 35);
            this.btninsert.TabIndex = 14;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 195);
            this.dataGridView1.TabIndex = 15;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(125, 243);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(78, 33);
            this.btn_export.TabIndex = 16;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 321);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave_exit);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnsave_exit;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_export;
    }
}