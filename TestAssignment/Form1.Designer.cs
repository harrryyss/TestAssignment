
namespace TestAssignment
{
    partial class Form1
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
            this.inputnumber = new System.Windows.Forms.TextBox();
            this.sortbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataquick = new System.Windows.Forms.DataGridView();
            this.databubble = new System.Windows.Forms.DataGridView();
            this.datamerge = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timequick = new System.Windows.Forms.Label();
            this.timebubble = new System.Windows.Forms.Label();
            this.timemerge = new System.Windows.Forms.Label();
            this.timegcf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataquick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputnumber
            // 
            this.inputnumber.Location = new System.Drawing.Point(272, 50);
            this.inputnumber.Name = "inputnumber";
            this.inputnumber.Size = new System.Drawing.Size(312, 23);
            this.inputnumber.TabIndex = 0;
            this.inputnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputnumber_KeyPress);
            // 
            // sortbutton
            // 
            this.sortbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sortbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sortbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortbutton.Location = new System.Drawing.Point(590, 40);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(90, 40);
            this.sortbutton.TabIndex = 1;
            this.sortbutton.Text = "Sort";
            this.sortbutton.UseVisualStyleBackColor = false;
            this.sortbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Sort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(531, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Merge Sort";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(316, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bubble Sort";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(756, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "GCF Sort";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataquick
            // 
            this.dataquick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataquick.Location = new System.Drawing.Point(46, 191);
            this.dataquick.Name = "dataquick";
            this.dataquick.RowTemplate.Height = 25;
            this.dataquick.Size = new System.Drawing.Size(194, 146);
            this.dataquick.TabIndex = 6;
            this.dataquick.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataquick_CellContentClick);
            // 
            // databubble
            // 
            this.databubble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databubble.Location = new System.Drawing.Point(272, 191);
            this.databubble.Name = "databubble";
            this.databubble.ReadOnly = true;
            this.databubble.RowTemplate.Height = 25;
            this.databubble.Size = new System.Drawing.Size(188, 146);
            this.databubble.TabIndex = 7;
            this.databubble.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databubble_CellContentClick);
            // 
            // datamerge
            // 
            this.datamerge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamerge.Location = new System.Drawing.Point(486, 191);
            this.datamerge.Name = "datamerge";
            this.datamerge.RowTemplate.Height = 25;
            this.datamerge.Size = new System.Drawing.Size(194, 146);
            this.datamerge.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(704, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(188, 146);
            this.dataGridView1.TabIndex = 9;
            // 
            // timequick
            // 
            this.timequick.AutoSize = true;
            this.timequick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timequick.Location = new System.Drawing.Point(103, 353);
            this.timequick.Name = "timequick";
            this.timequick.Size = new System.Drawing.Size(0, 21);
            this.timequick.TabIndex = 10;
            this.timequick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timebubble
            // 
            this.timebubble.AutoSize = true;
            this.timebubble.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timebubble.Location = new System.Drawing.Point(324, 353);
            this.timebubble.Name = "timebubble";
            this.timebubble.Size = new System.Drawing.Size(0, 21);
            this.timebubble.TabIndex = 11;
            this.timebubble.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timemerge
            // 
            this.timemerge.AutoSize = true;
            this.timemerge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timemerge.Location = new System.Drawing.Point(536, 353);
            this.timemerge.Name = "timemerge";
            this.timemerge.Size = new System.Drawing.Size(0, 21);
            this.timemerge.TabIndex = 12;
            this.timemerge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timegcf
            // 
            this.timegcf.AutoSize = true;
            this.timegcf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timegcf.Location = new System.Drawing.Point(756, 353);
            this.timegcf.Name = "timegcf";
            this.timegcf.Size = new System.Drawing.Size(0, 21);
            this.timegcf.TabIndex = 13;
            this.timegcf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timegcf.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 566);
            this.Controls.Add(this.timegcf);
            this.Controls.Add(this.timemerge);
            this.Controls.Add(this.timebubble);
            this.Controls.Add(this.timequick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datamerge);
            this.Controls.Add(this.databubble);
            this.Controls.Add(this.dataquick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortbutton);
            this.Controls.Add(this.inputnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataquick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputnumber;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataquick;
        private System.Windows.Forms.DataGridView databubble;
        private System.Windows.Forms.DataGridView datamerge;
        private System.Windows.Forms.DataGridView dataGCF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label timequick;
        private System.Windows.Forms.Label timebubble;
        private System.Windows.Forms.Label timemerge;
        private System.Windows.Forms.Label timegcf;
    }
}

