using System;
using System.Collections;
using System.Drawing;
using System.Net.Security;

namespace CardDealer.Models
{
    public abstract class Card : IComparable
    {
        public String CardUrl { get; protected set; }
        public abstract int CompareTo(object obj);

    }
}
