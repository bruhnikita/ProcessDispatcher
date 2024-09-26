namespace ProcessDispatcher
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            usedRAM = new DataGridViewTextBoxColumn();
            startTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(523, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Получить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GetProcessButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(604, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RefreshProcessListButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(685, 11);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 2;
            button3.Text = "Убить процесс";
            button3.UseVisualStyleBackColor = true;
            button3.Click += KillProcessButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { number, name, id, usedRAM, startTime });
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 398);
            dataGridView1.TabIndex = 3;
            // 
            // number
            // 
            number.HeaderText = "Номер";
            number.Name = "number";
            number.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Имя процесса";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "ID процесса";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // usedRAM
            // 
            usedRAM.HeaderText = "ОЗУ";
            usedRAM.Name = "usedRAM";
            usedRAM.ReadOnly = true;
            // 
            // startTime
            // 
            startTime.HeaderText = "Время запуска";
            startTime.Name = "startTime";
            startTime.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Диспетчер";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usedRAM;
        private DataGridViewTextBoxColumn startTime;
    }
}
