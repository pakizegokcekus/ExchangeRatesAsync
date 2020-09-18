namespace ExchangeRatesAsync
{
    partial class FrmExchangeRate
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ForexBuying = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ForexSelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BankNoteBuying = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BankNoteSelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Code,
            this.ForexBuying,
            this.ForexSelling,
            this.BankNoteBuying,
            this.BankNoteSelling});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 86);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Adı:";
            this.Name.Width = 100;
            // 
            // Code
            // 
            this.Code.Text = "Kod:";
            this.Code.Width = 100;
            // 
            // ForexBuying
            // 
            this.ForexBuying.Text = "Döviz Alış";
            this.ForexBuying.Width = 100;
            // 
            // ForexSelling
            // 
            this.ForexSelling.Text = "Döviz Satış";
            this.ForexSelling.Width = 100;
            // 
            // BankNoteBuying
            // 
            this.BankNoteBuying.Text = "Efektif Alış";
            this.BankNoteBuying.Width = 100;
            // 
            // BankNoteSelling
            // 
            this.BankNoteSelling.Text = "Efektif Satış";
            this.BankNoteSelling.Width = 100;
            // 
            // tmr_Refresh
            // 
            this.tmr_Refresh.Tick += new System.EventHandler(this.tmr_Refresh_Tick);
            // 
            // FrmExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 99);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          
            this.Load += new System.EventHandler(this.FrmExchangeRate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader ForexBuying;
        private System.Windows.Forms.ColumnHeader ForexSelling;
        private System.Windows.Forms.ColumnHeader BankNoteBuying;
        private System.Windows.Forms.ColumnHeader BankNoteSelling;
        private System.Windows.Forms.Timer tmr_Refresh;
    }
}

