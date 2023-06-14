using System;
namespace pharmacie
{
	public class vente
	{
        public int serie{ get; set; }
        public DateTime Date { get; set; }
        public decimal MontantTotal { get; set; }
        private List<medicaments> medicamentvendu = new List<medicaments>(); 
    public vente()
		{

		}
	}
}

