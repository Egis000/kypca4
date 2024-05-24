namespace kypca4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            closeB = new PictureBox();
            minimizeB = new PictureBox();
            dataGridView1 = new DataGridView();
            periodComboBox = new ComboBox();
            supplierComboBox = new ComboBox();
            button1 = new Button();
            numericUpDown2 = new NumericUpDown();
            nameTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            textBoxDelete = new TextBox();
            buttonDelete = new Button();
            label4 = new Label();
            textBoxAdd = new TextBox();
            label6 = new Label();
            searchTextBox = new TextBox();
            label7 = new Label();
            summaryButton = new Button();
            topSuppliersButton = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)closeB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // closeB
            // 
            closeB.Image = (Image)resources.GetObject("closeB.Image");
            closeB.Location = new Point(761, 12);
            closeB.Name = "closeB";
            closeB.Size = new Size(27, 27);
            closeB.SizeMode = PictureBoxSizeMode.Zoom;
            closeB.TabIndex = 0;
            closeB.TabStop = false;
            closeB.Click += closeB_Click;
            closeB.MouseEnter += closeB_MouseEnter;
            closeB.MouseLeave += closeB_MouseLeave;
            // 
            // minimizeB
            // 
            minimizeB.Image = (Image)resources.GetObject("minimizeB.Image");
            minimizeB.Location = new Point(728, 12);
            minimizeB.Name = "minimizeB";
            minimizeB.Size = new Size(27, 27);
            minimizeB.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeB.TabIndex = 1;
            minimizeB.TabStop = false;
            minimizeB.Click += minimizeB_Click;
            minimizeB.MouseEnter += minimizeB_MouseEnter;
            minimizeB.MouseLeave += minimizeB_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(586, 308);
            dataGridView1.TabIndex = 2;
            // 
            // periodComboBox
            // 
            periodComboBox.FormattingEnabled = true;
            periodComboBox.Location = new Point(622, 87);
            periodComboBox.Name = "periodComboBox";
            periodComboBox.Size = new Size(121, 23);
            periodComboBox.TabIndex = 3;
            periodComboBox.SelectedIndexChanged += periodComboBox_SelectedIndexChanged;
            periodComboBox.MouseEnter += periodComboBox_MouseEnter;
            periodComboBox.MouseLeave += periodComboBox_MouseLeave;
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(622, 116);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(121, 23);
            supplierComboBox.TabIndex = 4;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(758, 382);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(218, 383);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(344, 383);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(120, 23);
            nameTextBox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 383);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(645, 56);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 10;
            label1.Text = "Filters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 355);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 11;
            label2.Text = "Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(218, 355);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 12;
            label3.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(344, 356);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 14;
            label5.Text = "Name";
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(622, 309);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(121, 23);
            textBoxDelete.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(758, 308);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(23, 23);
            buttonDelete.TabIndex = 16;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(622, 280);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 17;
            label4.Text = "Line remove";
            // 
            // textBoxAdd
            // 
            textBoxAdd.Location = new Point(470, 383);
            textBoxAdd.Name = "textBoxAdd";
            textBoxAdd.Size = new Size(146, 23);
            textBoxAdd.TabIndex = 18;
            textBoxAdd.MouseEnter += textBoxAdd_MouseEnter;
            textBoxAdd.MouseLeave += textBoxAdd_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(470, 355);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 19;
            label6.Text = "Line Number";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(89, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(260, 23);
            searchTextBox.TabIndex = 20;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 21;
            label7.Text = "Search";
            // 
            // summaryButton
            // 
            summaryButton.BackgroundImage = (Image)resources.GetObject("summaryButton.BackgroundImage");
            summaryButton.BackgroundImageLayout = ImageLayout.Zoom;
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Location = new Point(758, 172);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(25, 25);
            summaryButton.TabIndex = 22;
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += summaryButton_Click;
            // 
            // topSuppliersButton
            // 
            topSuppliersButton.BackgroundImage = (Image)resources.GetObject("topSuppliersButton.BackgroundImage");
            topSuppliersButton.BackgroundImageLayout = ImageLayout.Zoom;
            topSuppliersButton.FlatStyle = FlatStyle.Flat;
            topSuppliersButton.Location = new Point(758, 226);
            topSuppliersButton.Name = "topSuppliersButton";
            topSuppliersButton.Size = new Size(25, 25);
            topSuppliersButton.TabIndex = 23;
            topSuppliersButton.UseVisualStyleBackColor = true;
            topSuppliersButton.Click += topSuppliersButton_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(622, 383);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(622, 355);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 25;
            label8.Text = "Supplier";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(745, 356);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 26;
            label9.Text = "Add";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(750, 281);
            label10.Name = "label10";
            label10.Size = new Size(41, 25);
            label10.TabIndex = 27;
            label10.Text = "Del";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(619, 223);
            label11.Name = "label11";
            label11.Size = new Size(133, 25);
            label11.TabIndex = 28;
            label11.Text = "Top Suppliers";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(622, 169);
            label12.Name = "label12";
            label12.Size = new Size(98, 25);
            label12.TabIndex = 29;
            label12.Text = "Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 433);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(topSuppliersButton);
            Controls.Add(summaryButton);
            Controls.Add(label7);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(textBoxAdd);
            Controls.Add(label4);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxDelete);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(nameTextBox);
            Controls.Add(numericUpDown2);
            Controls.Add(button1);
            Controls.Add(supplierComboBox);
            Controls.Add(periodComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(minimizeB);
            Controls.Add(closeB);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "main";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)closeB).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeB;
        private PictureBox minimizeB;
        private DataGridView dataGridView1;
        private ComboBox periodComboBox;
        private ComboBox supplierComboBox;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private TextBox nameTextBox;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ToolTip toolTip1;
        private TextBox textBoxDelete;
        private Button buttonDelete;
        private Label label4;
        private TextBox textBoxAdd;
        private Label label6;
        private TextBox searchTextBox;
        private Label label7;
        private Button summaryButton;
        private Button topSuppliersButton;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
