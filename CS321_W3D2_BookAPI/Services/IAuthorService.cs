using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W3D2_BookAPI.Models;

namespace CS321_W3D2_BookAPI.Services
{
    public interface IAuthorService
    {
        
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Author Add(Author author);
        // read
        Author Get(int id);
        // update
        Author Update(Author author);
        // delete
        void Remove(Author author);
        // list
        IEnumerable<Author> GetAll();
    
}
}
