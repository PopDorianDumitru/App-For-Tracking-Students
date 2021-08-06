
namespace Tema
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Numele = new System.Windows.Forms.TextBox();
            this.VarstStud = new System.Windows.Forms.NumericUpDown();
            this.AnulStud = new System.Windows.Forms.ComboBox();
            this.Not1 = new System.Windows.Forms.ComboBox();
            this.Not2 = new System.Windows.Forms.ComboBox();
            this.Not3 = new System.Windows.Forms.ComboBox();
            this.Not4 = new System.Windows.Forms.ComboBox();
            this.Not5 = new System.Windows.Forms.ComboBox();
            this.AdaugStud = new System.Windows.Forms.Button();
            this.OrdMed = new System.Windows.Forms.Button();
            this.OrdNum = new System.Windows.Forms.Button();
            this.AfisAn = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OptAn = new System.Windows.Forms.ComboBox();
            this.Sterge = new System.Windows.Forms.Button();
            this.ListStud = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.VarstStud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Note";
            // 
            // Numele
            // 
            this.Numele.Location = new System.Drawing.Point(90, 44);
            this.Numele.Name = "Numele";
            this.Numele.Size = new System.Drawing.Size(164, 23);
            this.Numele.TabIndex = 0;
            // 
            // VarstStud
            // 
            this.VarstStud.Location = new System.Drawing.Point(90, 73);
            this.VarstStud.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.VarstStud.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.VarstStud.Name = "VarstStud";
            this.VarstStud.Size = new System.Drawing.Size(35, 23);
            this.VarstStud.TabIndex = 1;
            this.VarstStud.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // AnulStud
            // 
            this.AnulStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnulStud.FormattingEnabled = true;
            this.AnulStud.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.AnulStud.Location = new System.Drawing.Point(90, 102);
            this.AnulStud.Name = "AnulStud";
            this.AnulStud.Size = new System.Drawing.Size(35, 23);
            this.AnulStud.TabIndex = 2;
            // 
            // Not1
            // 
            this.Not1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Not1.FormattingEnabled = true;
            this.Not1.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Not1.Location = new System.Drawing.Point(90, 131);
            this.Not1.Name = "Not1";
            this.Not1.Size = new System.Drawing.Size(53, 23);
            this.Not1.TabIndex = 3;
            // 
            // Not2
            // 
            this.Not2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Not2.FormattingEnabled = true;
            this.Not2.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Not2.Location = new System.Drawing.Point(149, 131);
            this.Not2.Name = "Not2";
            this.Not2.Size = new System.Drawing.Size(53, 23);
            this.Not2.TabIndex = 4;
            // 
            // Not3
            // 
            this.Not3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Not3.FormattingEnabled = true;
            this.Not3.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Not3.Location = new System.Drawing.Point(208, 131);
            this.Not3.Name = "Not3";
            this.Not3.Size = new System.Drawing.Size(53, 23);
            this.Not3.TabIndex = 5;
            // 
            // Not4
            // 
            this.Not4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Not4.FormattingEnabled = true;
            this.Not4.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Not4.Location = new System.Drawing.Point(267, 131);
            this.Not4.Name = "Not4";
            this.Not4.Size = new System.Drawing.Size(53, 23);
            this.Not4.TabIndex = 6;
            // 
            // Not5
            // 
            this.Not5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Not5.FormattingEnabled = true;
            this.Not5.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Not5.Location = new System.Drawing.Point(326, 131);
            this.Not5.Name = "Not5";
            this.Not5.Size = new System.Drawing.Size(53, 23);
            this.Not5.TabIndex = 7;
            // 
            // AdaugStud
            // 
            this.AdaugStud.Location = new System.Drawing.Point(90, 174);
            this.AdaugStud.Name = "AdaugStud";
            this.AdaugStud.Size = new System.Drawing.Size(199, 41);
            this.AdaugStud.TabIndex = 8;
            this.AdaugStud.Text = "Adauga";
            this.AdaugStud.UseVisualStyleBackColor = true;
            this.AdaugStud.Click += new System.EventHandler(this.AdaugStud_Click);
            // 
            // OrdMed
            // 
            this.OrdMed.Location = new System.Drawing.Point(6, 55);
            this.OrdMed.Name = "OrdMed";
            this.OrdMed.Size = new System.Drawing.Size(206, 28);
            this.OrdMed.TabIndex = 10;
            this.OrdMed.Text = "Ordonare dupa medie";
            this.OrdMed.UseVisualStyleBackColor = true;
            this.OrdMed.Click += new System.EventHandler(this.OrdMed_Click);
            // 
            // OrdNum
            // 
            this.OrdNum.Location = new System.Drawing.Point(6, 22);
            this.OrdNum.Name = "OrdNum";
            this.OrdNum.Size = new System.Drawing.Size(206, 28);
            this.OrdNum.TabIndex = 9;
            this.OrdNum.Text = "Ordonare dupa Name";
            this.OrdNum.UseVisualStyleBackColor = true;
            this.OrdNum.Click += new System.EventHandler(this.OrdNum_Click);
            // 
            // AfisAn
            // 
            this.AfisAn.Location = new System.Drawing.Point(6, 90);
            this.AfisAn.Name = "AfisAn";
            this.AfisAn.Size = new System.Drawing.Size(206, 28);
            this.AfisAn.TabIndex = 12;
            this.AfisAn.Text = "Afisarea studentiilor din anul:";
            this.AfisAn.UseVisualStyleBackColor = true;
            this.AfisAn.Click += new System.EventHandler(this.AfisAn_Click);
            // 
            // Cauta
            // 
            this.Cauta.Location = new System.Drawing.Point(6, 123);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(117, 28);
            this.Cauta.TabIndex = 14;
            this.Cauta.Text = "Cautare Name";
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.OrdNum);
            this.groupBox1.Controls.Add(this.Cauta);
            this.groupBox1.Controls.Add(this.AfisAn);
            this.groupBox1.Controls.Add(this.OrdMed);
            this.groupBox1.Controls.Add(this.OptAn);
            this.groupBox1.Location = new System.Drawing.Point(90, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afisare";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 23);
            this.textBox2.TabIndex = 13;
            // 
            // OptAn
            // 
            this.OptAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptAn.FormattingEnabled = true;
            this.OptAn.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.OptAn.Location = new System.Drawing.Point(218, 94);
            this.OptAn.Name = "OptAn";
            this.OptAn.Size = new System.Drawing.Size(47, 23);
            this.OptAn.TabIndex = 11;
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(590, 441);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(81, 28);
            this.Sterge.TabIndex = 15;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // ListStud
            // 
            this.ListStud.FormattingEnabled = true;
            this.ListStud.ItemHeight = 15;
            this.ListStud.Location = new System.Drawing.Point(411, 39);
            this.ListStud.Name = "ListStud";
            this.ListStud.Size = new System.Drawing.Size(288, 394);
            this.ListStud.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 481);
            this.Controls.Add(this.ListStud);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AdaugStud);
            this.Controls.Add(this.Not5);
            this.Controls.Add(this.Not4);
            this.Controls.Add(this.Not3);
            this.Controls.Add(this.Not2);
            this.Controls.Add(this.Not1);
            this.Controls.Add(this.AnulStud);
            this.Controls.Add(this.VarstStud);
            this.Controls.Add(this.Numele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarstStud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Numele;
        private System.Windows.Forms.NumericUpDown VarstStud;
        private System.Windows.Forms.ComboBox AnulStud;
        private System.Windows.Forms.ComboBox Not1;
        private System.Windows.Forms.ComboBox Not2;
        private System.Windows.Forms.ComboBox Not3;
        private System.Windows.Forms.ComboBox Not4;
        private System.Windows.Forms.ComboBox Not5;
        private System.Windows.Forms.Button AdaugStud;
        private System.Windows.Forms.Button OrdMed;
        private System.Windows.Forms.Button OrdNum;
        private System.Windows.Forms.Button AfisAn;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox OptAn;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox ListStud;
    }
}

