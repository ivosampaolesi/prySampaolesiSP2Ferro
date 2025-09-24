namespace prySampaolesiSP2Ferro
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            txtKilometros = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            lblDistancia = new Label();
            lblDias = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(57, 58);
            txtKilometros.Mask = "00000km";
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(219, 27);
            txtKilometros.TabIndex = 0;
            txtKilometros.ValidatingType = typeof(int);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(57, 129);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(33, 35);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(265, 20);
            lblDistancia.TabIndex = 2;
            lblDistancia.Text = "Distancia hasta la localidad de destino";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(60, 108);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(200, 20);
            lblDias.TabIndex = 3;
            lblDias.Text = "Cantidad de dias de estancia";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 170);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 26);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 208);
            Controls.Add(btnCalcular);
            Controls.Add(lblDias);
            Controls.Add(lblDistancia);
            Controls.Add(numericUpDown1);
            Controls.Add(txtKilometros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Calculadora de precio del boleto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtKilometros;
        private NumericUpDown numericUpDown1;
        private Label lblDistancia;
        private Label lblDias;
        private Button btnCalcular;
    }
}
