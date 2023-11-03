namespace PRACTICA_2_U3_3
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 22);
            label1.Name = "label1";
            label1.Size = new Size(612, 33);
            label1.TabIndex = 0;
            label1.Text = "Este prgrama suma los numeros capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 112);
            label2.Name = "label2";
            label2.Size = new Size(210, 24);
            label2.TabIndex = 1;
            label2.Text = "Introduce un Número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(346, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(346, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(87, 348);
            label3.Name = "label3";
            label3.Size = new Size(227, 24);
            label3.TabIndex = 4;
            label3.Text = "La suma de todos son:";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(343, 162);
            button2.Name = "button2";
            button2.Size = new Size(128, 48);
            button2.TabIndex = 5;
            button2.Text = "AÑADIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(328, 250);
            button1.Name = "button1";
            button1.Size = new Size(157, 63);
            button1.TabIndex = 6;
            button1.Text = "SUMAR\r\nNUMEROS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(575, 96);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 292);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
    }
}