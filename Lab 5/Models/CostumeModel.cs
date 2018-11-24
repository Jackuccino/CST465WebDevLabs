﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Lab_5.Repositories;

namespace Lab_5.Models
{
    public class CostumeModel
    {
        public List<Costume> CostumeList = null;

        public CostumeModel()
        {
            ICostumeRepository costumeRepo = new CostumeDBRepository();
            CostumeList = new List<Costume>(costumeRepo.GetList());
        }

        public int Id { get; set; }
        [Required]
        public string CostumeName { get; set; }
    }
}
