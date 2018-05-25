using System;
using System.Collections.Generic;
using System.Text;

namespace AppEscolar.Model
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public Xamarin.Forms.ImageSource Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
