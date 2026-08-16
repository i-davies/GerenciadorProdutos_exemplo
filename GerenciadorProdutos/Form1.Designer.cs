namespace GerenciadorProdutos
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
            txtNome = new TextBox();
            txtPrecoBase = new TextBox();
            cmbTipo = new ComboBox();
            txtAtributoEspecifico = new TextBox();
            lblAtributo = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 31);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome do Produto";
            // 
            // txtPrecoBase
            // 
            txtPrecoBase.Location = new Point(270, 38);
            txtPrecoBase.Name = "txtPrecoBase";
            txtPrecoBase.Size = new Size(203, 31);
            txtPrecoBase.TabIndex = 1;
            txtPrecoBase.Text = "Preço Base";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Físico", "Digital" });
            cmbTipo.Location = new Point(46, 115);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 33);
            cmbTipo.TabIndex = 2;
            cmbTipo.Text = "Tipo";
            cmbTipo.SelectionChangeCommitted += cmbTipo_SelectedIndexChanged;
            // 
            // txtAtributoEspecifico
            // 
            txtAtributoEspecifico.Location = new Point(270, 192);
            txtAtributoEspecifico.Name = "txtAtributoEspecifico";
            txtAtributoEspecifico.Size = new Size(203, 31);
            txtAtributoEspecifico.TabIndex = 3;
            txtAtributoEspecifico.Text = "Peso | Tamanho";
            // 
            // lblAtributo
            // 
            lblAtributo.AutoSize = true;
            lblAtributo.Location = new Point(279, 123);
            lblAtributo.Name = "lblAtributo";
            lblAtributo.Size = new Size(47, 25);
            lblAtributo.TabIndex = 4;
            lblAtributo.Text = "Tipo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(361, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblAtributo);
            Controls.Add(txtAtributoEspecifico);
            Controls.Add(cmbTipo);
            Controls.Add(txtPrecoBase);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPrecoBase;
        private ComboBox cmbTipo;
        private TextBox txtAtributoEspecifico;
        private Label lblAtributo;
        private Button btnSalvar;
    }
}
