using System;

namespace OrgansThing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string FirstName, LastName;
			bool WillingToBeAnOrganDonor;

			string numeroAuxiliar = "";
			int numeroConvertido;
			string ask = "How many organs?";
			bool sucessoConversao;
			
			bool repeat = false;
			do
			{
			Console.WriteLine(" -=- Venture Hospital Service Desk -=-");
			Console.WriteLine(" --- Volunteer Donors' Application ---");
			Console.Write("First Name: ");
			FirstName = Console.ReadLine();
			Console.Write("Last Name:  ");
			LastName = Console.ReadLine();
			Console.Write("Are you willing to be an Organ Donor(True/False)? ");
			WillingToBeAnOrganDonor = bool.Parse(Console.ReadLine());
				if (WillingToBeAnOrganDonor == true)
				{
					Console.WriteLine("We thank you for your kindness. A");
				}
				else
				{
					WillingToBeAnOrganDonor = false;
					Console.WriteLine("We thank you for your kindness. B");
					return;
				}
				if ( numeroAuxiliar == "1")
				{
				Console.WriteLine(ask);
				numeroAuxiliar = Console.ReadLine();
				Console.WriteLine(" -=- Venture Hospital Service Desk -=-");
				Console.WriteLine(" --- Volunteer Donors' Information ---");
				Console.WriteLine("Full Name:   {0} {1}", FirstName, LastName);
				Console.WriteLine("Organ Donor? {0}", WillingToBeAnOrganDonor);
				Console.WriteLine("Number of organs:   {0}", numeroAuxiliar);
				//numeroConvertido = Convert.ToInt32(numeroAuxiliar);
				//numeroConvertido = int.Parse(numeroAuxiliar);
				sucessoConversao = int.TryParse(numeroAuxiliar, out numeroConvertido);
				}
				else 
				{
				Console.WriteLine("You can only donate one organ.");
				Console.WriteLine(ask);
				numeroAuxiliar = Console.ReadLine();
				Console.WriteLine(" -=- Venture Hospital Service Desk -=-");
				Console.WriteLine(" --- Volunteer Donors' Information ---");
				Console.WriteLine("Full Name:   {0} {1}", FirstName, LastName);
				Console.WriteLine("Organ Donor? {0}", WillingToBeAnOrganDonor);
				Console.WriteLine("Number of organs:   {0}", numeroAuxiliar);
				sucessoConversao = int.TryParse(numeroAuxiliar, out numeroConvertido);
				}
				while (numeroAuxiliar != "1")
				{
				Console.WriteLine("You can only donate one organ.");	
				Console.WriteLine(ask);
				numeroAuxiliar = Console.ReadLine();
				Console.WriteLine(" -=- Venture Hospital Service Desk -=-");
				Console.WriteLine(" --- Volunteer Donors' Information ---");
				Console.WriteLine("Full Name:   {0} {1}", FirstName, LastName);
				Console.WriteLine("Organ Donor? {0}", WillingToBeAnOrganDonor);
				Console.WriteLine("Number of organs:   {0}", numeroAuxiliar);
				sucessoConversao = int.TryParse(numeroAuxiliar, out numeroConvertido);
				}
			}
			while (repeat);
		}
	}
}
