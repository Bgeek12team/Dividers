namespace Interface
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
            this.btn_PrimeCheck = new System.Windows.Forms.Button();
            this.lbl_NumIsPrime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txBx_PrimeDecomposition = new System.Windows.Forms.TextBox();
            this.btn_GetDecomposition = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_IsDivider = new System.Windows.Forms.Label();
            this.btn_DivCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txBx_Divider = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txBx_Start = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txBx_End = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txBx_Primes = new System.Windows.Forms.TextBox();
            this.btn_GetPrimes = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txBx_AllDividers = new System.Windows.Forms.TextBox();
            this.btn_GetDivList = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txBx_lineDiv = new System.Windows.Forms.TextBox();
            this.btn_lineDiv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txBx_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gB_Num = new System.Windows.Forms.GroupBox();
            this.gB_lineSeg = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gB_Num.SuspendLayout();
            this.gB_lineSeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проект \"Делители\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Работа с отдельным числом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(568, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Работа с отрезком чисел";
            // 
            // btn_PrimeCheck
            // 
            this.btn_PrimeCheck.Location = new System.Drawing.Point(15, 35);
            this.btn_PrimeCheck.Name = "btn_PrimeCheck";
            this.btn_PrimeCheck.Size = new System.Drawing.Size(415, 55);
            this.btn_PrimeCheck.TabIndex = 5;
            this.btn_PrimeCheck.Text = "Проверить на простоту";
            this.btn_PrimeCheck.UseVisualStyleBackColor = true;
            this.btn_PrimeCheck.Click += new System.EventHandler(this.btn_PrimeCheck_Click);
            // 
            // lbl_NumIsPrime
            // 
            this.lbl_NumIsPrime.AutoSize = true;
            this.lbl_NumIsPrime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NumIsPrime.Location = new System.Drawing.Point(15, 93);
            this.lbl_NumIsPrime.Name = "lbl_NumIsPrime";
            this.lbl_NumIsPrime.Size = new System.Drawing.Size(222, 25);
            this.lbl_NumIsPrime.TabIndex = 6;
            this.lbl_NumIsPrime.Text = "Статус неопределен";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_NumIsPrime);
            this.groupBox1.Controls.Add(this.btn_PrimeCheck);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проверка на простоту";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txBx_PrimeDecomposition);
            this.groupBox2.Controls.Add(this.btn_GetDecomposition);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(8, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 197);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Факторизация";
            // 
            // txBx_PrimeDecomposition
            // 
            this.txBx_PrimeDecomposition.Location = new System.Drawing.Point(9, 121);
            this.txBx_PrimeDecomposition.Multiline = true;
            this.txBx_PrimeDecomposition.Name = "txBx_PrimeDecomposition";
            this.txBx_PrimeDecomposition.ReadOnly = true;
            this.txBx_PrimeDecomposition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBx_PrimeDecomposition.Size = new System.Drawing.Size(415, 71);
            this.txBx_PrimeDecomposition.TabIndex = 9;
            // 
            // btn_GetDecomposition
            // 
            this.btn_GetDecomposition.Location = new System.Drawing.Point(9, 36);
            this.btn_GetDecomposition.Name = "btn_GetDecomposition";
            this.btn_GetDecomposition.Size = new System.Drawing.Size(415, 79);
            this.btn_GetDecomposition.TabIndex = 7;
            this.btn_GetDecomposition.Text = "Получить разложение на простые множители";
            this.btn_GetDecomposition.UseVisualStyleBackColor = true;
            this.btn_GetDecomposition.Click += new System.EventHandler(this.btn_GetDecomposition_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_IsDivider);
            this.groupBox3.Controls.Add(this.btn_DivCheck);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txBx_Divider);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(6, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 157);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка делителя";
            // 
            // lbl_IsDivider
            // 
            this.lbl_IsDivider.AutoSize = true;
            this.lbl_IsDivider.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IsDivider.Location = new System.Drawing.Point(11, 124);
            this.lbl_IsDivider.Name = "lbl_IsDivider";
            this.lbl_IsDivider.Size = new System.Drawing.Size(222, 25);
            this.lbl_IsDivider.TabIndex = 7;
            this.lbl_IsDivider.Text = "Статус неопределен";
            // 
            // btn_DivCheck
            // 
            this.btn_DivCheck.Location = new System.Drawing.Point(11, 67);
            this.btn_DivCheck.Name = "btn_DivCheck";
            this.btn_DivCheck.Size = new System.Drawing.Size(415, 55);
            this.btn_DivCheck.TabIndex = 7;
            this.btn_DivCheck.Text = "Проверить делитель";
            this.btn_DivCheck.UseVisualStyleBackColor = true;
            this.btn_DivCheck.Click += new System.EventHandler(this.btn_DivCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите делитель:";
            // 
            // txBx_Divider
            // 
            this.txBx_Divider.Location = new System.Drawing.Point(210, 25);
            this.txBx_Divider.Name = "txBx_Divider";
            this.txBx_Divider.Size = new System.Drawing.Size(216, 34);
            this.txBx_Divider.TabIndex = 5;
            this.txBx_Divider.TextChanged += new System.EventHandler(this.txBx_Divider_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(568, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите начало отрезка:";
            // 
            // txBx_Start
            // 
            this.txBx_Start.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_Start.Location = new System.Drawing.Point(568, 141);
            this.txBx_Start.Name = "txBx_Start";
            this.txBx_Start.Size = new System.Drawing.Size(421, 34);
            this.txBx_Start.TabIndex = 10;
            this.txBx_Start.TextChanged += new System.EventHandler(this.txBx_Start_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(568, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите конец отрезка:";
            // 
            // txBx_End
            // 
            this.txBx_End.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_End.Location = new System.Drawing.Point(568, 212);
            this.txBx_End.Name = "txBx_End";
            this.txBx_End.Size = new System.Drawing.Size(421, 34);
            this.txBx_End.TabIndex = 12;
            this.txBx_End.TextChanged += new System.EventHandler(this.txBx_End_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txBx_Primes);
            this.groupBox4.Controls.Add(this.btn_GetPrimes);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(6, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 265);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Получение простых чисел на отрезке";
            // 
            // txBx_Primes
            // 
            this.txBx_Primes.Location = new System.Drawing.Point(6, 97);
            this.txBx_Primes.Multiline = true;
            this.txBx_Primes.Name = "txBx_Primes";
            this.txBx_Primes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBx_Primes.Size = new System.Drawing.Size(415, 161);
            this.txBx_Primes.TabIndex = 10;
            // 
            // btn_GetPrimes
            // 
            this.btn_GetPrimes.Location = new System.Drawing.Point(6, 36);
            this.btn_GetPrimes.Name = "btn_GetPrimes";
            this.btn_GetPrimes.Size = new System.Drawing.Size(415, 55);
            this.btn_GetPrimes.TabIndex = 10;
            this.btn_GetPrimes.Text = "Получить список простых чисел";
            this.btn_GetPrimes.UseVisualStyleBackColor = true;
            this.btn_GetPrimes.Click += new System.EventHandler(this.btn_GetPrimes_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txBx_AllDividers);
            this.groupBox5.Controls.Add(this.btn_GetDivList);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(8, 523);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(455, 197);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Получение списка делителей";
            // 
            // txBx_AllDividers
            // 
            this.txBx_AllDividers.Location = new System.Drawing.Point(9, 80);
            this.txBx_AllDividers.Multiline = true;
            this.txBx_AllDividers.Name = "txBx_AllDividers";
            this.txBx_AllDividers.ReadOnly = true;
            this.txBx_AllDividers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBx_AllDividers.Size = new System.Drawing.Size(415, 111);
            this.txBx_AllDividers.TabIndex = 9;
            // 
            // btn_GetDivList
            // 
            this.btn_GetDivList.Location = new System.Drawing.Point(9, 36);
            this.btn_GetDivList.Name = "btn_GetDivList";
            this.btn_GetDivList.Size = new System.Drawing.Size(415, 37);
            this.btn_GetDivList.TabIndex = 7;
            this.btn_GetDivList.Text = "Получить список делителей";
            this.btn_GetDivList.UseVisualStyleBackColor = true;
            this.btn_GetDivList.Click += new System.EventHandler(this.btn_GetDivList_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txBx_lineDiv);
            this.groupBox6.Controls.Add(this.btn_lineDiv);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(6, 295);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 343);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поиск чисел с заданным количеством небазовых делителей";
            // 
            // txBx_lineDiv
            // 
            this.txBx_lineDiv.Location = new System.Drawing.Point(16, 161);
            this.txBx_lineDiv.Multiline = true;
            this.txBx_lineDiv.Name = "txBx_lineDiv";
            this.txBx_lineDiv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBx_lineDiv.Size = new System.Drawing.Size(409, 175);
            this.txBx_lineDiv.TabIndex = 10;
            // 
            // btn_lineDiv
            // 
            this.btn_lineDiv.Location = new System.Drawing.Point(15, 107);
            this.btn_lineDiv.Name = "btn_lineDiv";
            this.btn_lineDiv.Size = new System.Drawing.Size(410, 55);
            this.btn_lineDiv.TabIndex = 7;
            this.btn_lineDiv.Text = "Найти числа";
            this.btn_lineDiv.UseVisualStyleBackColor = true;
            this.btn_lineDiv.Click += new System.EventHandler(this.btn_lineDiv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Введите количество делителей:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 34);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "3";
            // 
            // txBx_Number
            // 
            this.txBx_Number.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_Number.Location = new System.Drawing.Point(169, 129);
            this.txBx_Number.Name = "txBx_Number";
            this.txBx_Number.Size = new System.Drawing.Size(285, 34);
            this.txBx_Number.TabIndex = 3;
            this.txBx_Number.TextChanged += new System.EventHandler(this.txBx_Number_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите число:";
            // 
            // gB_Num
            // 
            this.gB_Num.Controls.Add(this.groupBox5);
            this.gB_Num.Controls.Add(this.groupBox3);
            this.gB_Num.Controls.Add(this.groupBox2);
            this.gB_Num.Controls.Add(this.groupBox1);
            this.gB_Num.Location = new System.Drawing.Point(14, 175);
            this.gB_Num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_Num.Name = "gB_Num";
            this.gB_Num.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_Num.Size = new System.Drawing.Size(473, 733);
            this.gB_Num.TabIndex = 15;
            this.gB_Num.TabStop = false;
            // 
            // gB_lineSeg
            // 
            this.gB_lineSeg.Controls.Add(this.groupBox6);
            this.gB_lineSeg.Controls.Add(this.groupBox4);
            this.gB_lineSeg.Location = new System.Drawing.Point(562, 257);
            this.gB_lineSeg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_lineSeg.Name = "gB_lineSeg";
            this.gB_lineSeg.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_lineSeg.Size = new System.Drawing.Size(450, 651);
            this.gB_lineSeg.TabIndex = 16;
            this.gB_lineSeg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 924);
            this.Controls.Add(this.gB_lineSeg);
            this.Controls.Add(this.gB_Num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBx_End);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBx_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBx_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gB_Num.ResumeLayout(false);
            this.gB_lineSeg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_PrimeCheck;
        private Label lbl_NumIsPrime;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txBx_PrimeDecomposition;
        private Button btn_GetDecomposition;
        private GroupBox groupBox3;
        private Button btn_DivCheck;
        private Label label5;
        private TextBox txBx_Divider;
        private Label lbl_IsDivider;
        private Label label6;
        private TextBox txBx_Start;
        private Label label7;
        private TextBox txBx_End;
        private GroupBox groupBox4;
        private TextBox txBx_Primes;
        private Button btn_GetPrimes;
        private GroupBox groupBox5;
        private TextBox txBx_AllDividers;
        private Button btn_GetDivList;
        private GroupBox groupBox6;
        private TextBox txBx_lineDiv;
        private Button btn_lineDiv;
        private Label label9;
        private TextBox textBox2;
        private Label label4;
        private TextBox txBx_Number;
        private GroupBox gB_Num;
        private GroupBox gB_lineSeg;
    }
}