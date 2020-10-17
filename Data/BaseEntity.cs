using System;

namespace Data
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
        }

        public BaseEntity(string name, string description)
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;

            this.Name = name;
            this.Description = description;
        }

        public BaseEntity(string name)
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;

            this.Name = name;
        }
    }
}