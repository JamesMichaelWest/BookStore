using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BookStore.BusinessObjects;
using BookStore.DAL;

namespace BookStore.BLL
{
    public class AuthorBusinessService
    {
        public Author SaveAuthor(Author author)
        {
            AuthorData data = new AuthorData();
            return data.Save(author);
        }


        public List<Author> GetAuthors()
        {
            AuthorData data = new AuthorData();
            return data.GetAuthors();
        }

        public Author GetAuthorById(int id)
        {
            return new AuthorData().GetAuthorById(id);
        }

        public void Delete(int id)
        {
            new AuthorData().Delete(id);
        }
    }
}
