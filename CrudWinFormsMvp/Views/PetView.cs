using CrudWinFormsMvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWinFormsMvp.Views
{
    public partial class PetView : Form, IPetView
    {
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonAddNew.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };

            buttonSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            buttonEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            buttonCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            buttonDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string IdPet { get => textPetId.Text; set => textPetId.Text = value; }
        public string PetName { get => textPetName.Text; set => textPetName.Text = value; }
        public string PetType { get => textPetType.Text; set => textPetType.Text = value; }
        public string Colour { get => textPetColour.Text; set => textPetColour.Text = value; }
        public string SearchValue { get => textSearch.Text; set => textSearch.Text = value; }
        public bool IsEdit { get => _isEdit; set => _isEdit = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource pets)
        {
            dataGridViewPets.DataSource = pets;
        }

        public void ShowEditTable()
        {
            tabControl1.SelectTab(1);
            tabControl1.Show();
        }

        public Dictionary<string, string> GetSelectedItem()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var bb = dataGridViewPets;
            if (dataGridViewPets.SelectedRows.Count == 0)
                return result;
            var index = dataGridViewPets.SelectedRows[0].Index;
            var cells = dataGridViewPets.Rows[index].Cells;
            result.Add("IdPet", cells[0].Value.ToString());
            result.Add("PetName", cells[1].Value.ToString());
            result.Add("PetType", cells[2].Value.ToString());
            result.Add("Colour", cells[3].Value?.ToString());

            return result;
        }

        public void ShowMainTable()
        {
            tabControl1.SelectTab(0);
            tabControl1.Show();
        }
    }
}
