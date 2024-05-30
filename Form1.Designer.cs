using System.Windows.Forms;

namespace CryptoApp_TestTask
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(428, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(400, 224);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(13, 274);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(400, 224);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(428, 274);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(400, 224);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 510);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;

        private void InitializeListViews()
        {
            // Установка столбцов для ListView1
            listView1.View = View.Details;
            listView1.Columns.Add("Attribute", 100);
            listView1.Columns.Add("Value", 300);

            // Установка столбцов для ListView2
            listView2.View = View.Details;
            listView2.Columns.Add("Attribute", 100);
            listView2.Columns.Add("Value", 300);

            // Установка столбцов для ListView3
            listView3.View = View.Details;
            listView3.Columns.Add("Attribute", 100);
            listView3.Columns.Add("Value", 300);

            // Установка столбцов для ListView4
            listView4.View = View.Details;
            listView4.Columns.Add("Attribute", 100);
            listView4.Columns.Add("Value", 300);
        }
    }
}

