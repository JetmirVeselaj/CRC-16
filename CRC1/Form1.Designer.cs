namespace CRC1
{
    partial class Form1
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
            this.txtTeksti = new System.Windows.Forms.TextBox();
            this.txtRezultati = new System.Windows.Forms.TextBox();
            this.btnKliko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVertetimi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVertetimi = new System.Windows.Forms.Button();
            this.txtMesazhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTeksti
            // 
            this.txtTeksti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeksti.Location = new System.Drawing.Point(12, 50);
            this.txtTeksti.Name = "txtTeksti";
            this.txtTeksti.Size = new System.Drawing.Size(247, 29);
            this.txtTeksti.TabIndex = 0;
            // 
            // txtRezultati
            // 
            this.txtRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRezultati.Location = new System.Drawing.Point(12, 131);
            this.txtRezultati.Name = "txtRezultati";
            this.txtRezultati.Size = new System.Drawing.Size(247, 29);
            this.txtRezultati.TabIndex = 1;
            // 
            // btnKliko
            // 
            this.btnKliko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKliko.Location = new System.Drawing.Point(12, 275);
            this.btnKliko.Name = "btnKliko";
            this.btnKliko.Size = new System.Drawing.Size(247, 35);
            this.btnKliko.TabIndex = 2;
            this.btnKliko.Text = "Gjenero CRC-ne";
            this.btnKliko.UseVisualStyleBackColor = true;
            this.btnKliko.Click += new System.EventHandler(this.btnKliko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shkruani mesazhin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesazhi me CRC";
            // 
            // txtCRC
            // 
            this.txtCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRC.Location = new System.Drawing.Point(347, 50);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.Size = new System.Drawing.Size(247, 29);
            this.txtCRC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CRC-gjeneruar";
            // 
            // txtVertetimi
            // 
            this.txtVertetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVertetimi.Location = new System.Drawing.Point(347, 131);
            this.txtVertetimi.Name = "txtVertetimi";
            this.txtVertetimi.Size = new System.Drawing.Size(247, 29);
            this.txtVertetimi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vertetimi";
            // 
            // btnVertetimi
            // 
            this.btnVertetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVertetimi.Location = new System.Drawing.Point(347, 275);
            this.btnVertetimi.Name = "btnVertetimi";
            this.btnVertetimi.Size = new System.Drawing.Size(247, 35);
            this.btnVertetimi.TabIndex = 9;
            this.btnVertetimi.Text = "Verteto";
            this.btnVertetimi.UseVisualStyleBackColor = true;
            this.btnVertetimi.Click += new System.EventHandler(this.btnVertetimi_Click);
            // 
            // txtMesazhi
            // 
            this.txtMesazhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesazhi.Location = new System.Drawing.Point(347, 209);
            this.txtMesazhi.Name = "txtMesazhi";
            this.txtMesazhi.Size = new System.Drawing.Size(247, 29);
            this.txtMesazhi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mesazhi pas transmetimit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMesazhi);
            this.Controls.Add(this.btnVertetimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVertetimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKliko);
            this.Controls.Add(this.txtRezultati);
            this.Controls.Add(this.txtTeksti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeksti;
        private System.Windows.Forms.TextBox txtRezultati;
        private System.Windows.Forms.Button btnKliko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVertetimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVertetimi;
        private System.Windows.Forms.TextBox txtMesazhi;
        private System.Windows.Forms.Label label5;
    }
}

