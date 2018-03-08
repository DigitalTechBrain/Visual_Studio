using System;

namespace MVCDemo.Models
{
    internal class DataMemberAttribute : Attribute
    {
        public string Name { get; set; }
    }
}