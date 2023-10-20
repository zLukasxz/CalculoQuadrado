namespace CalculoQuadrado.View
{
    partial class FormularioQuadrado
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
            label1 = new Label();
            label2 = new Label();
            tbx_Valor = new TextBox();
            lbl_Resultado = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Font = new Font("Louis George Cafe", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(651, 54);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Cálculo Quadrado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 1;
            label2.Text = "Digite o Valor:";
            // 
            // tbx_Valor
            // 
            tbx_Valor.Location = new Point(164, 69);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(425, 23);
            tbx_Valor.TabIndex = 2;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = SystemColors.Control;
            lbl_Resultado.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(57, 111);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(521, 282);
            lbl_Resultado.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(256, 405);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(140, 33);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormularioQuadrado
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(648, 450);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Resultado);
            Controls.Add(tbx_Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormularioQuadrado";
            ShowIcon = false;
            Text = "Sistema de Cálculo Quadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_Valor;
        private Label lbl_Resultado;
        private Button btn_Calcular;
    }
}