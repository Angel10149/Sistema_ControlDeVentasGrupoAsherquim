namespace Presentacion
{
    partial class Login
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
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnIngresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(265, 144);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(268, 24);
            this.TxtClave.TabIndex = 13;
            // 
            // TxtCodigoUsuario
            // 
            this.TxtCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoUsuario.Location = new System.Drawing.Point(265, 80);
            this.TxtCodigoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigoUsuario.Name = "TxtCodigoUsuario";
            this.TxtCodigoUsuario.Size = new System.Drawing.Size(268, 24);
            this.TxtCodigoUsuario.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "INICIAR SESION";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 246);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 77);
            this.label2.TabIndex = 17;
            this.label2.Text = "SISTEMA DE ASHERQUIM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 131;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(166, 131);
            this.iconPictureBox1.TabIndex = 18;
            this.iconPictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 21;
            this.BtnCancelar.Location = new System.Drawing.Point(414, 184);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(119, 34);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Blue;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnIngresar.FlatAppearance.BorderSize = 2;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BtnIngresar.IconColor = System.Drawing.Color.White;
            this.BtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnIngresar.IconSize = 21;
            this.BtnIngresar.Location = new System.Drawing.Point(266, 184);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(120, 34);
            this.BtnIngresar.TabIndex = 19;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(570, 246);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtCodigoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtCodigoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnIngresar;
    }
}