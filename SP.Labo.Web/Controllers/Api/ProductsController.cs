using SP.Labo.Web.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SP.Labo.Web.Controllers.Api
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]  
        {  
            new Product { Id = 1, Name = "トマトスープ", Category = "食料雑貨", Price = 100 },  
            new Product { Id = 2, Name = "ヨーヨー", Category = "おもちゃ", Price = 3.75M },  
            new Product { Id = 3, Name = "ハンマー", Category = "工具", Price = 16.99M }  
        };
        
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}