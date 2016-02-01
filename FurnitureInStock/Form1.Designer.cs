namespace FurnitureInStock
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TheNumberOfDifferentTypesOfFurniture = new System.Windows.Forms.TextBox();
            this.NumberOfIndividuals = new System.Windows.Forms.TextBox();
            this.TheProbabilityOfMutation = new System.Windows.Forms.TextBox();
            this.TheProbabilityOfCrossing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество различных видов мебели:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество особей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вероятность мутации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вероятность скрещивания:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Решить с помощью генетического алгоритма";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TheNumberOfDifferentTypesOfFurniture
            // 
            this.TheNumberOfDifferentTypesOfFurniture.Location = new System.Drawing.Point(312, 28);
            this.TheNumberOfDifferentTypesOfFurniture.Name = "TheNumberOfDifferentTypesOfFurniture";
            this.TheNumberOfDifferentTypesOfFurniture.Size = new System.Drawing.Size(100, 22);
            this.TheNumberOfDifferentTypesOfFurniture.TabIndex = 5;
            // 
            // NumberOfIndividuals
            // 
            this.NumberOfIndividuals.Location = new System.Drawing.Point(312, 74);
            this.NumberOfIndividuals.Name = "NumberOfIndividuals";
            this.NumberOfIndividuals.Size = new System.Drawing.Size(100, 22);
            this.NumberOfIndividuals.TabIndex = 6;
            // 
            // TheProbabilityOfMutation
            // 
            this.TheProbabilityOfMutation.Location = new System.Drawing.Point(312, 116);
            this.TheProbabilityOfMutation.Name = "TheProbabilityOfMutation";
            this.TheProbabilityOfMutation.Size = new System.Drawing.Size(100, 22);
            this.TheProbabilityOfMutation.TabIndex = 7;
            // 
            // TheProbabilityOfCrossing
            // 
            this.TheProbabilityOfCrossing.Location = new System.Drawing.Point(312, 166);
            this.TheProbabilityOfCrossing.Name = "TheProbabilityOfCrossing";
            this.TheProbabilityOfCrossing.Size = new System.Drawing.Size(100, 22);
            this.TheProbabilityOfCrossing.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 515);
            this.Controls.Add(this.TheProbabilityOfCrossing);
            this.Controls.Add(this.TheProbabilityOfMutation);
            this.Controls.Add(this.NumberOfIndividuals);
            this.Controls.Add(this.TheNumberOfDifferentTypesOfFurniture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задача резервирования оптимального количества мебели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TheNumberOfDifferentTypesOfFurniture;
        private System.Windows.Forms.TextBox NumberOfIndividuals;
        private System.Windows.Forms.TextBox TheProbabilityOfMutation;
        private System.Windows.Forms.TextBox TheProbabilityOfCrossing;
    }
}

