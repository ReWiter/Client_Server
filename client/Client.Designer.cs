namespace client
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Show.Location = new System.Drawing.Point(874, 59);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 32);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear.Location = new System.Drawing.Point(731, 59);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 32);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.Location = new System.Drawing.Point(598, 59);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 32);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 547);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
    }
}

