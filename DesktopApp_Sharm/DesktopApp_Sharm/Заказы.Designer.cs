
namespace DesktopApp_Sharm
{
    partial class Заказы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказы));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bZayav = new System.Windows.Forms.Button();
            this.bSee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // bZayav
            // 
            this.bZayav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bZayav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZayav.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bZayav.Location = new System.Drawing.Point(12, 327);
            this.bZayav.Name = "bZayav";
            this.bZayav.Size = new System.Drawing.Size(100, 23);
            this.bZayav.TabIndex = 5;
            this.bZayav.Text = "Заявка";
            this.bZayav.UseVisualStyleBackColor = false;
            this.bZayav.Click += new System.EventHandler(this.bZayav_Click);
            // 
            // bSee
            // 
            this.bSee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSee.Location = new System.Drawing.Point(672, 327);
            this.bSee.Name = "bSee";
            this.bSee.Size = new System.Drawing.Size(100, 23);
            this.bSee.TabIndex = 6;
            this.bSee.Text = "Посмотреть";
            this.bSee.UseVisualStyleBackColor = false;
            this.bSee.Click += new System.EventHandler(this.bSee_Click);
            // 
            // Заказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.bSee);
            this.Controls.Add(this.bZayav);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Заказы";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Заказы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bZayav;
        private System.Windows.Forms.Button bSee;
    }
}