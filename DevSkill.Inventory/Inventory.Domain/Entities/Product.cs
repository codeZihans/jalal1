﻿namespace DevSkill.Inventory.Domain.Entities
{
    public class Product : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title {  get; set; }

      //  public List <Category> Categories { get; set; }

        public Product()
        {

        }
        
    }
}
