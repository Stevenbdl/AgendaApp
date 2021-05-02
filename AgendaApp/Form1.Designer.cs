
namespace AgendaApp
{
    partial class Window
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDer = new System.Windows.Forms.Panel();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.InputNumero = new System.Windows.Forms.TextBox();
            this.LabelNumero = new System.Windows.Forms.Label();
            this.InputNombre = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.TituloPanelDer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablaContactos = new System.Windows.Forms.DataGridView();
            this.TituloPanelIzq = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.PanelDer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDer
            // 
            this.PanelDer.Controls.Add(this.GuardarBtn);
            this.PanelDer.Controls.Add(this.InputNumero);
            this.PanelDer.Controls.Add(this.LabelNumero);
            this.PanelDer.Controls.Add(this.InputNombre);
            this.PanelDer.Controls.Add(this.NombreLabel);
            this.PanelDer.Controls.Add(this.TituloPanelDer);
            this.PanelDer.Location = new System.Drawing.Point(838, 12);
            this.PanelDer.Name = "PanelDer";
            this.PanelDer.Size = new System.Drawing.Size(408, 523);
            this.PanelDer.TabIndex = 0;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(28)))));
            this.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarBtn.FlatAppearance.BorderSize = 0;
            this.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBtn.ForeColor = System.Drawing.Color.White;
            this.GuardarBtn.Location = new System.Drawing.Point(69, 380);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(289, 62);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = false;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // InputNumero
            // 
            this.InputNumero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputNumero.Location = new System.Drawing.Point(69, 285);
            this.InputNumero.Name = "InputNumero";
            this.InputNumero.Size = new System.Drawing.Size(289, 45);
            this.InputNumero.TabIndex = 4;
            // 
            // LabelNumero
            // 
            this.LabelNumero.AutoSize = true;
            this.LabelNumero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNumero.Location = new System.Drawing.Point(129, 238);
            this.LabelNumero.Name = "LabelNumero";
            this.LabelNumero.Size = new System.Drawing.Size(177, 28);
            this.LabelNumero.TabIndex = 3;
            this.LabelNumero.Text = "Numero Telefonico";
            // 
            // InputNombre
            // 
            this.InputNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputNombre.Location = new System.Drawing.Point(69, 171);
            this.InputNombre.Name = "InputNombre";
            this.InputNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.InputNombre.Size = new System.Drawing.Size(289, 45);
            this.InputNombre.TabIndex = 2;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreLabel.Location = new System.Drawing.Point(168, 128);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(85, 28);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // TituloPanelDer
            // 
            this.TituloPanelDer.AutoSize = true;
            this.TituloPanelDer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TituloPanelDer.Location = new System.Drawing.Point(98, 17);
            this.TituloPanelDer.Name = "TituloPanelDer";
            this.TituloPanelDer.Size = new System.Drawing.Size(245, 38);
            this.TituloPanelDer.TabIndex = 0;
            this.TituloPanelDer.Text = "Agregar contacto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TablaContactos);
            this.panel1.Controls.Add(this.TituloPanelIzq);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 455);
            this.panel1.TabIndex = 1;
            // 
            // TablaContactos
            // 
            this.TablaContactos.AllowUserToAddRows = false;
            this.TablaContactos.AllowUserToDeleteRows = false;
            this.TablaContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TablaContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaContactos.Location = new System.Drawing.Point(10, 75);
            this.TablaContactos.Name = "TablaContactos";
            this.TablaContactos.ReadOnly = true;
            this.TablaContactos.RowHeadersWidth = 62;
            this.TablaContactos.RowTemplate.Height = 33;
            this.TablaContactos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaContactos.Size = new System.Drawing.Size(800, 367);
            this.TablaContactos.TabIndex = 7;
            // 
            // TituloPanelIzq
            // 
            this.TituloPanelIzq.AutoSize = true;
            this.TituloPanelIzq.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TituloPanelIzq.Location = new System.Drawing.Point(282, 17);
            this.TituloPanelIzq.Name = "TituloPanelIzq";
            this.TituloPanelIzq.Size = new System.Drawing.Size(251, 38);
            this.TituloPanelIzq.TabIndex = 6;
            this.TituloPanelIzq.Text = "Lista de contactos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BorrarBtn);
            this.panel2.Controls.Add(this.EditarBtn);
            this.panel2.Location = new System.Drawing.Point(12, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 62);
            this.panel2.TabIndex = 2;
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BorrarBtn.FlatAppearance.BorderSize = 0;
            this.BorrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BorrarBtn.ForeColor = System.Drawing.Color.White;
            this.BorrarBtn.Location = new System.Drawing.Point(215, 0);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(173, 62);
            this.BorrarBtn.TabIndex = 1;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = false;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // EditarBtn
            // 
            this.EditarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.EditarBtn.FlatAppearance.BorderSize = 0;
            this.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditarBtn.ForeColor = System.Drawing.Color.White;
            this.EditarBtn.Location = new System.Drawing.Point(10, 0);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(173, 62);
            this.EditarBtn.TabIndex = 0;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = false;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1258, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelDer);
            this.Name = "Window";
            this.Text = "Agenda App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelDer.ResumeLayout(false);
            this.PanelDer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel PanelDer;
        private System.Windows.Forms.TextBox InputNombre;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label TituloPanelDer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox InputNumero;
        private System.Windows.Forms.Label LabelNumero;
        private System.Windows.Forms.Label TituloPanelIzq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.DataGridView TablaContactos;
    }
}

#endregion