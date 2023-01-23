using JopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopApp.Services
{
    public class CategoryManager
    {
        List<Category> categories = new()
      {
        new Category
        {Id = 1, CategoryName = ".Net", CreateDate = DateTime.Now,
        UpdatedDate = DateTime.Now },
        new Category
        {Id = 2, CategoryName = "Python",CreateDate = DateTime.Now,
        UpdatedDate = DateTime.Now },
        new Category
        {Id = 3,
        CategoryName = "React",
        CreateDate = DateTime.Now,
        UpdatedDate = DateTime.Now },
        new Category
        {Id = 4, CategoryName = "Angular",CreateDate = DateTime.Now,
        UpdatedDate = DateTime.Now }
      };

        
         public List<Category> GetAll()
        {
            return categories.ToList();
        }

    }
}
