using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrudWinFormsMvp.Models
{
    public class Pet
    {
        private int _idPet;
        private string _petName;
        private string _petType;
        private string _colour;

        [DisplayName("Pet ID")]
        public int IdPet { get => _idPet; set => _idPet = value; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Fraze must be between 3 and 50 characters")]
        public string PetName { get => _petName; set => _petName = value; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Fraze must be between 3 and 50 characters")]
        public string PetType { get => _petType; set => _petType = value; }

        [DisplayName("Colour")]
        [Required(ErrorMessage = "Colour is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Fraze must be between 3 and 50 characters")]
        public string Colour { get => _colour; set => _colour = value; }
    }
}
