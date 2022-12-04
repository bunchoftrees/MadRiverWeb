﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MadRiverWeb.Models;

public class Category
{
    [Key]
	public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}