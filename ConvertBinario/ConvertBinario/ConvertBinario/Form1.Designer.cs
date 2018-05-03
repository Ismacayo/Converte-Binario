namespace ConvertBinario
{
    partial class ConvertBinario
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
            this.Decimal = new System.Windows.Forms.TextBox();
            this.Binario = new System.Windows.Forms.TextBox();
            this.Octal = new System.Windows.Forms.TextBox();
            this.HexaDecimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EscolhaCalc = new System.Windows.Forms.ComboBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BotaoSoma = new System.Windows.Forms.Button();
            this.BotaoDividir = new System.Windows.Forms.Button();
            this.BotaoMultiplicar = new System.Windows.Forms.Button();
            this.BotaoSubtrair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(82, 26);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(93, 20);
            this.Decimal.TabIndex = 1;
            this.Decimal.TextChanged += new System.EventHandler(this.Decimal_TextChanged);
            // 
            // Binario
            // 
            this.Binario.Location = new System.Drawing.Point(82, 66);
            this.Binario.Name = "Binario";
            this.Binario.Size = new System.Drawing.Size(93, 20);
            this.Binario.TabIndex = 2;
            this.Binario.TextChanged += new System.EventHandler(this.Binario_TextChanged);
            // 
            // Octal
            // 
            this.Octal.Location = new System.Drawing.Point(82, 112);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(93, 20);
            this.Octal.TabIndex = 3;
            this.Octal.TextChanged += new System.EventHandler(this.Octal_TextChanged);
            // 
            // HexaDecimal
            // 
            this.HexaDecimal.Location = new System.Drawing.Point(82, 155);
            this.HexaDecimal.Name = "HexaDecimal";
            this.HexaDecimal.Size = new System.Drawing.Size(93, 20);
            this.HexaDecimal.TabIndex = 4;
            this.HexaDecimal.TextChanged += new System.EventHandler(this.HexaDecimal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hexadecimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Binário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Octal";
            // 
            // EscolhaCalc
            // 
            this.EscolhaCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EscolhaCalc.FormattingEnabled = true;
            this.EscolhaCalc.Location = new System.Drawing.Point(246, 12);
            this.EscolhaCalc.Name = "EscolhaCalc";
            this.EscolhaCalc.Size = new System.Drawing.Size(91, 21);
            this.EscolhaCalc.TabIndex = 9;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(246, 52);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(91, 20);
            this.Num1.TabIndex = 10;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(246, 90);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(91, 20);
            this.Num2.TabIndex = 11;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(246, 197);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(91, 20);
            this.Resultado.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Num 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Num1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result";
            // 
            // BotaoSoma
            // 
            this.BotaoSoma.Location = new System.Drawing.Point(257, 116);
            this.BotaoSoma.Name = "BotaoSoma";
            this.BotaoSoma.Size = new System.Drawing.Size(24, 23);
            this.BotaoSoma.TabIndex = 16;
            this.BotaoSoma.Text = "+";
            this.BotaoSoma.UseVisualStyleBackColor = true;
            this.BotaoSoma.Click += new System.EventHandler(this.BotaoSoma_Click);
            // 
            // BotaoDividir
            // 
            this.BotaoDividir.Location = new System.Drawing.Point(257, 148);
            this.BotaoDividir.Name = "BotaoDividir";
            this.BotaoDividir.Size = new System.Drawing.Size(24, 23);
            this.BotaoDividir.TabIndex = 17;
            this.BotaoDividir.Text = "/";
            this.BotaoDividir.UseVisualStyleBackColor = true;
            this.BotaoDividir.Click += new System.EventHandler(this.BotaoDividir_Click);
            // 
            // BotaoMultiplicar
            // 
            this.BotaoMultiplicar.Location = new System.Drawing.Point(296, 148);
            this.BotaoMultiplicar.Name = "BotaoMultiplicar";
            this.BotaoMultiplicar.Size = new System.Drawing.Size(24, 23);
            this.BotaoMultiplicar.TabIndex = 18;
            this.BotaoMultiplicar.Text = "*";
            this.BotaoMultiplicar.UseVisualStyleBackColor = true;
            this.BotaoMultiplicar.Click += new System.EventHandler(this.BotaoMultiplicar_Click);
            // 
            // BotaoSubtrair
            // 
            this.BotaoSubtrair.Location = new System.Drawing.Point(296, 116);
            this.BotaoSubtrair.Name = "BotaoSubtrair";
            this.BotaoSubtrair.Size = new System.Drawing.Size(24, 23);
            this.BotaoSubtrair.TabIndex = 19;
            this.BotaoSubtrair.Text = "-";
            this.BotaoSubtrair.UseVisualStyleBackColor = true;
            this.BotaoSubtrair.Click += new System.EventHandler(this.BotaoSubtrair_Click);
            // 
            // ConvertBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 227);
            this.Controls.Add(this.BotaoSubtrair);
            this.Controls.Add(this.BotaoMultiplicar);
            this.Controls.Add(this.BotaoDividir);
            this.Controls.Add(this.BotaoSoma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.EscolhaCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HexaDecimal);
            this.Controls.Add(this.Octal);
            this.Controls.Add(this.Binario);
            this.Controls.Add(this.Decimal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertBinario";
            this.Text = "ConvertBinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Decimal;
        private System.Windows.Forms.TextBox Binario;
        private System.Windows.Forms.TextBox Octal;
        private System.Windows.Forms.TextBox HexaDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EscolhaCalc;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotaoSoma;
        private System.Windows.Forms.Button BotaoDividir;
        private System.Windows.Forms.Button BotaoMultiplicar;
        private System.Windows.Forms.Button BotaoSubtrair;
    }
}

