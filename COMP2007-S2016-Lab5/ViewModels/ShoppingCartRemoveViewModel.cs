using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COMP2007_S2016_Lab5.Models;

namespace COMP2007_S2016_Lab5.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteId { get; set; }
    }
}