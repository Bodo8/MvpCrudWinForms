using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWinFormsMvp.Models
{
    public interface IPetRepository
    {
        int Add(Pet pet);
        int Update(Pet pet);
        int Delete(Pet pet);
        IEnumerable<Pet> GetAll();
        IEnumerable<Pet> GetByValue(string value);
    }
}
