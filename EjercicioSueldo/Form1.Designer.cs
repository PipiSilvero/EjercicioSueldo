namespace EjercicioSueldo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkCasado = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBasico = new TextBox();
            txtAAntig = new TextBox();
            txtCHijos = new TextBox();
            txtIAnt = new TextBox();
            txtIEC = new TextBox();
            txtIHijos = new TextBox();
            txtTotal = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(98, 42);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Básico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(95, 82);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Años de ant.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(98, 159);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad Hijos";
            label3.Click += label3_Click;
            // 
            // chkCasado
            // 
            chkCasado.AutoSize = true;
            chkCasado.BackColor = Color.White;
            chkCasado.Location = new Point(144, 126);
            chkCasado.Name = "chkCasado";
            chkCasado.Size = new Size(98, 19);
            chkCasado.TabIndex = 3;
            chkCasado.Text = "¿Es casado/a?";
            chkCasado.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(98, 267);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Importe Antig.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(98, 297);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Importe E. Civil";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(98, 327);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 6;
            label6.Text = "Importe Hijos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(98, 351);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 7;
            label7.Text = "Sueldo Total";
            // 
            // txtBasico
            // 
            txtBasico.Location = new Point(219, 42);
            txtBasico.Name = "txtBasico";
            txtBasico.Size = new Size(100, 23);
            txtBasico.TabIndex = 8;
            // 
            // txtAAntig
            // 
            txtAAntig.Location = new Point(219, 82);
            txtAAntig.Name = "txtAAntig";
            txtAAntig.Size = new Size(100, 23);
            txtAAntig.TabIndex = 9;
            // 
            // txtCHijos
            // 
            txtCHijos.Location = new Point(219, 159);
            txtCHijos.Name = "txtCHijos";
            txtCHijos.Size = new Size(100, 23);
            txtCHijos.TabIndex = 10;
            // 
            // txtIAnt
            // 
            txtIAnt.Location = new Point(219, 259);
            txtIAnt.Name = "txtIAnt";
            txtIAnt.ReadOnly = true;
            txtIAnt.Size = new Size(100, 23);
            txtIAnt.TabIndex = 11;
            // 
            // txtIEC
            // 
            txtIEC.Location = new Point(219, 297);
            txtIEC.Name = "txtIEC";
            txtIEC.ReadOnly = true;
            txtIEC.Size = new Size(100, 23);
            txtIEC.TabIndex = 12;
            // 
            // txtIHijos
            // 
            txtIHijos.Location = new Point(219, 327);
            txtIHijos.Name = "txtIHijos";
            txtIHijos.ReadOnly = true;
            txtIHijos.Size = new Size(100, 23);
            txtIHijos.TabIndex = 13;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(219, 367);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 14;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Red;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(219, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(219, 405);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(578, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotal);
            Controls.Add(txtIHijos);
            Controls.Add(txtIEC);
            Controls.Add(txtIAnt);
            Controls.Add(txtCHijos);
            Controls.Add(txtAAntig);
            Controls.Add(txtBasico);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chkCasado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cáculo de Sueldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkCasado;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBasico;
        private TextBox txtAAntig;
        private TextBox txtCHijos;
        private TextBox txtIAnt;
        private TextBox txtIEC;
        private TextBox txtIHijos;
        private TextBox txtTotal;
        private Button btnCalcular;
        private Button btnSalir;
    }
}