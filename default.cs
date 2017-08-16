using System;

namespace rmeOrganizer
{
	/// <summary>
	/// Zusammenfassung für die neuen Standardeinstellungen.
	/// </summary>
	public class Defaults
	{

		/// <summary>
		/// Konstante für Sprache deutsch
		/// </summary>
		public const int GERMAN = 1;
		/// <summary>
		/// Konstante für Sprache englisch
		/// </summary
		public const int ENGLISH = 2;
		/// <summary>
		/// Sprachen als String
		/// </summary>
		public readonly static string[] LANGUAGE_NAME = {"unbekannt", "deutsch", "englisch"};
		/// <summary>
		/// Sprachen als XML-String
		/// </summary>
		public readonly static string[] LANGUAGE_XML = {"unknown", "german", "english"};
		/// <summary>
		/// Gesamtzahl der verwalteten Sprachen
		/// </summary>
		public const int LANGUAGES = 2;

		/// <summary>
		/// Konstante für Kategorie nicht angegeben
		/// </summary>
		public const int NO_CATEGORY = -1;
		/// <summary>
		/// Konstante für Kategorie Firma
		/// </summary>
		public const int COMPANY = 1;
		/// <summary>
		/// Konstante für Kategorie PR
		/// </summary>
		public const int PR = 2;
		/// <summary>
		/// Konstante für Kategorie CT
		/// </summary>
		public const int CT = 3;
		/// <summary>
		/// Konstante für Kategorie Redakteur
		/// </summary>
		public const int PRESS = 4;
		/// <summary>
		/// Konstante für Kategorie persönlich
		/// </summary>
		public const int PERSONAL = 5;
		/// <summary>
		/// Konstante für Kategorie privat
		/// </summary>
		public const int PRIVATE = 6;
		/// <summary>
		/// Konstante für Kategorie Partner
		/// </summary>
		public const int PARTNER = 7;
		/// <summary>
		/// Konstante für Kategorie Robin
		/// </summary>
		public const int ROBIN = 8;
		/// <summary>
		/// Konstante für Kategorie ELena
		/// </summary>
		public const int ELENA = 9;
		/// <summary>
		/// Konstante für Kategorie Verwandtschaft
		/// </summary>
		public const int FAMILY = 10;
		/// <summary>
		/// Konstante für Kategorie nur ich 
		/// </summary>
		public const int JUSTME = 11;
		/// <summary>
		/// Gesamtzahl der Kategorien
		/// </summary>
		public const int CATEGORIES = 11;

		/// <summary>
		/// Kategoriebezeichnungen
		/// </summary>
		public readonly static string[] CATEGORY_NAME = {"ohne Kategorie","Firma","PR","c't","Redakteur","persönlich","privat",
																											"Barbara","Robin","Elena","Verwandtschaft","ich"};

		/// <summary>
		/// Kategoriebezeichnungen für XML Ein- und Ausgabe
		/// </summary>
		public readonly static string[] CATEGORY_XML = {"none","company","pr","ct","press","personal","private",
																											"barbara","robin","elena","family","justme"};

		public Defaults()
		{
		}

	}
}
