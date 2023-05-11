namespace lab_01
{
    partial class telaPrincipal
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
            this.lb_título = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_curso = new System.Windows.Forms.Label();
            this.lb_mensagem = new System.Windows.Forms.Label();
            this.tBox_nome = new System.Windows.Forms.TextBox();
            this.cBox_curso = new System.Windows.Forms.ComboBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_título
            // 
            this.lb_título.AutoSize = true;
            this.lb_título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_título.Location = new System.Drawing.Point(117, 26);
            this.lb_título.Name = "lb_título";
            this.lb_título.Size = new System.Drawing.Size(187, 25);
            this.lb_título.TabIndex = 0;
            this.lb_título.Text = "laboratório teste 01";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.Location = new System.Drawing.Point(44, 89);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(58, 21);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "nome:";
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_curso.Location = new System.Drawing.Point(44, 139);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(55, 21);
            this.lb_curso.TabIndex = 2;
            this.lb_curso.Text = "curso:";
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_mensagem.Location = new System.Drawing.Point(45, 269);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(468, 84);
            this.lb_mensagem.TabIndex = 3;
            this.lb_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_nome
            // 
            this.tBox_nome.Location = new System.Drawing.Point(117, 89);
            this.tBox_nome.Name = "tBox_nome";
            this.tBox_nome.Size = new System.Drawing.Size(253, 23);
            this.tBox_nome.TabIndex = 4;
            // 
            // cBox_curso
            // 
            this.cBox_curso.FormattingEnabled = true;
            this.cBox_curso.Items.AddRange(new object[] {
            "C#",
            "lógica de programação",
            "PHP",
            "javaScript",
            "java",
            "C++",
            "C",
            "Python",
            "GO"});
            this.cBox_curso.Location = new System.Drawing.Point(117, 137);
            this.cBox_curso.Name = "cBox_curso";
            this.cBox_curso.Size = new System.Drawing.Size(155, 23);
            this.cBox_curso.TabIndex = 5;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exibir.Location = new System.Drawing.Point(78, 215);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(435, 23);
            this.btn_exibir.TabIndex = 6;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(547, 377);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.cBox_curso);
            this.Controls.Add(this.tBox_nome);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_título);
            this.MaximizeBox = false;
            this.Name = "telaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laboratorio 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_título;
        private Label lb_nome;
        private Label lb_curso;
        private Label lb_mensagem;
        private TextBox tBox_nome;
        private ComboBox cBox_curso;
        private Button btn_exibir;
    }
}