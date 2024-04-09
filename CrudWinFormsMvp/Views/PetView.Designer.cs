namespace CrudWinFormsMvp.Views
{
    partial class PetView
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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewPets = new DataGridView();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAddNew = new Button();
            buttonSearch = new Button();
            label2 = new Label();
            textSearch = new TextBox();
            petDetail = new TabPage();
            petColour = new Label();
            petType = new Label();
            petName = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textPetColour = new TextBox();
            textPetType = new TextBox();
            textPetName = new TextBox();
            textPetId = new TextBox();
            petId = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).BeginInit();
            petDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 56);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(petDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 56);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1310, 684);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.Honeydew;
            tabPage1.Controls.Add(dataGridViewPets);
            tabPage1.Controls.Add(buttonDelete);
            tabPage1.Controls.Add(buttonEdit);
            tabPage1.Controls.Add(buttonAddNew);
            tabPage1.Controls.Add(buttonSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textSearch);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1302, 656);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet list";
            // 
            // dataGridViewPets
            // 
            dataGridViewPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPets.Location = new Point(8, 66);
            dataGridViewPets.Name = "dataGridViewPets";
            dataGridViewPets.RowTemplate.Height = 25;
            dataGridViewPets.Size = new Size(798, 432);
            dataGridViewPets.TabIndex = 7;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(812, 135);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 28);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(812, 102);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(108, 27);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(812, 66);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(108, 30);
            buttonAddNew.TabIndex = 4;
            buttonAddNew.Text = "Add new";
            buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(289, 33);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 27);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Search pet:";
            // 
            // textSearch
            // 
            textSearch.Location = new Point(8, 33);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(275, 25);
            textSearch.TabIndex = 0;
            // 
            // petDetail
            // 
            petDetail.BackColor = Color.LemonChiffon;
            petDetail.Controls.Add(petColour);
            petDetail.Controls.Add(petType);
            petDetail.Controls.Add(petName);
            petDetail.Controls.Add(buttonCancel);
            petDetail.Controls.Add(buttonSave);
            petDetail.Controls.Add(textPetColour);
            petDetail.Controls.Add(textPetType);
            petDetail.Controls.Add(textPetName);
            petDetail.Controls.Add(textPetId);
            petDetail.Controls.Add(petId);
            petDetail.Location = new Point(4, 24);
            petDetail.Name = "petDetail";
            petDetail.Padding = new Padding(3);
            petDetail.Size = new Size(1302, 656);
            petDetail.TabIndex = 1;
            petDetail.Text = "Pet detail";
            // 
            // petColour
            // 
            petColour.AutoSize = true;
            petColour.Location = new Point(52, 154);
            petColour.Name = "petColour";
            petColour.Size = new Size(64, 15);
            petColour.TabIndex = 9;
            petColour.Text = "Pet colour:";
            // 
            // petType
            // 
            petType.AutoSize = true;
            petType.Location = new Point(195, 95);
            petType.Name = "petType";
            petType.Size = new Size(53, 15);
            petType.TabIndex = 8;
            petType.Text = "Pet type:";
            // 
            // petName
            // 
            petName.AutoSize = true;
            petName.Location = new Point(52, 95);
            petName.Name = "petName";
            petName.Size = new Size(60, 15);
            petName.TabIndex = 7;
            petName.Text = "Pet name:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(192, 229);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(103, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(52, 229);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textPetColour
            // 
            textPetColour.Location = new Point(52, 172);
            textPetColour.Name = "textPetColour";
            textPetColour.Size = new Size(243, 23);
            textPetColour.TabIndex = 4;
            // 
            // textPetType
            // 
            textPetType.Location = new Point(195, 113);
            textPetType.Name = "textPetType";
            textPetType.Size = new Size(100, 23);
            textPetType.TabIndex = 3;
            // 
            // textPetName
            // 
            textPetName.Location = new Point(52, 113);
            textPetName.Name = "textPetName";
            textPetName.Size = new Size(100, 23);
            textPetName.TabIndex = 2;
            // 
            // textPetId
            // 
            textPetId.Location = new Point(52, 54);
            textPetId.Name = "textPetId";
            textPetId.Size = new Size(107, 23);
            textPetId.TabIndex = 1;
            // 
            // petId
            // 
            petId.AutoSize = true;
            petId.Location = new Point(52, 36);
            petId.Name = "petId";
            petId.Size = new Size(38, 15);
            petId.TabIndex = 0;
            petId.Text = "Pet ID";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 740);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).EndInit();
            petDetail.ResumeLayout(false);
            petDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage petDetail;
        private TextBox textSearch;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAddNew;
        private Button buttonSearch;
        private Label label2;
        private Label petColour;
        private Label petType;
        private Label petName;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textPetColour;
        private TextBox textPetType;
        private TextBox textPetName;
        private TextBox textPetId;
        private Label petId;
        private DataGridView dataGridViewPets;
    }
}