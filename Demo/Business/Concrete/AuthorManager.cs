using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorService  _authorService;
        public AuthorManager(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public void Add(Author author)
        {
            _authorService.Add(author);
        }

        public void Delete(Author author)
        {
            try
            {
                _authorService.Delete(author);
            }
            catch 
            {

                throw new Exception("Silme gerçekleşemedi!");
            }
            
        }

        public List<Author> GetAll()
        {
            return _authorService.GetAll();
        }

        //public List<Author> GetByAuthorName(string authorName)
        //{
          
        //    return _authorService.GetAll();
        //}

        public void Update(Author author)
        {
            _authorService.Update(author);
        }
    }
}
