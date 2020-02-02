namespace Calc
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPower2 = new System.Windows.Forms.Button();
            this.buttonPowerN = new System.Windows.Forms.Button();
            this.buttonRoot2 = new System.Windows.Forms.Button();
            this.buttonRootN = new System.Windows.Forms.Button();
            this.buttonLogN = new System.Windows.Forms.Button();
            this.buttonFact = new System.Windows.Forms.Button();
            this.buttonMed = new System.Windows.Forms.Button();
            this.buttonOtkl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 60);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(260, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Прибавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(12, 90);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(260, 23);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "Отнять";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(12, 120);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(260, 23);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "Умножить";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(12, 150);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(260, 23);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Разделить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPower2
            // 
            this.buttonPower2.Location = new System.Drawing.Point(12, 180);
            this.buttonPower2.Name = "buttonPower2";
            this.buttonPower2.Size = new System.Drawing.Size(260, 23);
            this.buttonPower2.TabIndex = 6;
            this.buttonPower2.Text = "Возвести в квадрат";
            this.buttonPower2.UseVisualStyleBackColor = true;
            this.buttonPower2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPowerN
            // 
            this.buttonPowerN.Location = new System.Drawing.Point(12, 210);
            this.buttonPowerN.Name = "buttonPowerN";
            this.buttonPowerN.Size = new System.Drawing.Size(260, 23);
            this.buttonPowerN.TabIndex = 7;
            this.buttonPowerN.Text = "Возвести в степень";
            this.buttonPowerN.UseVisualStyleBackColor = true;
            this.buttonPowerN.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRoot2
            // 
            this.buttonRoot2.Location = new System.Drawing.Point(13, 240);
            this.buttonRoot2.Name = "buttonRoot2";
            this.buttonRoot2.Size = new System.Drawing.Size(260, 23);
            this.buttonRoot2.TabIndex = 8;
            this.buttonRoot2.Text = "Квадратный корень";
            this.buttonRoot2.UseVisualStyleBackColor = true;
            this.buttonRoot2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRootN
            // 
            this.buttonRootN.Location = new System.Drawing.Point(12, 270);
            this.buttonRootN.Name = "buttonRootN";
            this.buttonRootN.Size = new System.Drawing.Size(260, 23);
            this.buttonRootN.TabIndex = 9;
            this.buttonRootN.Text = "Корень заданной степени";
            this.buttonRootN.UseVisualStyleBackColor = true;
            this.buttonRootN.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLogN
            // 
            this.buttonLogN.Location = new System.Drawing.Point(12, 300);
            this.buttonLogN.Name = "buttonLogN";
            this.buttonLogN.Size = new System.Drawing.Size(260, 23);
            this.buttonLogN.TabIndex = 10;
            this.buttonLogN.Text = "Логарифм по заданному основанию";
            this.buttonLogN.UseVisualStyleBackColor = true;
            this.buttonLogN.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFact
            // 
            this.buttonFact.Location = new System.Drawing.Point(12, 330);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(260, 23);
            this.buttonFact.TabIndex = 11;
            this.buttonFact.Text = "Факториал";
            this.buttonFact.UseVisualStyleBackColor = true;
            this.buttonFact.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMed
            // 
            this.buttonMed.Location = new System.Drawing.Point(12, 360);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(260, 23);
            this.buttonMed.TabIndex = 12;
            this.buttonMed.Text = "Медиана";
            this.buttonMed.UseVisualStyleBackColor = true;
            this.buttonMed.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOtkl
            // 
            this.buttonOtkl.Location = new System.Drawing.Point(12, 390);
            this.buttonOtkl.Name = "buttonOtkl";
            this.buttonOtkl.Size = new System.Drawing.Size(260, 23);
            this.buttonOtkl.TabIndex = 13;
            this.buttonOtkl.Text = "Стандартное отклонение";
            this.buttonOtkl.UseVisualStyleBackColor = true;
            this.buttonOtkl.Click += new System.EventHandler(this.button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(280, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 381);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 462);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOtkl);
            this.Controls.Add(this.buttonMed);
            this.Controls.Add(this.buttonFact);
            this.Controls.Add(this.buttonLogN);
            this.Controls.Add(this.buttonRootN);
            this.Controls.Add(this.buttonRoot2);
            this.Controls.Add(this.buttonPowerN);
            this.Controls.Add(this.buttonPower2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPower2;
        private System.Windows.Forms.Button buttonPowerN;
        private System.Windows.Forms.Button buttonRoot2;
        private System.Windows.Forms.Button buttonRootN;
        private System.Windows.Forms.Button buttonLogN;
        private System.Windows.Forms.Button buttonFact;
        private System.Windows.Forms.Button buttonMed;
        private System.Windows.Forms.Button buttonOtkl;
        private System.Windows.Forms.ListBox listBox1;
    }
}