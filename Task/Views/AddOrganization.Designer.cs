namespace Task.Views
{
    partial class AddOrganization
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
            this.addOrganizationButton = new System.Windows.Forms.Button();
            this.cancelFormButton = new System.Windows.Forms.Button();
            this.nameOrganizationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrganizationButton
            // 
            this.addOrganizationButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addOrganizationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrganizationButton.Location = new System.Drawing.Point(15, 165);
            this.addOrganizationButton.Name = "addOrganizationButton";
            this.addOrganizationButton.Size = new System.Drawing.Size(104, 31);
            this.addOrganizationButton.TabIndex = 1;
            this.addOrganizationButton.Text = "Добавить";
            this.addOrganizationButton.UseVisualStyleBackColor = true;
            this.addOrganizationButton.Click += new System.EventHandler(this.addOrganizationButton_Click);
            // 
            // cancelFormButton
            // 
            this.cancelFormButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelFormButton.Location = new System.Drawing.Point(308, 165);
            this.cancelFormButton.Name = "cancelFormButton";
            this.cancelFormButton.Size = new System.Drawing.Size(104, 31);
            this.cancelFormButton.TabIndex = 2;
            this.cancelFormButton.Text = "Отмена";
            this.cancelFormButton.UseVisualStyleBackColor = true;
            this.cancelFormButton.Click += new System.EventHandler(this.cancelFormButton_Click);
            // 
            // nameOrganizationTextBox
            // 
            this.nameOrganizationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameOrganizationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOrganizationTextBox.Location = new System.Drawing.Point(15, 31);
            this.nameOrganizationTextBox.Name = "nameOrganizationTextBox";
            this.nameOrganizationTextBox.Size = new System.Drawing.Size(397, 26);
            this.nameOrganizationTextBox.TabIndex = 3;
            this.nameOrganizationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameOrganizationTextBox_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название организации";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(15, 133);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(397, 26);
            this.dateTextBox.TabIndex = 26;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            this.dateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dateTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Дата заключения договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Номер договора";
            // 
            // contractTextBox
            // 
            this.contractTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractTextBox.Location = new System.Drawing.Point(15, 82);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.Size = new System.Drawing.Size(397, 26);
            this.contractTextBox.TabIndex = 23;
            this.contractTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.contractTextBox_Validating);
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
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 209);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOrganizationTextBox);
            this.Controls.Add(this.cancelFormButton);
            this.Controls.Add(this.addOrganizationButton);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddOrganization";
            this.Text = "Добавить организацию";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addOrganizationButton;
        private System.Windows.Forms.Button cancelFormButton;
        private System.Windows.Forms.TextBox nameOrganizationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}