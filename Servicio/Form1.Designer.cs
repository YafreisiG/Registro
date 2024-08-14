namespace Servicio
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Celular = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Idlabel = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(99, 75);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(128, 20);
            this.textNombre.TabIndex = 0;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(25, 82);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 1;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(25, 119);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(32, 13);
            this.Edad.TabIndex = 2;
            this.Edad.Text = "Edad";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(25, 128);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 3;
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(25, 154);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 4;
            this.Celular.Text = "Celular";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(99, 112);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(128, 20);
            this.textEdad.TabIndex = 5;
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(99, 147);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(128, 20);
            this.textCelular.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 229);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(28, 202);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(123, 202);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(25, 45);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(18, 13);
            this.Idlabel.TabIndex = 10;
            this.Idlabel.Text = "ID";
            this.Idlabel.Click += new System.EventHandler(this.Textid_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(99, 38);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(69, 20);
            this.textid.TabIndex = 11;
            this.textid.TextChanged += new System.EventHandler(this.textid_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 259);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.textNombre);
            this.Name = "Form1";
            this.Text = "Registrar Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox textid;
    }
}

