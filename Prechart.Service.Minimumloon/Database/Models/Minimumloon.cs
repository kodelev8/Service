﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prechart.Service.Minimumloon.Database.Models;

public class Minimumloon
{
    [Key]
    public int Id { get; set; }
    public int Jaar { get; set; }
    public decimal MinimumloonLeeftijd { get; set; }
    public decimal MinimumloonPerMaand { get; set; }
    public decimal MinimumloonPerWeek { get; set; }
    public decimal MinimumloonPerDag { get; set; }
    public decimal MinimumloonPerUur36 { get; set; }
    public decimal MinimumloonPerUur38 { get; set; }
    public decimal MinimumloonPerUur40 { get; set; }
    public DateTime MinimumloonRecordActiefVanaf { get; set; }
    public DateTime MinimumloonRecordActiefTot { get; set; }
    public bool MinimumloonRecordActief { get; set; }
}