using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumber.Model
{
	public class Roman
	{
		/// <summary>
		/// The symbols "I", "V", "X", "L", "C", "D", "M"
		/// </summary>
		public char Symbol { get; set; }

		/// <summary>
		/// The symbols values I:1, V:5, X:10, L:50, C:100, D:500, M:1000
		/// </summary>
		public int Value { get; set; }

		/// <summary>
		/// The flag that the symbol can be repeated.
		/// </summary>
		public bool CanRepeat { get; set; }
	}
}
