namespace Task.Views
{
    partial class AddCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stateRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bodyCapacityTextBox = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.cancelFormButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBrandTextBox.Location = new System.Drawing.Point(17, 36);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(298, 26);
            this.carBrandTextBox.TabIndex = 1;
            this.carBrandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carBrandTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carModelTextBox.Location = new System.Drawing.Point(17, 92);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(298, 26);
            this.carModelTextBox.TabIndex = 3;
            this.carModelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carModelTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Государственный регистрационный номер";
            // 
            // stateRegistrationNumberTextBox
            // 
            this.stateRegistrationNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateRegistrationNumberTextBox.Location = new System.Drawing.Point(17, 148);
            this.stateRegistrationNumberTextBox.Name = "stateRegistrationNumberTextBox";
            this.stateRegistrationNumberTextBox.Size = new System.Drawing.Size(298, 26);
            this.stateRegistrationNumberTextBox.TabIndex = 5;
            this.stateRegistrationNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateRegistrationNumberTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Объем кузова, (куб.м)";
            // 
            // bodyCapacityTextBox
            // 
            this.bodyCapacityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyCapacityTextBox.Location = new System.Drawing.Point(17, 204);
            this.bodyCapacityTextBox.Name = "bodyCapacityTextBox";
            this.bodyCapacityTextBox.Size = new System.Drawing.Size(298, 26);
            this.bodyCapacityTextBox.TabIndex = 7;
            this.bodyCapacityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bodyCapacityTextBox_Validating);
            // 
            // addCarButton
            // 
            this.addCarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarButton.Location = new System.Drawing.Point(17, 237);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(104, 31);
            this.addCarButton.TabIndex = 8;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // cancelFormButton
            // 
            this.cancelFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelFormButton.Location = new System.Drawing.Point(211, 236);
            this.cancelFormButton.Name = "cancelFormButton";
            this.cancelFormButton.Size = new System.Drawing.Size(104, 31);
            this.cancelFormButton.TabIndex = 9;
            this.cancelFormButton.Text = "Отмена";
            this.cancelFormButton.UseVisualStyleBackColor = true;
            this.cancelFormButton.Click += new System.EventHandler(this.cancelFormButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 285);
            this.Controls.Add(this.cancelFormButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.bodyCapacityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stateRegistrationNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carBrandTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddCar";
            this.Text = "Добавить автомобиль";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stateRegistrationNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bodyCapacityTextBox;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button cancelFormButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}