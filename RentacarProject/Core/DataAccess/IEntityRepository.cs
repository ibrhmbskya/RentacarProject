using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic repository design pattenr kullanımı
    //ıcardal, ıbranddal, ıcolordal ayrı ayrı yapmaktansa böyle yapılır
    public interface IEntityRepository<T> where T:class,IEntity,new() //T ya ıentity olmalı ya da ıentityden implemente olan class olmalı. new sayesinde ıentity konamaz
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //bu sayede kategoriye göre ayır gibi şeyler yapmaya gerek yok
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
