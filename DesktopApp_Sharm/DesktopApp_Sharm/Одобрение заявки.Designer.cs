
namespace DesktopApp_Sharm
{
    partial class Одобрение_заявки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Одобрение_заявки));
            this.lNamePeaple = new System.Windows.Forms.Label();
            this.cbPeaple = new System.Windows.Forms.ComboBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNamePeaple
            // 
            this.lNamePeaple.AutoSize = true;
            this.lNamePeaple.Location = new System.Drawing.Point(36, 29);
            this.lNamePeaple.Name = "lNamePeaple";
            this.lNamePeaple.Size = new System.Drawing.Size(118, 13);
            this.lNamePeaple.TabIndex = 0;
            this.lNamePeaple.Text = "Выберите сотрудника";
            // 
            // cbPeaple
            // 
            this.cbPeaple.FormattingEnabled = true;
            this.cbPeaple.Items.AddRange(new object[] {
            "Алюлин Данила Сергеевич",
            "Писарев Артём Дмитриевич"});
            this.cbPeaple.Location = new System.Drawing.Point(24, 45);
            this.cbPeaple.Name = "cbPeaple";
            this.cbPeaple.Size = new System.Drawing.Size(140, 21);
            this.cbPeaple.TabIndex = 1;
            // 
            // bOk
            // 
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOk.Location = new System.Drawing.Point(41, 89);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 23);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = false;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(41, 118);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(100, 23);
            this.bBack.TabIndex = 8;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // Одобрение_заявки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbPeaple);
            this.Controls.Add(this.lNamePeaple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Одобрение_заявки";
            this.Text = "Одобрение_заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNamePeaple;
        private System.Windows.Forms.ComboBox cbPeaple;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bBack;
    }
}