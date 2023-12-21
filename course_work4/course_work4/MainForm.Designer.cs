namespace course_work4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dgv_dataBase = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Editing_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dataBase
            // 
            this.dgv_dataBase.AllowUserToAddRows = false;
            this.dgv_dataBase.AutoGenerateColumns = false;
            this.dgv_dataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataBase.DataSource = this.productBindingSource1;
            this.dgv_dataBase.Location = new System.Drawing.Point(43, 80);
            this.dgv_dataBase.Name = "dgv_dataBase";
            this.dgv_dataBase.Size = new System.Drawing.Size(743, 258);
            this.dgv_dataBase.TabIndex = 0;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(course_work4.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(course_work4.Supplier);
            // 
            // Editing_button
            // 
            this.Editing_button.Location = new System.Drawing.Point(700, 382);
            this.Editing_button.Name = "Editing_button";
            this.Editing_button.Size = new System.Drawing.Size(75, 23);
            this.Editing_button.TabIndex = 1;
            this.Editing_button.Text = "Изменить";
            this.Editing_button.UseVisualStyleBackColor = true;
            this.Editing_button.Click += new System.EventHandler(this.Editing_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(814, 382);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(587, 382);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 3;
            this.Remove_button.Text = "Удалить";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(course_work4.Product);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 477);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Editing_button);
            this.Controls.Add(this.dgv_dataBase);
            this.Name = "MainForm";
            this.Text = "Главнная форма";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataBase;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private System.Windows.Forms.Button Editing_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}

