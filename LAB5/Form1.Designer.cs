namespace LAB5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRoses;
        private System.Windows.Forms.Label lblTulips;
        private System.Windows.Forms.Label lblDaisies;
        private System.Windows.Forms.NumericUpDown numRoses;
        private System.Windows.Forms.NumericUpDown numTulips;
        private System.Windows.Forms.NumericUpDown numDaisies;
        private System.Windows.Forms.Label lblWrap;
        private System.Windows.Forms.ComboBox cmbWrap;
        private System.Windows.Forms.Label lblRibbon;
        private System.Windows.Forms.ComboBox cmbRibbon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstBouquets;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRoses = new System.Windows.Forms.Label();
            this.lblTulips = new System.Windows.Forms.Label();
            this.lblDaisies = new System.Windows.Forms.Label();
            this.numRoses = new System.Windows.Forms.NumericUpDown();
            this.numTulips = new System.Windows.Forms.NumericUpDown();
            this.numDaisies = new System.Windows.Forms.NumericUpDown();
            this.lblWrap = new System.Windows.Forms.Label();
            this.cmbWrap = new System.Windows.Forms.ComboBox();
            this.lblRibbon = new System.Windows.Forms.Label();
            this.cmbRibbon = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstBouquets = new System.Windows.Forms.ListBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTulips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaisies)).BeginInit();
            this.SuspendLayout();
            
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Назва букета";
            
            this.txtName.Location = new System.Drawing.Point(23, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 1;
             
            this.lblRoses.AutoSize = true;
            this.lblRoses.Location = new System.Drawing.Point(20, 80);
            this.lblRoses.Name = "lblRoses";
            this.lblRoses.Size = new System.Drawing.Size(65, 16);
            this.lblRoses.TabIndex = 2;
            this.lblRoses.Text = "Троянди";
             
            this.lblTulips.AutoSize = true;
            this.lblTulips.Location = new System.Drawing.Point(20, 120);
            this.lblTulips.Name = "lblTulips";
            this.lblTulips.Size = new System.Drawing.Size(69, 16);
            this.lblTulips.TabIndex = 3;
            this.lblTulips.Text = "Тюльпани";
           
            this.lblDaisies.AutoSize = true;
            this.lblDaisies.Location = new System.Drawing.Point(20, 160);
            this.lblDaisies.Name = "lblDaisies";
            this.lblDaisies.Size = new System.Drawing.Size(63, 16);
            this.lblDaisies.TabIndex = 4;
            this.lblDaisies.Text = "Ромашки";
            
            this.numRoses.Location = new System.Drawing.Point(120, 78);
            this.numRoses.Name = "numRoses";
            this.numRoses.Size = new System.Drawing.Size(80, 22);
            this.numRoses.TabIndex = 5;
            
            this.numTulips.Location = new System.Drawing.Point(120, 118);
            this.numTulips.Name = "numTulips";
            this.numTulips.Size = new System.Drawing.Size(80, 22);
            this.numTulips.TabIndex = 6;
            
            this.numDaisies.Location = new System.Drawing.Point(120, 158);
            this.numDaisies.Name = "numDaisies";
            this.numDaisies.Size = new System.Drawing.Size(80, 22);
            this.numDaisies.TabIndex = 7;
            
            this.lblWrap.AutoSize = true;
            this.lblWrap.Location = new System.Drawing.Point(20, 205);
            this.lblWrap.Name = "lblWrap";
            this.lblWrap.Size = new System.Drawing.Size(71, 16);
            this.lblWrap.TabIndex = 8;
            this.lblWrap.Text = "Упаковка";
           
            this.cmbWrap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWrap.FormattingEnabled = true;
            this.cmbWrap.Location = new System.Drawing.Point(23, 225);
            this.cmbWrap.Name = "cmbWrap";
            this.cmbWrap.Size = new System.Drawing.Size(230, 24);
            this.cmbWrap.TabIndex = 9;
            
            this.lblRibbon.AutoSize = true;
            this.lblRibbon.Location = new System.Drawing.Point(20, 265);
            this.lblRibbon.Name = "lblRibbon";
            this.lblRibbon.Size = new System.Drawing.Size(100, 16);
            this.lblRibbon.TabIndex = 10;
            this.lblRibbon.Text = "Колір стрічки";
           
            this.cmbRibbon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRibbon.FormattingEnabled = true;
            this.cmbRibbon.Location = new System.Drawing.Point(23, 285);
            this.cmbRibbon.Name = "cmbRibbon";
            this.cmbRibbon.Size = new System.Drawing.Size(230, 24);
            this.cmbRibbon.TabIndex = 11;
            
            this.btnCreate.Location = new System.Drawing.Point(23, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(230, 35);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Створити букет";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            
            this.btnClone.Location = new System.Drawing.Point(23, 375);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(230, 35);
            this.btnClone.TabIndex = 13;
            this.btnClone.Text = "Клонувати букет";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            
            this.btnDelete.Location = new System.Drawing.Point(23, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Видалити букет";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(290, 20);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(105, 16);
            this.lblList.TabIndex = 15;
            this.lblList.Text = "Список букетів";
             
            this.lstBouquets.FormattingEnabled = true;
            this.lstBouquets.ItemHeight = 16;
            this.lstBouquets.Location = new System.Drawing.Point(293, 40);
            this.lstBouquets.Name = "lstBouquets";
            this.lstBouquets.Size = new System.Drawing.Size(350, 180);
            this.lstBouquets.TabIndex = 16;
            this.lstBouquets.SelectedIndexChanged += new System.EventHandler(this.lstBouquets_SelectedIndexChanged);
            
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(290, 245);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(110, 16);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Деталі букета";
            
            this.txtInfo.Location = new System.Drawing.Point(293, 265);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(350, 190);
            this.txtInfo.TabIndex = 18;
            
            this.ClientSize = new System.Drawing.Size(670, 480);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstBouquets);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbRibbon);
            this.Controls.Add(this.lblRibbon);
            this.Controls.Add(this.cmbWrap);
            this.Controls.Add(this.lblWrap);
            this.Controls.Add(this.numDaisies);
            this.Controls.Add(this.numTulips);
            this.Controls.Add(this.numRoses);
            this.Controls.Add(this.lblDaisies);
            this.Controls.Add(this.lblTulips);
            this.Controls.Add(this.lblRoses);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будівельник і Прототип - Букети квітів";
            ((System.ComponentModel.ISupportInitialize)(this.numRoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTulips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaisies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}