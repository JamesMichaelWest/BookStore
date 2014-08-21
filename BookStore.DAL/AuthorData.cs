using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using BookStore.BusinessObjects;

namespace BookStore.DAL
{
    public class AuthorData
    {
        public Author Save(Author author)
        {
            using (var context = new DataContext())
            {
                if (author.Id == 0)
                {
                    context.Authors.Add(author);
                }
                else
                {
                    context.Entry(author).State = EntityState.Modified;
                    context.Authors.AddOrUpdate(author);
                }
                context.SaveChanges();

            }
            return author;
        }

        public List<Author> GetAuthors()
        {
            using (var context = new DataContext())
            {
                return context.Authors.ToList();
            }
             
            //List<Author> authors = new List<Author>();

            //Author author = new Author();
            //author.Id = 1;
            //author.FirstName = "James";
            //author.LastName = "West";

            //authors.Add(author);

            //return authors;
        }

        public Author GetAuthorById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Authors.First(x => x.Id == id);
            }
        }

        public void Delete(int id)
        { 
            using (var context = new DataContext())
            {
                context.Authors.Remove(context.Authors.First(x => x.Id == id));
                context.SaveChanges();
            }
        }
    }
}