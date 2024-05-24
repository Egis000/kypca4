using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kypca4
{
    public partial class Form1 : Form
    {
        private List<Purchase> purchaseList = new List<Purchase>();
        private const string purchaseFilePath = "purchase.xml";
        private const int DaysInMonth = 30;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(periodComboBox, "ѕериод закупки за последние 1, 2, 3, 4 и 5 мес€цев.");
            toolTip1.SetToolTip(textBoxAdd, "ќставить пустым дл€ добавлени€ новой строки.");
            toolTip1.IsBalloon = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            periodComboBox.Items.AddRange(new object[] { "All", "1", "2", "3", "4", "5" });
            periodComboBox.SelectedIndex = 0;

            supplierComboBox.Items.AddRange(new object[] { "All", "OceanicEnterprises", "SummitSolutions", "StellarImports", "HorizonTradingCo", "GlobalMerchantsInc" });
            supplierComboBox.SelectedIndex = 0;

            foreach (var supplier in Enum.GetValues(typeof(Supplier)))
            {
                comboBox1.Items.Add(supplier);
            }
            comboBox1.SelectedIndex = 0;

            purchaseList = DeserializeFromXml<List<Purchase>>(purchaseFilePath);
            SerializeToXml(purchaseList, purchaseFilePath);

            update();

            normalSize = closeB.Size;
            normalLocation = closeB.Location;
            minimizeBNormalSize = minimizeB.Size;
            minimizeBNormalLocation = minimizeB.Location;

            originalPurchaseList = DeserializeFromXml<List<Purchase>>(purchaseFilePath);
            dataGridView1.DataSource = originalPurchaseList;
        }

        static void SerializeToXml<T>(T obj, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }

        static T DeserializeFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        private void update()
        {
            purchaseList = DeserializeFromXml<List<Purchase>>(purchaseFilePath);
            List<Purchase> list = new List<Purchase>();
            dataGridView1.DataSource = list;

            if (periodComboBox.Text != "All" && supplierComboBox.Text != "All")
            {
                list = purchaseList.Where(c => c.Supplier.ToString() == supplierComboBox.Text && c.Date >= DateTime.Now - TimeSpan.FromDays(30 * int.Parse(periodComboBox.Text))).ToList();
            }
            else if (periodComboBox.Text == "All" && supplierComboBox.Text != "All")
            {
                list = purchaseList.Where(c => c.Supplier.ToString() == supplierComboBox.Text).ToList();
            }
            else if (periodComboBox.Text != "All" && supplierComboBox.Text == "All")
            {
                list = purchaseList.Where(c => c.Date >= DateTime.Now - TimeSpan.FromDays(30 * int.Parse(periodComboBox.Text))).ToList();
            }
            else
            {
                list = purchaseList;
            }

            dataGridView1.DataSource = list;

            dataGridView1.Columns["Number"].DataPropertyName = "Number";
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Supplier"].DataPropertyName = "Supplier";
            dataGridView1.Columns["Date"].DataPropertyName = "Date";
            dataGridView1.Columns["Price"].DataPropertyName = "Price";
        }

        private void periodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private bool isDragging = false;
        private Point lastCursorPos;
        private Size normalSize;
        private Point normalLocation;

        private Size minimizeBNormalSize;
        private Point minimizeBNormalLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int delX = e.X - lastCursorPos.X;
                int delY = e.Y - lastCursorPos.Y;

                this.Left += delX;
                this.Top += delY;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeB_MouseEnter(object sender, EventArgs e)
        {
            closeB.Size = new Size(normalSize.Width + 5, normalSize.Height + 5);

            closeB.Location = new Point(
                normalLocation.X - (closeB.Width - normalSize.Width) / 2,
                normalLocation.Y - (closeB.Height - normalSize.Height) / 2
            );
        }

        private void closeB_MouseLeave(object sender, EventArgs e)
        {
            closeB.Size = normalSize;
            closeB.Location = normalLocation;
        }

        private void minimizeB_MouseEnter(object sender, EventArgs e)
        {
            minimizeB.Size = new Size(minimizeBNormalSize.Width + 5, minimizeBNormalSize.Height + 5);

            minimizeB.Location = new Point(
                minimizeBNormalLocation.X - (minimizeB.Width - minimizeBNormalSize.Width) / 2,
                minimizeBNormalLocation.Y - (minimizeB.Height - minimizeBNormalSize.Height) / 2
            );
        }

        private void minimizeB_MouseLeave(object sender, EventArgs e)
        {
            minimizeB.Size = minimizeBNormalSize;
            minimizeB.Location = minimizeBNormalLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAdd.Text))
            {
                if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    Purchase newPurchase = new Purchase(
                        purchaseList.Count + 1,
                        nameTextBox.Text,
                        (Supplier)Enum.Parse(typeof(Supplier), comboBox1.SelectedItem.ToString()),
                        dateTimePicker1.Value,
                        (int)numericUpDown2.Value
                    );

                    purchaseList.Add(newPurchase);
                    SerializeToXml(purchaseList, purchaseFilePath);
                    update();
                }
                else
                {
                    MessageBox.Show("¬ведите название закупки.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (int.TryParse(textBoxAdd.Text, out int addRowIndex))
                {
                    if (addRowIndex >= 1 && addRowIndex <= dataGridView1.RowCount + 1)
                    {
                        if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
                        {
                            Purchase newPurchase = new Purchase(
                                purchaseList.Count + 1,
                                nameTextBox.Text,
                                Supplier.OceanicEnterprises,
                                dateTimePicker1.Value,
                                (int)numericUpDown2.Value
                            );

                            purchaseList.Insert(addRowIndex - 1, newPurchase);

                            for (int i = addRowIndex - 1; i < purchaseList.Count; i++)
                            {
                                purchaseList[i].Number = i + 1;
                            }

                            SerializeToXml(purchaseList, purchaseFilePath);

                            update();
                        }
                        else
                        {
                            MessageBox.Show("¬ведите название закупки.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¬ведите корректный номер строки дл€ добавлени€.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("¬ведите корректный номер строки дл€ добавлени€.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void periodComboBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("ѕериод закупки за последние 1, 2, 3, 4 и 5 мес€цев.", periodComboBox);
        }

        private void periodComboBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(periodComboBox);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDelete.Text, out int deleteRowIndex))
            {
                if (deleteRowIndex >= 1 && deleteRowIndex <= dataGridView1.RowCount)
                {
                    purchaseList.RemoveAt(deleteRowIndex - 1);

                    for (int i = deleteRowIndex - 1; i < purchaseList.Count; i++)
                    {
                        purchaseList[i].Number = i + 1;
                    }

                    SerializeToXml(purchaseList, purchaseFilePath);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = purchaseList;

                    dataGridView1.Columns["Number"].DataPropertyName = "Number";
                    dataGridView1.Columns["Name"].DataPropertyName = "Name";
                    dataGridView1.Columns["Supplier"].DataPropertyName = "Supplier";
                    dataGridView1.Columns["Date"].DataPropertyName = "Date";
                    dataGridView1.Columns["Price"].DataPropertyName = "Price";
                }
                else
                {
                    MessageBox.Show("¬ведите корректный номер строки дл€ удалени€.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¬ведите корректный номер строки дл€ удалени€.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAdd_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("ќставить пустым дл€ добавлени€ новой строки.", textBoxAdd);
        }

        private void textBoxAdd_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(textBoxAdd);
        }

        //–≈јЋ»«ј÷»я ѕќ»— ј 
        private List<Purchase> originalPurchaseList;

        private void SortOriginalListByNumber()
        {
            originalPurchaseList.Sort((x, y) => x.Number.CompareTo(y.Number));
        }

        private void BinarySearchDataGrid()
        {
            string searchText = searchTextBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView1.DataSource = originalPurchaseList;
            }
            else
            {
                List<Purchase> filteredList = BinarySearchByCriteria(searchText);
                dataGridView1.DataSource = filteredList;
            }
        }

        private List<Purchase> BinarySearchByCriteria(string searchText)
        {
            List<Purchase> resultList = new List<Purchase>();

            string binarySearchText = StringToBinary(searchText);

            foreach (var purchase in originalPurchaseList)
            {
                string binaryName = StringToBinary(purchase.Name.ToLower());
                string binarySupplier = StringToBinary(purchase.Supplier.ToString().ToLower());
                string binaryPrice = StringToBinary(purchase.Price.ToString().ToLower());

                if (binaryName.Contains(binarySearchText) ||
                    binarySupplier.Contains(binarySearchText) ||
                    binaryPrice.Contains(binarySearchText))
                {
                    resultList.Add(purchase);
                }
            }

            return resultList;
        }

        private string StringToBinary(string input)
        {
            StringBuilder binaryStringBuilder = new StringBuilder();

            foreach (char c in input)
            {
                binaryStringBuilder.Append(Convert.ToString(c, 2));
            }

            return binaryStringBuilder.ToString();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            BinarySearchDataGrid();
        }

        //метод сортировки "—ортировка в пор€дке возрастани€"
        private void GenerateSummaryReport()
        {
            var summary = purchaseList.GroupBy(p => p.Name)
                                      .Select(g => new { Name = g.Key, TotalPrice = g.Sum(p => p.Price) })
                                      .OrderBy(r => r.TotalPrice)
                                      .ToList<object>();

            DisplaySummaryReport(summary);
        }

        private void DisplaySummaryReport(List<object> summary) 
        {
            dataGridView1.DataSource = summary;
        }

        private bool isSummaryDisplayed = false;
        private void summaryButton_Click(object sender, EventArgs e)
        {
            if (!isSummaryDisplayed) 
            {
                GenerateSummaryReport();
                isSummaryDisplayed = true;
            }
            else
            {
                update();
                isSummaryDisplayed = false;
            }
        }
        //метод сортировки "по убыванию" 
        private void GenerateTopSuppliersReport()
        {
            var topSuppliers = purchaseList.GroupBy(p => p.Supplier)
                                           .Select(g => new SupplierPurchaseCount { Supplier = g.Key, PurchaseCount = g.Count() })
                                           .OrderByDescending(r => r.PurchaseCount)
                                           .Take(5)
                                           .ToList();

            DisplayTopSuppliersReport(topSuppliers);
        }

        private void DisplayTopSuppliersReport(List<SupplierPurchaseCount> topSuppliers)
        {
            dataGridView1.DataSource = topSuppliers;
        }
        private bool isTopSuppliersDisplayed = false;
        private void topSuppliersButton_Click_1(object sender, EventArgs e)
        {
            if (isTopSuppliersDisplayed)
            {
                update(); 
                isTopSuppliersDisplayed = false;
            }
            else
            {
                GenerateTopSuppliersReport();
                isTopSuppliersDisplayed = true;
            }
        }
    }
    public class SupplierPurchaseCount
    {
        public Supplier Supplier { get; set; }
        public int PurchaseCount { get; set; }
    }

    public class Purchase
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }


        public Purchase() { }

        public Purchase(int number, string name, Supplier supplier, DateTime date, int price)
        {
            Number = number;
            Name = name;
            Supplier = supplier;
            Date = date;
            Price = price;
        }
    }

    public enum Supplier
    {
        OceanicEnterprises,
        SummitSolutions,
        StellarImports,
        HorizonTradingCo,
        GlobalMerchantsInc
    }
}