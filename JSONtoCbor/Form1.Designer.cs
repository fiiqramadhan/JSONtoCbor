
namespace JSONtoCbor
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
            this.label1 = new System.Windows.Forms.Label();
            this.rTB_json = new System.Windows.Forms.RichTextBox();
            this.rTB_cbor = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "JSON";
            // 
            // rTB_json
            // 
            this.rTB_json.Location = new System.Drawing.Point(12, 79);
            this.rTB_json.Name = "rTB_json";
            this.rTB_json.Size = new System.Drawing.Size(309, 467);
            this.rTB_json.TabIndex = 1;
            this.rTB_json.Text = "";
            // 
            // rTB_cbor
            // 
            this.rTB_cbor.Location = new System.Drawing.Point(462, 79);
            this.rTB_cbor.Name = "rTB_cbor";
            this.rTB_cbor.Size = new System.Drawing.Size(309, 467);
            this.rTB_cbor.TabIndex = 3;
            this.rTB_cbor.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CBor";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(347, 292);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(94, 29);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.rTB_cbor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rTB_json);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTB_json;
        private System.Windows.Forms.RichTextBox rTB_cbor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_convert;
    }
}

