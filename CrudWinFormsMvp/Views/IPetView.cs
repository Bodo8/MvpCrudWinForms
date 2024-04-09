using CrudWinFormsMvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWinFormsMvp.Views
{
    public interface IPetView
    {
        string IdPet { get; set; }
        string PetName { get; set; }
        string PetType { get; set; }
        string Colour { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPetListBindingSource(BindingSource pets);
        Dictionary<string, string> GetSelectedItem();
        void ShowEditTable();
        void Show();
        void ShowMainTable();
    }
}
