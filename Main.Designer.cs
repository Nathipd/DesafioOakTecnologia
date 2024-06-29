namespace DesafioOakTecnologia
{
    partial class Main
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
            Panel_lList = new Panel();
            ListView_Register = new ListView();
            Panel_Info = new Panel();
            Button_Add = new Button();
            Label_AddPrice = new Label();
            Label_AddDescription = new Label();
            Label_AddName = new Label();
            Check_AddAvailable = new CheckBox();
            TextBox_Price = new TextBox();
            TextBox_Description = new TextBox();
            TextBox_Name = new TextBox();
            Label_AvaliableValue = new Label();
            Label_Avaliable = new Label();
            Label_PriceValue = new Label();
            Label_Price = new Label();
            Label_DescriptionValue = new Label();
            Label_Description = new Label();
            Label_NameValue = new Label();
            Label_Name = new Label();
            Panel_lList.SuspendLayout();
            Panel_Info.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_lList
            // 
            Panel_lList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_lList.AutoSize = true;
            Panel_lList.BackColor = SystemColors.WindowFrame;
            Panel_lList.Controls.Add(ListView_Register);
            Panel_lList.Location = new Point(0, 0);
            Panel_lList.Name = "Panel_lList";
            Panel_lList.Size = new Size(476, 398);
            Panel_lList.TabIndex = 1;
            // 
            // ListView_Register
            // 
            ListView_Register.Location = new Point(34, 24);
            ListView_Register.Name = "ListView_Register";
            ListView_Register.Size = new Size(421, 348);
            ListView_Register.TabIndex = 0;
            ListView_Register.UseCompatibleStateImageBehavior = false;
            ListView_Register.SelectedIndexChanged += listViewCadastro_SelectedIndexChanged;
            // 
            // Panel_Info
            // 
            Panel_Info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Panel_Info.AutoSize = true;
            Panel_Info.BackColor = SystemColors.ActiveCaption;
            Panel_Info.Controls.Add(Button_Add);
            Panel_Info.Controls.Add(Label_AddPrice);
            Panel_Info.Controls.Add(Label_AddDescription);
            Panel_Info.Controls.Add(Label_AddName);
            Panel_Info.Controls.Add(Check_AddAvailable);
            Panel_Info.Controls.Add(TextBox_Price);
            Panel_Info.Controls.Add(TextBox_Description);
            Panel_Info.Controls.Add(TextBox_Name);
            Panel_Info.Controls.Add(Label_AvaliableValue);
            Panel_Info.Controls.Add(Label_Avaliable);
            Panel_Info.Controls.Add(Label_PriceValue);
            Panel_Info.Controls.Add(Label_Price);
            Panel_Info.Controls.Add(Label_DescriptionValue);
            Panel_Info.Controls.Add(Label_Description);
            Panel_Info.Controls.Add(Label_NameValue);
            Panel_Info.Controls.Add(Label_Name);
            Panel_Info.Location = new Point(476, 0);
            Panel_Info.Name = "Panel_Info";
            Panel_Info.Size = new Size(284, 398);
            Panel_Info.TabIndex = 2;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(126, 342);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(75, 23);
            Button_Add.TabIndex = 15;
            Button_Add.Text = "Adicionar";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += buttonAdd_Click;
            // 
            // Label_AddPrice
            // 
            Label_AddPrice.AutoSize = true;
            Label_AddPrice.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_AddPrice.Location = new Point(86, 269);
            Label_AddPrice.Name = "Label_AddPrice";
            Label_AddPrice.Size = new Size(34, 15);
            Label_AddPrice.TabIndex = 14;
            Label_AddPrice.Text = "Valor";
            // 
            // Label_AddDescription
            // 
            Label_AddDescription.AutoSize = true;
            Label_AddDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_AddDescription.Location = new Point(55, 229);
            Label_AddDescription.Name = "Label_AddDescription";
            Label_AddDescription.Size = new Size(65, 17);
            Label_AddDescription.TabIndex = 13;
            Label_AddDescription.Text = "Descrição";
            // 
            // Label_AddName
            // 
            Label_AddName.AutoSize = true;
            Label_AddName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_AddName.Location = new Point(76, 189);
            Label_AddName.Name = "Label_AddName";
            Label_AddName.Size = new Size(44, 17);
            Label_AddName.TabIndex = 12;
            Label_AddName.Text = "Nome";
            // 
            // Check_AddAvailable
            // 
            Check_AddAvailable.AutoSize = true;
            Check_AddAvailable.Location = new Point(126, 305);
            Check_AddAvailable.Name = "Check_AddAvailable";
            Check_AddAvailable.Size = new Size(81, 19);
            Check_AddAvailable.TabIndex = 11;
            Check_AddAvailable.Text = "Disponível";
            Check_AddAvailable.UseVisualStyleBackColor = true;
            // 
            // TextBox_Price
            // 
            TextBox_Price.Location = new Point(126, 266);
            TextBox_Price.Name = "TextBox_Price";
            TextBox_Price.Size = new Size(100, 23);
            TextBox_Price.TabIndex = 10;
            // 
            // TextBox_Description
            // 
            TextBox_Description.Location = new Point(126, 228);
            TextBox_Description.Name = "TextBox_Description";
            TextBox_Description.Size = new Size(100, 23);
            TextBox_Description.TabIndex = 9;
            // 
            // TextBox_Name
            // 
            TextBox_Name.Location = new Point(126, 188);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.Size = new Size(100, 23);
            TextBox_Name.TabIndex = 8;
            // 
            // Label_AvaliableValue
            // 
            Label_AvaliableValue.AutoSize = true;
            Label_AvaliableValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_AvaliableValue.Location = new Point(138, 126);
            Label_AvaliableValue.Name = "Label_AvaliableValue";
            Label_AvaliableValue.Size = new Size(65, 16);
            Label_AvaliableValue.TabIndex = 7;
            Label_AvaliableValue.Text = "Disponivel";
            // 
            // Label_Avaliable
            // 
            Label_Avaliable.AutoSize = true;
            Label_Avaliable.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Avaliable.Location = new Point(53, 125);
            Label_Avaliable.Name = "Label_Avaliable";
            Label_Avaliable.Size = new Size(79, 17);
            Label_Avaliable.TabIndex = 6;
            Label_Avaliable.Text = "Disponível:";
            // 
            // Label_PriceValue
            // 
            Label_PriceValue.AutoSize = true;
            Label_PriceValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_PriceValue.Location = new Point(102, 100);
            Label_PriceValue.Name = "Label_PriceValue";
            Label_PriceValue.Size = new Size(41, 16);
            Label_PriceValue.TabIndex = 5;
            Label_PriceValue.Text = "Preco";
            // 
            // Label_Price
            // 
            Label_Price.AutoSize = true;
            Label_Price.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Price.Location = new Point(53, 100);
            Label_Price.Name = "Label_Price";
            Label_Price.Size = new Size(44, 17);
            Label_Price.TabIndex = 4;
            Label_Price.Text = "Valor:";
            // 
            // Label_DescriptionValue
            // 
            Label_DescriptionValue.AutoSize = true;
            Label_DescriptionValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_DescriptionValue.Location = new Point(136, 77);
            Label_DescriptionValue.Name = "Label_DescriptionValue";
            Label_DescriptionValue.Size = new Size(65, 16);
            Label_DescriptionValue.TabIndex = 3;
            Label_DescriptionValue.Text = "Descricao";
            // 
            // Label_Description
            // 
            Label_Description.AutoSize = true;
            Label_Description.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Description.Location = new Point(53, 77);
            Label_Description.Name = "Label_Description";
            Label_Description.Size = new Size(79, 17);
            Label_Description.TabIndex = 2;
            Label_Description.Text = "Descrição:";
            // 
            // Label_NameValue
            // 
            Label_NameValue.AutoSize = true;
            Label_NameValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_NameValue.Location = new Point(110, 51);
            Label_NameValue.Name = "Label_NameValue";
            Label_NameValue.Size = new Size(54, 16);
            Label_NameValue.TabIndex = 1;
            Label_NameValue.Text = "Nathalia";
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Name.Location = new Point(53, 51);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(51, 17);
            Label_Name.TabIndex = 0;
            Label_Name.Text = "Nome:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 398);
            Controls.Add(Panel_Info);
            Controls.Add(Panel_lList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Desafio Oak Tecnologia";
            Panel_lList.ResumeLayout(false);
            Panel_Info.ResumeLayout(false);
            Panel_Info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Panel_lList;
        private Panel Panel_Info;
        private ListView ListView_Register;
        private Label Label_Name;
        private Label Label_Price;
        private Label Label_DescriptionValue;
        private Label Label_Description;
        private Label Label_NameValue;
        private Label Label_AvaliableValue;
        private Label Label_Avaliable;
        private Label Label_PriceValue;
        private TextBox TextBox_Price;
        private TextBox TextBox_Description;
        private TextBox TextBox_Name;
        private Button Button_Add;
        private Label Label_AddPrice;
        private Label Label_AddDescription;
        private Label Label_AddName;
        private CheckBox Check_AddAvailable;
    }
}
