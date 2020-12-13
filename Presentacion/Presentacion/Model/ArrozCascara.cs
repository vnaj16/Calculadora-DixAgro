using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDixAgro_App.Model
{
    public class ArrozCascara
    {
		private decimal pmp;

		public decimal PMP
		{
			get { return pmp; }
			set { pmp = value; }
		}

		private decimal flete;

		public decimal Flete
		{
			get { return flete; }
			set { flete = value; }
		}

		private decimal subproducto;

		public decimal Subproducto
		{
			get { return subproducto; }
			set { subproducto = value; }
		}

		private decimal rkg;

		public decimal Rkg
		{
			get { return rkg; }
			set {
				/*if(value>=0 && value <= 1) {
					rkg = value;
				}
				else
				{
					rkg = value / 100;
				}*/
				rkg = value;
			}
		}

		private decimal cac;

		public decimal CAC
		{
			get { return ((PMP + Flete) - (Subproducto)) / Rkg; }
		}



	}
}
