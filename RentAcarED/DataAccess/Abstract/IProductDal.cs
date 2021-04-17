using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Veritabanında product ile yapacağımız işlemleri ayarlayacamız yer
    /// Crud işlemleri kısaca.
    /// </summary>
    public  interface IProductDal
    {
        /// <summary>
        /// Entities katmanı referans olarak alındı.
        /// Buradaki mantık, ürünleri listele ? nereden entity katmanından
        /// o zaman erişebilmek için referans eklemek zorundayız.
        /// interface methodları default olarak public'tir.
        /// </summary>
        /// <returns></returns>
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
