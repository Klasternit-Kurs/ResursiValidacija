using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResursiValidacija
{
	class Osoba : INotifyPropertyChanged
	{ 
		private int broj { get; set; }
		public int Broj 
		{ 
			get
			{
				return broj;
			}
			set
			{
				broj = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broj"));
			}
		}

		private string ime;
		public string Ime 
		{ 
			get
			{
				return ime;
			}
			set
			{
				ime = value;

				/*if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Ime"));
				} isto kao ovo ispod :) */ 
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ime"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public Osoba(string i)
		{
			Ime = i;
		}
		public Osoba() { }
	}
}
