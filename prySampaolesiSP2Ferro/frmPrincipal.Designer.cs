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
            txtDias = new NumericUpDown();
            lblDistancia = new Label();
            lblDias = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)txtDias).BeginInit();
            SuspendLayout();
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(57, 58);
            txtKilometros.Mask = "000000000";
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(219, 27);
            txtKilometros.TabIndex = 0;
            txtKilometros.ValidatingType = typeof(int);
            // 
            // txtDias
            // 
            txtDias.Location = new Point(57, 129);
            txtDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            txtDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(219, 27);
            txtDias.TabIndex = 1;
            txtDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(12, 35);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(297, 20);
            lblDistancia.TabIndex = 2;
            lblDistancia.Text = "Distancia hasta la localidad de destino(Km)";
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
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 208);
            Controls.Add(btnCalcular);
            Controls.Add(lblDias);
            Controls.Add(lblDistancia);
            Controls.Add(txtDias);
            Controls.Add(txtKilometros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de precio del boleto";
            ((System.ComponentModel.ISupportInitialize)txtDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtKilometros;
        private NumericUpDown txtDias;
        private Label lblDistancia;
        private Label lblDias;
        private Button btnCalcular;
    }
}
