namespace EsWindowsFormElenco
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
            txt_input = new TextBox();
            btn_aggiungi = new Button();
            lst_elenco = new ListBox();
            btn_canc = new Button();
            btn_elimina = new Button();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.Location = new Point(310, 121);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(125, 27);
            txt_input.TabIndex = 0;
            txt_input.TextChanged += txt_input_TextChanged;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(220, 170);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(94, 29);
            btn_aggiungi.TabIndex = 1;
            btn_aggiungi.Text = "Aggiungi";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += btn_aggiungi_Click;
            // 
            // lst_elenco
            // 
            lst_elenco.FormattingEnabled = true;
            lst_elenco.Location = new Point(531, 121);
            lst_elenco.Name = "lst_elenco";
            lst_elenco.Size = new Size(179, 184);
            lst_elenco.TabIndex = 2;
            lst_elenco.SelectedIndexChanged += lst_elenco_SelectedIndexChanged;
            // 
            // btn_canc
            // 
            btn_canc.Location = new Point(410, 170);
            btn_canc.Name = "btn_canc";
            btn_canc.Size = new Size(94, 29);
            btn_canc.TabIndex = 3;
            btn_canc.Text = "Rimuovi";
            btn_canc.UseVisualStyleBackColor = true;
            btn_canc.Click += btn_canc_Click;
            // 
            // btn_elimina
            // 
            btn_elimina.Location = new Point(572, 322);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(94, 29);
            btn_elimina.TabIndex = 4;
            btn_elimina.Text = "Cancella tutto";
            btn_elimina.UseVisualStyleBackColor = true;
            btn_elimina.Click += btn_elimina_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_elimina);
            Controls.Add(btn_canc);
            Controls.Add(lst_elenco);
            Controls.Add(btn_aggiungi);
            Controls.Add(txt_input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_input;
        private Button btn_aggiungi;
        private ListBox lst_elenco;
        private Button btn_canc;
        private Button btn_elimina;
    }
}
