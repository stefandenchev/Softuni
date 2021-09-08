﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VaporStore.Data.Models.Enums;

namespace VaporStore.Data.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public PurchaseType Type { get; set; }
        public string ProductKey { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}