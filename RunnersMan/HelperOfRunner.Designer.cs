namespace RunnersMan
{
    partial class HelperOfRunner
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.comboBoxOfRunners = new System.Windows.Forms.ComboBox();
            this.cardCVC = new System.Windows.Forms.TextBox();
            this.yearCard = new System.Windows.Forms.TextBox();
            this.choosePrice = new System.Windows.Forms.TextBox();
            this.monthCard = new System.Windows.Forms.TextBox();
            this.ownerOfCard = new System.Windows.Forms.TextBox();
            this.yourName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 33);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTime.Location = new System.Drawing.Point(0, 498);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(800, 52);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label2";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.plusBtn);
            this.panel2.Controls.Add(this.minusBtn);
            this.panel2.Controls.Add(this.comboBoxOfRunners);
            this.panel2.Controls.Add(this.cardCVC);
            this.panel2.Controls.Add(this.yearCard);
            this.panel2.Controls.Add(this.choosePrice);
            this.panel2.Controls.Add(this.monthCard);
            this.panel2.Controls.Add(this.ownerOfCard);
            this.panel2.Controls.Add(this.yourName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 420);
            this.panel2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(192, 288);
            this.maskedTextBox1.Mask = "0000 0000 0000 0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(209, 32);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(471, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Благотворительность";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(462, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 36);
            this.label12.TabIndex = 31;
            this.label12.Text = "Название";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(800, 98);
            this.label11.TabIndex = 30;
            this.label11.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму, которую в" +
    "ы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их благотворительн" +
    "ых учреждений.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(255, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 34);
            this.label10.TabIndex = 29;
            this.label10.Text = "Спонсор бегуна";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(12, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 36);
            this.label9.TabIndex = 28;
            this.label9.Text = "Информация о спонсоре";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "Номер карты#:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "Срок действия:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "CVC:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Карта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Бегун:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ваше имя:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(458, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сумма пожертвования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Gray;
            this.price.Location = new System.Drawing.Point(458, 247);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(265, 89);
            this.price.TabIndex = 3;
            this.price.Text = "$ 50";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(742, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "i";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(598, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Заплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(647, 335);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(33, 33);
            this.plusBtn.TabIndex = 2;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(502, 335);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(33, 33);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxOfRunners
            // 
            this.comboBoxOfRunners.DropDownHeight = 150;
            this.comboBoxOfRunners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfRunners.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxOfRunners.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.comboBoxOfRunners.IntegralHeight = false;
            this.comboBoxOfRunners.Location = new System.Drawing.Point(106, 208);
            this.comboBoxOfRunners.MaxDropDownItems = 1;
            this.comboBoxOfRunners.MaxLength = 2;
            this.comboBoxOfRunners.Name = "comboBoxOfRunners";
            this.comboBoxOfRunners.Size = new System.Drawing.Size(295, 33);
            this.comboBoxOfRunners.TabIndex = 17;
            this.comboBoxOfRunners.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfRunners_SelectedIndexChanged);
            // 
            // cardCVC
            // 
            this.cardCVC.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.cardCVC.Location = new System.Drawing.Point(192, 363);
            this.cardCVC.Name = "cardCVC";
            this.cardCVC.Size = new System.Drawing.Size(71, 32);
            this.cardCVC.TabIndex = 16;
            this.cardCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardCVC_KeyPress);
            // 
            // yearCard
            // 
            this.yearCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.yearCard.Location = new System.Drawing.Point(261, 325);
            this.yearCard.Name = "yearCard";
            this.yearCard.Size = new System.Drawing.Size(73, 32);
            this.yearCard.TabIndex = 15;
            this.yearCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearCard_KeyPress);
            // 
            // choosePrice
            // 
            this.choosePrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.choosePrice.Location = new System.Drawing.Point(541, 336);
            this.choosePrice.Name = "choosePrice";
            this.choosePrice.Size = new System.Drawing.Size(100, 32);
            this.choosePrice.TabIndex = 14;
            this.choosePrice.Text = "50";
            this.choosePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.choosePrice.TextChanged += new System.EventHandler(this.choosePrice_TextChanged);
            this.choosePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.choosePrice_KeyPress);
            // 
            // monthCard
            // 
            this.monthCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.monthCard.Location = new System.Drawing.Point(192, 325);
            this.monthCard.Name = "monthCard";
            this.monthCard.Size = new System.Drawing.Size(53, 32);
            this.monthCard.TabIndex = 13;
            this.monthCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthCard_KeyPress);
            // 
            // ownerOfCard
            // 
            this.ownerOfCard.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.ownerOfCard.Location = new System.Drawing.Point(192, 249);
            this.ownerOfCard.Name = "ownerOfCard";
            this.ownerOfCard.Size = new System.Drawing.Size(209, 32);
            this.ownerOfCard.TabIndex = 11;
            // 
            // yourName
            // 
            this.yourName.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.yourName.Location = new System.Drawing.Point(192, 170);
            this.yourName.Name = "yourName";
            this.yourName.Size = new System.Drawing.Size(209, 32);
            this.yourName.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HelperOfRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 589);
            this.MinimumSize = new System.Drawing.Size(816, 589);
            this.Name = "HelperOfRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelperOfRunner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelperOfRunner_FormClosed);
            this.Load += new System.EventHandler(this.HelperOfRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.ComboBox comboBoxOfRunners;
        private System.Windows.Forms.TextBox cardCVC;
        private System.Windows.Forms.TextBox yearCard;
        private System.Windows.Forms.TextBox choosePrice;
        private System.Windows.Forms.TextBox monthCard;
        private System.Windows.Forms.TextBox ownerOfCard;
        private System.Windows.Forms.TextBox yourName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}