﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingListViewModel
    {
        [Key]
        public int ListId { get; set; }
        public Guid OwnerId { get; set; }
        public string ListName { get; set; }
        public string Color { get; set; }
    }
}