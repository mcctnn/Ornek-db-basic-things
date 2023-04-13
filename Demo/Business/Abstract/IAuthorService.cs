using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        //List<Author> GetByAuthorName(string authorName);
        void Add(Author author);
        void Delete(Author author);
        void Update(Author author);
    }
}
