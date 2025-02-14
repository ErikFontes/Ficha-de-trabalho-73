namespace ficha_73
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
            textBoxNa = new TextBox();
            textBoxNb = new TextBox();
            textBoxResultado = new TextBox();
            buttonResultado = new Button();
            SuspendLayout();
            // 
            // textBoxNa
            // 
            textBoxNa.Location = new Point(261, 133);
            textBoxNa.Name = "textBoxNa";
            textBoxNa.Size = new Size(100, 23);
            textBoxNa.TabIndex = 0;
            // 
            // textBoxNb
            // 
            textBoxNb.Location = new Point(261, 162);
            textBoxNb.Name = "textBoxNb";
            textBoxNb.Size = new Size(100, 23);
            textBoxNb.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(261, 191);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 2;
            // 
            // buttonResultado
            // 
            buttonResultado.Location = new Point(436, 162);
            buttonResultado.Name = "buttonResultado";
            buttonResultado.Size = new Size(75, 23);
            buttonResultado.TabIndex = 3;
            buttonResultado.Text = "Resultado";
            buttonResultado.UseVisualStyleBackColor = true;
            buttonResultado.Click += buttonResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResultado);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxNb);
            Controls.Add(textBoxNa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNa;
        private TextBox textBoxNb;
        private TextBox textBoxResultado;
        private Button buttonResultado;
    }
}
