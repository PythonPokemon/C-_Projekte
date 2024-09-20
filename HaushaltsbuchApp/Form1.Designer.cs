namespace HaushaltsbuchApp
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label totalExpensesLabel;
        private System.Windows.Forms.Label netBalanceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;

        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.amountField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.totalExpensesLabel = new System.Windows.Forms.Label();
            this.netBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();

            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 100);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(760, 200);
            this.table.TabIndex = 0;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(12, 20);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(100, 22);
            this.amountField.TabIndex = 1;

            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(130, 20);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(100, 22);
            this.descriptionField.TabIndex = 2;

            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] { "Miete", "Lebensmittel", "Unterhaltung", "Transport", "Sonstiges" });
            this.categoryComboBox.Location = new System.Drawing.Point(250, 20);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoryComboBox.TabIndex = 3;

            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] { "Einnahmen", "Ausgaben" });
            this.typeComboBox.Location = new System.Drawing.Point(390, 20);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 4;

            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(530, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Hinzufügen";
            this.addButton.UseVisualStyleBackColor = true;

            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;

            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(100, 320);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Laden";
            this.loadButton.UseVisualStyleBackColor = true;

            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Location = new System.Drawing.Point(12, 360);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(0, 17);
            this.totalIncomeLabel.TabIndex = 8;

            // 
            // totalExpensesLabel
            // 
            this.totalExpensesLabel.AutoSize = true;
            this.totalExpensesLabel.Location = new System.Drawing.Point(12, 380);
            this.totalExpensesLabel.Name = "totalExpensesLabel";
            this.totalExpensesLabel.Size = new System.Drawing.Size(0, 17);
            this.totalExpensesLabel.TabIndex = 9;

            // 
            // netBalanceLabel
            // 
            this.netBalanceLabel.AutoSize = true;
            this.netBalanceLabel.Location = new System.Drawing.Point(12, 400);
            this.netBalanceLabel.Name = "netBalanceLabel";
            this.netBalanceLabel.Size = new System.Drawing.Size(0, 17);
            this.netBalanceLabel.TabIndex = 10;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.netBalanceLabel);
            this.Controls.Add(this.totalExpensesLabel);
            this.Controls.Add(this.totalIncomeLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Haushaltsbuch";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
