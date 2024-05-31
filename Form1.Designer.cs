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
            this.comboBoxSymbol = new System.Windows.Forms.ComboBox();
            this.labelBinance = new System.Windows.Forms.Label();
            this.labelBybit = new System.Windows.Forms.Label();
            this.labelKucoin = new System.Windows.Forms.Label();
            this.labelBitget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSymbol
            // 
            this.comboBoxSymbol.FormattingEnabled = true;
            this.comboBoxSymbol.Location = new System.Drawing.Point(27, 46);
            this.comboBoxSymbol.Name = "comboBoxSymbol";
            this.comboBoxSymbol.Size = new System.Drawing.Size(227, 21);
            this.comboBoxSymbol.TabIndex = 0;
            // 
            // labelBinance
            // 
            this.labelBinance.AutoSize = true;
            this.labelBinance.Location = new System.Drawing.Point(24, 119);
            this.labelBinance.Name = "labelBinance";
            this.labelBinance.Size = new System.Drawing.Size(46, 13);
            this.labelBinance.TabIndex = 1;
            this.labelBinance.Text = "Binance";
            // 
            // labelBybit
            // 
            this.labelBybit.AutoSize = true;
            this.labelBybit.Location = new System.Drawing.Point(24, 151);
            this.labelBybit.Name = "labelBybit";
            this.labelBybit.Size = new System.Drawing.Size(30, 13);
            this.labelBybit.TabIndex = 2;
            this.labelBybit.Text = "Bybit";
            // 
            // labelKucoin
            // 
            this.labelKucoin.AutoSize = true;
            this.labelKucoin.Location = new System.Drawing.Point(24, 184);
            this.labelKucoin.Name = "labelKucoin";
            this.labelKucoin.Size = new System.Drawing.Size(40, 13);
            this.labelKucoin.TabIndex = 3;
            this.labelKucoin.Text = "Kucoin";
            // 
            // labelBitget
            // 
            this.labelBitget.AutoSize = true;
            this.labelBitget.Location = new System.Drawing.Point(24, 215);
            this.labelBitget.Name = "labelBitget";
            this.labelBitget.Size = new System.Drawing.Size(36, 13);
            this.labelBitget.TabIndex = 4;
            this.labelBitget.Text = "BitGet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбрать пару";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBitget);
            this.Controls.Add(this.labelKucoin);
            this.Controls.Add(this.labelBybit);
            this.Controls.Add(this.labelBinance);
            this.Controls.Add(this.comboBoxSymbol);
            this.MaximumSize = new System.Drawing.Size(304, 336);
            this.MinimumSize = new System.Drawing.Size(304, 336);
            this.Name = "Form1";
            this.Text = "КриптоАнализатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
             

        private ComboBox comboBoxSymbol;
        private Label labelBinance;
        private Label labelBybit;
        private Label labelKucoin;
        private Label labelBitget;
        private Label label1;
        private Button button1;
    }
}

