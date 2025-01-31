﻿using TaskManager.Common.Models;

namespace TaskManager.API.Models
{
    public class CommonObject
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? Photo { get; set; }
        public CommonObject()
        {
            CreationDate = DateTime.Now;
        }
        public CommonObject(CommonModel commonModel) 
        { 
            Name = commonModel.Name;
            Description = commonModel.Description;
            CreationDate = DateTime.Now;
            Photo = commonModel.Photo;
                
        }
    }
}
