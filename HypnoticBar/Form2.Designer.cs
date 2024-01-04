
namespace HypnoticBar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbcena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnobrisi = new System.Windows.Forms.Button();
            this.btndodaj = new System.Windows.Forms.Button();
            this.lbArtikli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbcena
            // 
            this.tbcena.BackColor = System.Drawing.Color.Gainsboro;
            this.tbcena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcena.Location = new System.Drawing.Point(277, 112);
            this.tbcena.Margin = new System.Windows.Forms.Padding(2);
            this.tbcena.Name = "tbcena";
            this.tbcena.Size = new System.Drawing.Size(128, 25);
            this.tbcena.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(271, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 67;
            this.label3.Text = "Cena";
            // 
            // tbnaziv
            // 
            this.tbnaziv.BackColor = System.Drawing.Color.Gainsboro;
            this.tbnaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnaziv.Location = new System.Drawing.Point(277, 46);
            this.tbnaziv.Margin = new System.Windows.Forms.Padding(2);
            this.tbnaziv.Name = "tbnaziv";
            this.tbnaziv.Size = new System.Drawing.Size(128, 25);
            this.tbnaziv.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(271, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Naziv";
            // 
            // Btnobrisi
            // 
            this.Btnobrisi.BackColor = System.Drawing.Color.DimGray;
            this.Btnobrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnobrisi.FlatAppearance.BorderSize = 0;
            this.Btnobrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnobrisi.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnobrisi.ForeColor = System.Drawing.Color.White;
            this.Btnobrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnobrisi.Location = new System.Drawing.Point(277, 282);
            this.Btnobrisi.Margin = new System.Windows.Forms.Padding(2);
            this.Btnobrisi.Name = "Btnobrisi";
            this.Btnobrisi.Size = new System.Drawing.Size(128, 33);
            this.Btnobrisi.TabIndex = 64;
            this.Btnobrisi.Text = "Obrisi";
            this.Btnobrisi.UseVisualStyleBackColor = false;
            this.Btnobrisi.Click += new System.EventHandler(this.Btnobrisi_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.BackColor = System.Drawing.Color.DimGray;
            this.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndodaj.FlatAppearance.BorderSize = 0;
            this.btndodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndodaj.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndodaj.ForeColor = System.Drawing.Color.White;
            this.btndodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndodaj.Location = new System.Drawing.Point(277, 229);
            this.btndodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(128, 33);
            this.btndodaj.TabIndex = 63;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = false;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // lbArtikli
            // 
            this.lbArtikli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbArtikli.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtikli.FormattingEnabled = true;
            this.lbArtikli.ItemHeight = 21;
            this.lbArtikli.Location = new System.Drawing.Point(21, 21);
            this.lbArtikli.Name = "lbArtikli";
            this.lbArtikli.Size = new System.Drawing.Size(236, 294);
            this.lbArtikli.TabIndex = 62;
            this.lbArtikli.SelectedIndexChanged += new System.EventHandler(this.lbArtikli_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.tbcena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btnobrisi);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.lbArtikli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz atikala";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnobrisi;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.ListBox lbArtikli;
    }
}