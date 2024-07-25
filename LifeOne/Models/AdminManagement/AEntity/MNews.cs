﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeOne.Models.AdminManagement.AEntity
{
    public class MNews
    {
        public int Pk_NewsId { get; set; }
        public string NewsHeading { get; set; }
        public string News { get; set; }
        public string NewsPreference { get; set; }
        public string InfoImgUrl { get; set; }
        public string InfoLink { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int ProcId { get; set; }
        public string Status { get; set; }
        public List<string> AssignTo { get; set; }
        public string AssignToValue { get; set; }
        public bool IsAscDesc { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public List<MNews> objList { get; set; }
    }
    public class ResponseNewsModel
    {
        public int Flag { get; set; }
        public string Msg { get; set; }
    }
}