namespace AlgoritmosGrafos
{
    partial class Grafos
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
            this.label1 = new System.Windows.Forms.Label();
            this.pn_PainelVertices = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.num_updonw = new System.Windows.Forms.NumericUpDown();
            this.pn_GrafoDigrafo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_0 = new System.Windows.Forms.RadioButton();
            this.lb_InformaVAlor = new System.Windows.Forms.Label();
            this.rtxb_Matriz = new System.Windows.Forms.RichTextBox();
            this.rd_wharshal = new System.Windows.Forms.RadioButton();
            this.rd_alcancabilidade = new System.Windows.Forms.RadioButton();
            this.pn_PainelVertices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_updonw)).BeginInit();
            this.pn_GrafoDigrafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de vértices:";
            // 
            // pn_PainelVertices
            // 
            this.pn_PainelVertices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_PainelVertices.Controls.Add(this.btn_ok);
            this.pn_PainelVertices.Controls.Add(this.num_updonw);
            this.pn_PainelVertices.Controls.Add(this.label1);
            this.pn_PainelVertices.Location = new System.Drawing.Point(84, 9);
            this.pn_PainelVertices.Name = "pn_PainelVertices";
            this.pn_PainelVertices.Size = new System.Drawing.Size(333, 42);
            this.pn_PainelVertices.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(201, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(52, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // num_updonw
            // 
            this.num_updonw.Location = new System.Drawing.Point(140, 8);
            this.num_updonw.Name = "num_updonw";
            this.num_updonw.Size = new System.Drawing.Size(52, 23);
            this.num_updonw.TabIndex = 1;
            // 
            // pn_GrafoDigrafo
            // 
            this.pn_GrafoDigrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_GrafoDigrafo.Controls.Add(this.button1);
            this.pn_GrafoDigrafo.Controls.Add(this.radio_1);
            this.pn_GrafoDigrafo.Controls.Add(this.radio_0);
            this.pn_GrafoDigrafo.Controls.Add(this.lb_InformaVAlor);
            this.pn_GrafoDigrafo.Location = new System.Drawing.Point(84, 57);
            this.pn_GrafoDigrafo.Name = "pn_GrafoDigrafo";
            this.pn_GrafoDigrafo.Size = new System.Drawing.Size(333, 48);
            this.pn_GrafoDigrafo.TabIndex = 2;
            this.pn_GrafoDigrafo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Location = new System.Drawing.Point(225, 22);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(32, 19);
            this.radio_1.TabIndex = 2;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "1";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_0
            // 
            this.radio_0.AutoSize = true;
            this.radio_0.Location = new System.Drawing.Point(225, 3);
            this.radio_0.Name = "radio_0";
            this.radio_0.Size = new System.Drawing.Size(32, 19);
            this.radio_0.TabIndex = 1;
            this.radio_0.TabStop = true;
            this.radio_0.Text = "0";
            this.radio_0.UseVisualStyleBackColor = true;
            // 
            // lb_InformaVAlor
            // 
            this.lb_InformaVAlor.AutoSize = true;
            this.lb_InformaVAlor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformaVAlor.Location = new System.Drawing.Point(14, 15);
            this.lb_InformaVAlor.Name = "lb_InformaVAlor";
            this.lb_InformaVAlor.Size = new System.Drawing.Size(208, 15);
            this.lb_InformaVAlor.TabIndex = 0;
            this.lb_InformaVAlor.Text = "Informe o valor do posição A[00,00]: ";
            // 
            // rtxb_Matriz
            // 
            this.rtxb_Matriz.Location = new System.Drawing.Point(12, 152);
            this.rtxb_Matriz.Name = "rtxb_Matriz";
            this.rtxb_Matriz.ReadOnly = true;
            this.rtxb_Matriz.Size = new System.Drawing.Size(463, 286);
            this.rtxb_Matriz.TabIndex = 3;
            this.rtxb_Matriz.Text = "";
            this.rtxb_Matriz.Visible = false;
            // 
            // rd_wharshal
            // 
            this.rd_wharshal.AutoSize = true;
            this.rd_wharshal.Location = new System.Drawing.Point(84, 117);
            this.rd_wharshal.Name = "rd_wharshal";
            this.rd_wharshal.Size = new System.Drawing.Size(80, 19);
            this.rd_wharshal.TabIndex = 4;
            this.rd_wharshal.TabStop = true;
            this.rd_wharshal.Text = "Wharshal";
            this.rd_wharshal.UseVisualStyleBackColor = true;
            this.rd_wharshal.Visible = false;
            this.rd_wharshal.CheckedChanged += new System.EventHandler(this.rd_wharshal_CheckedChanged);
            // 
            // rd_alcancabilidade
            // 
            this.rd_alcancabilidade.AutoSize = true;
            this.rd_alcancabilidade.Location = new System.Drawing.Point(170, 117);
            this.rd_alcancabilidade.Name = "rd_alcancabilidade";
            this.rd_alcancabilidade.Size = new System.Drawing.Size(115, 19);
            this.rd_alcancabilidade.TabIndex = 5;
            this.rd_alcancabilidade.TabStop = true;
            this.rd_alcancabilidade.Text = "Alcancabilidade";
            this.rd_alcancabilidade.UseVisualStyleBackColor = true;
            this.rd_alcancabilidade.Visible = false;
            this.rd_alcancabilidade.CheckedChanged += new System.EventHandler(this.rd_alcancabilidade_CheckedChanged);
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.rd_alcancabilidade);
            this.Controls.Add(this.rd_wharshal);
            this.Controls.Add(this.rtxb_Matriz);
            this.Controls.Add(this.pn_GrafoDigrafo);
            this.Controls.Add(this.pn_PainelVertices);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Grafos";
            this.Text = "Grafos";
            this.pn_PainelVertices.ResumeLayout(false);
            this.pn_PainelVertices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_updonw)).EndInit();
            this.pn_GrafoDigrafo.ResumeLayout(false);
            this.pn_GrafoDigrafo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_PainelVertices;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.NumericUpDown num_updonw;
        private System.Windows.Forms.Panel pn_GrafoDigrafo;
        private System.Windows.Forms.Label lb_InformaVAlor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_0;
        private System.Windows.Forms.RichTextBox rtxb_Matriz;
        private System.Windows.Forms.RadioButton rd_wharshal;
        private System.Windows.Forms.RadioButton rd_alcancabilidade;
    }
}