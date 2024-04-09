using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWinFormsMvp.Models;
using CrudWinFormsMvp.Views;

namespace CrudWinFormsMvp.Presenters
{
    public class PetPresenter
    {
        private IPetView _view;
        private IPetRepository _petRepository;
        private BindingSource _petrBindingSource;
        private IEnumerable<Pet> _pets;

        public PetPresenter(IPetView view, IPetRepository petRepository)
        {
            _petrBindingSource = new BindingSource();
            _view = view;
            _petRepository = petRepository;

            LoadAllPets();
            _view.SetPetListBindingSource(_petrBindingSource);
            _view.SearchEvent += SearchPet;
            _view.AddNewEvent += AddNewPet;
            _view.EditEvent += EditAction;
            _view.DeleteEvent += DeletePet;
            _view.SaveEvent += SavePet;
            _view.CancelEvent += CancelAction;

            _view.Show();
        }

        private void EditAction(object? sender, EventArgs e)
        {
            Dictionary<string, string> rows = LoadSelectesPetToEdit(sender, e);

            if (rows.Count == 0)
                return;
            else
                _view.ShowEditTable();
        }

        private void LoadAllPets()
        {
            try
            {
                _pets = _petRepository.GetAll();
                _petrBindingSource.DataSource = _pets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania zapytania do bazy danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchPet(object? sender, EventArgs e)
        {
            bool isEmptyValue = string.IsNullOrEmpty(_view.SearchValue);

            try
            {
                if (!isEmptyValue)
                    _pets = _petRepository.GetByValue(_view.SearchValue);
                else
                    _pets = _petRepository.GetAll();
                _petrBindingSource.DataSource = _pets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania zapytania do bazy danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearPetData();
            RefreshPetList();
            _view.ShowMainTable();
        }

        private void RefreshPetList()
        {
            LoadAllPets();
            _view.SetPetListBindingSource(_petrBindingSource);
        }

        private void SavePet(object? sender, EventArgs e)
        {
            int response = 0;

            try
            {
                int id = string.IsNullOrEmpty(_view.IdPet) ? 0 : int.Parse(_view.IdPet);
                Pet pet = new Pet() { IdPet = id, PetName = _view.PetName, PetType = _view.PetType, Colour = _view.Colour };

                if (pet.IdPet == 0)
                    response = _petRepository.Add(pet);
                else
                    response = _petRepository.Update(pet);

                CancelAction(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania zapytania do bazy danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePet(object? sender, EventArgs e)
        {
            int response = 0;

            try
            {
                LoadSelectesPetToEdit(sender, e);
                int id = string.IsNullOrEmpty(_view.IdPet) ? 0 : int.Parse(_view.IdPet);
                Pet pet = new Pet() { IdPet = id };
                response = _petRepository.Delete(pet);
                RefreshPetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania zapytania do bazy danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> LoadSelectesPetToEdit(object? sender, EventArgs e)
        {
            Dictionary<string, string> rows = _view.GetSelectedItem();

            if (rows.Count == 0)
            {
                MessageBox.Show("Wybierz pozycje z listy do edycji", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return rows;
            }

            try
            {
                _view.IdPet = rows["IdPet"];
                _view.PetName = rows["PetName"];
                _view.PetType = rows["PetType"];
                _view.Colour = rows["Colour"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania zapytania do bazy danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rows;
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            _view.ShowEditTable();
        }

        private void ClearPetData()
        {
            _view.IdPet = "0";
            _view.PetName = string.Empty;
            _view.PetType = string.Empty;
            _view.Colour = string.Empty;
        }
    }
}
