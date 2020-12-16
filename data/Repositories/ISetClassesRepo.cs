using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using data.Models;

// https://www.codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
// https://www.programmingwithwolfgang.com/repository-pattern-net-core/
// https://www.c-sharpcorner.com/blogs/net-core-mvc-with-entity-framework-core-using-dependency-injection-and-repository


namespace data.IRepositories  
{  
    public interface ISetClassesRepo
    {  
        Task<IList<SetClass>> GetSetClasses();  
        void Add(SetClass setClass);  
    }  


    public class SetClassesRepo : ISetClassesRepo
    {  
        private readonly HildegaardDbContext setClassesContext;  
        public SetClassesRepo(HildegaardDbContext context)  
        {  
            setClassesContext = context;  
        }  
  
    public async Task<IList<SetClass>> GetSetClasses()  
        {  
            return await setClassesContext.SetClasses.ToListAsync();
        }  

        public void Add(SetClass setClass)  
        {  
            //setClass.Id =  Guid.NewGuid().ToString();  
            setClassesContext.Add(setClass);  
            setClassesContext.SaveChanges();  
        }  

    }  

}  




