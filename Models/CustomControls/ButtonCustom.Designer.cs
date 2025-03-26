namespace RestauranteUnicode.Models.CustomControls
{
    partial class ButtonCustom
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            BorderRadius = 20;
            // 
            // ButtonCustom
            // 
            //AutoScaleDimensions = new SizeF(7F, 15F);
            //AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato; 
            Controls.Add(button1);
            ForeColor = Color.DimGray;
            Name = "ButtonCustom";
            Size = new Size(250, 30);
            BorderRadius = 20;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
