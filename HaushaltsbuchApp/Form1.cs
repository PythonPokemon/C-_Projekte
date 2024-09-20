using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HaushaltsbuchApp
{
    public partial class Form1 : Form
    {
        private DataGridView table;
        private TextBox amountField;
        private TextBox descriptionField;
        private ComboBox categoryComboBox;
        private ComboBox typeComboBox;
        private Label totalIncomeLabel;
        private Label totalExpensesLabel;
        private Label netBalanceLabel;
        private double totalIncome = 0;
        private double totalExpenses = 0;

        public Form1()
        {
            InitializeComponent();

            // Tabelle konfigurieren
            var columns = new string[] { "Betrag", "Beschreibung", "Kategorie", "Typ" };
            table = new DataGridView
            {
                ColumnCount = columns.Length,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            for (int i = 0; i < columns.Length; i++)
            {
                table.Columns[i].Name = columns[i];
            }

            // Eingabefelder
            amountField = new TextBox { Width = 80 };
            descriptionField = new TextBox { Width = 100 };
            categoryComboBox = new ComboBox
            {
                Items = { "Miete", "Lebensmittel", "Unterhaltung", "Transport", "Sonstiges" },
                Width = 100
            };
            categoryComboBox.SelectedIndex = 0;
            typeComboBox = new ComboBox
            {
                Items = { "Einnahmen", "Ausgaben" },
                Width = 100
            };
            typeComboBox.SelectedIndex = 0;

            // Hinzufügen-Button
            var addButton = new Button { Text = "Hinzufügen" };
            addButton.Click += (sender, args) => AddEntry();

            // Layout für Eingaben und Button
            var inputPanel = new FlowLayoutPanel { Dock = DockStyle.Top };
            inputPanel.Controls.Add(new Label { Text = "Betrag:" });
            inputPanel.Controls.Add(amountField);
            inputPanel.Controls.Add(new Label { Text = "Beschreibung:" });
            inputPanel.Controls.Add(descriptionField);
            inputPanel.Controls.Add(new Label { Text = "Kategorie:" });
            inputPanel.Controls.Add(categoryComboBox);
            inputPanel.Controls.Add(new Label { Text = "Typ:" });
            inputPanel.Controls.Add(typeComboBox);
            inputPanel.Controls.Add(addButton);

            // Gesamtübersicht
            var summaryPanel = new FlowLayoutPanel { Dock = DockStyle.Bottom };
            totalIncomeLabel = new Label { Text = "Gesamteinnahmen: 0.00 EUR" };
            totalExpensesLabel = new Label { Text = "Gesamtausgaben: 0.00 EUR" };
            netBalanceLabel = new Label { Text = "Restwert: 0.00 EUR" };
            summaryPanel.Controls.Add(totalIncomeLabel);
            summaryPanel.Controls.Add(totalExpensesLabel);
            summaryPanel.Controls.Add(netBalanceLabel);

            // Daten speichern und laden
            var filePanel = new FlowLayoutPanel { Dock = DockStyle.Left };
            var saveButton = new Button { Text = "Speichern" };
            saveButton.Click += (sender, args) => SaveData();
            var loadButton = new Button { Text = "Laden" };
            loadButton.Click += (sender, args) => LoadData();
            filePanel.Controls.Add(saveButton);
            filePanel.Controls.Add(loadButton);

            // Frame Layout
            var mainPanel = new Panel { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(table);
            this.Controls.Add(mainPanel);
            this.Controls.Add(inputPanel);
            this.Controls.Add(summaryPanel);
            this.Controls.Add(filePanel);
        }

        // Methode zum Hinzufügen eines Postens
        private void AddEntry()
        {
            if (double.TryParse(amountField.Text, out double amount))
            {
                var description = descriptionField.Text;
                var category = categoryComboBox.SelectedItem.ToString();
                var type = typeComboBox.SelectedItem.ToString();

                table.Rows.Add(amount.ToString("F2"), description, category, type);

                // Einnahmen und Ausgaben aktualisieren
                if (type == "Einnahmen")
                {
                    totalIncome += amount;
                }
                else
                {
                    totalExpenses += amount;
                }

                UpdateSummary();
                amountField.Clear();
                descriptionField.Clear();
            }
            else
            {
                MessageBox.Show("Bitte einen gültigen Betrag eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode zur Aktualisierung der Gesamtübersicht
        private void UpdateSummary()
        {
            totalIncomeLabel.Text = $"Gesamteinnahmen: {totalIncome:F2} EUR";
            totalExpensesLabel.Text = $"Gesamtausgaben: {totalExpenses:F2} EUR";
            netBalanceLabel.Text = $"Restwert: {totalIncome - totalExpenses:F2} EUR";
        }

        // Daten speichern
        private void SaveData()
        {
            using (var writer = new StreamWriter("budget_data.csv"))
            {
                foreach (DataGridViewRow row in table.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                        writer.WriteLine(string.Join(";", values));
                    }
                }
            }
            MessageBox.Show("Daten erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Daten laden
        private void LoadData()
        {
            if (File.Exists("budget_data.csv"))
            {
                using (var reader = new StreamReader("budget_data.csv"))
                {
                    table.Rows.Clear();
                    totalIncome = 0;
                    totalExpenses = 0;

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(';');  // Verwende das Semikolon als Trennzeichen
                        table.Rows.Add(values);

                        double amount = double.Parse(values[0]);
                        string type = values[3];

                        if (type == "Einnahmen")
                        {
                            totalIncome += amount;
                        }
                        else if (type == "Ausgaben")
                        {
                            totalExpenses += amount;
                        }
                    }
                    UpdateSummary();
                }
                MessageBox.Show("Daten erfolgreich geladen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Keine gespeicherten Daten gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
