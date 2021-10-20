﻿using Newtonsoft.Json;
using System;


namespace Library.TaskAppointmentManager.Models
{
    public class Item
    {
        private static int currentId = 1;
        public int id;

        //set ID to 0 so that it can be set
        public Item()
        {
            id = 0;
        }

        public int Id {
            get 
            {
                return id;
            }
            set
            {
                id = currentId++;
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
    }
}
