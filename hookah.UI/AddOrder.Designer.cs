namespace hookah.UI
{
    partial class AddOrder
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
            this.strengthComboBox = new System.Windows.Forms.ComboBox();
            this.tobaccoComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.hookahComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.exception = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strengthComboBox
            // 
            this.strengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strengthComboBox.FormattingEnabled = true;
            this.strengthComboBox.Items.AddRange(new object[] {
            "Лёгкая",
            "Средняя",
            "Тяжёлая"});
            this.strengthComboBox.Location = new System.Drawing.Point(124, 41);
            this.strengthComboBox.Name = "strengthComboBox";
            this.strengthComboBox.Size = new System.Drawing.Size(269, 21);
            this.strengthComboBox.TabIndex = 0;
            // 
            // tobaccoComboBox
            // 
            this.tobaccoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tobaccoComboBox.FormattingEnabled = true;
            this.tobaccoComboBox.Items.AddRange(new object[] {
            "ALFAKHER",
            "NAKHLA",
            "AFZAL",
            "ADALYA",
            "SERBETLI",
            "DARKSIDE",
            "TANGIERS"});
            this.tobaccoComboBox.Location = new System.Drawing.Point(124, 83);
            this.tobaccoComboBox.Name = "tobaccoComboBox";
            this.tobaccoComboBox.Size = new System.Drawing.Size(269, 21);
            this.tobaccoComboBox.TabIndex = 1;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "На молоке",
            "С фруктами",
            "С мятой и льдом"});
            this.typeComboBox.Location = new System.Drawing.Point(124, 125);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(269, 21);
            this.typeComboBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(124, 172);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(269, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // hookahComboBox
            // 
            this.hookahComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hookahComboBox.FormattingEnabled = true;
            this.hookahComboBox.Location = new System.Drawing.Point(124, 217);
            this.hookahComboBox.Name = "hookahComboBox";
            this.hookahComboBox.Size = new System.Drawing.Size(269, 21);
            this.hookahComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Крепость кальяна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид табака";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Способ забивки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кальянщик";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(141, 268);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 39);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // exception
            // 
            this.exception.AutoSize = true;
            this.exception.ForeColor = System.Drawing.Color.Red;
            this.exception.Location = new System.Drawing.Point(143, 248);
            this.exception.Name = "exception";
            this.exception.Size = new System.Drawing.Size(112, 13);
            this.exception.TabIndex = 15;
            this.exception.Text = "Заполните все поля!";
            this.exception.Visible = false;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 331);
            this.Controls.Add(this.exception);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hookahComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.tobaccoComboBox);
            this.Controls.Add(this.strengthComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox strengthComboBox;
        private System.Windows.Forms.ComboBox tobaccoComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox hookahComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label exception;
    }
}