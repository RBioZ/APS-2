using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/*
 * Atividade de Prática Supervisionada
 * 2º Periodo de Ciencias da Computacao
 * Create By: Jonatha Rihan da Silva (RBioZ)
 * Data: 14.10.2019
 * Version: 1.0
 */


//Classe do projeto
class Program
{
    //Menu
    static void Main()
    {
        Console.Clear();
        int choice = 0;

        Console.Title = "Atividade Prática Supervisionada 2019";
        Console.SetWindowSize(75, 40);
        Console.Beep(440, 300);
        Console.Beep(520, 200);
        Console.Beep(900, 200);
        string title1 = @"
	.----------------. .----------------. .----------------. 
	| .--------------. | .--------------. | .--------------. |
	| |      __      | | |   ______     | | |    _______   | |
	| |     /  \     | | |  |_   __ \   | | |   /  ___  |  | |
	| |    / /\ \    | | |    | |__) |  | | |  |  (__ \_|  | |
	| |   / ____ \   | | |    |  ___/   | | |   '.___`-.   | |
	| | _/ /    \ \_ | | |   _| |_      | | |  |`\____) |  | |
	| ||____|  |____|| | |  |_____|     | | |  |_______.'  | |
	| |              | | |              | | |              | |
	| '--------------' | '--------------' | '--------------' |
	'----------------' '----------------' '----------------' .RBioZ
	";
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(new string(':', 75));
        Console.WriteLine(title1);
        Console.WriteLine(new string(':', 75));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n[1] - MegaSena");
        Console.WriteLine("[2] - Base de CEP");
		Console.WriteLine("[3] - FastSerch");
        Console.WriteLine("\n[0] - SAIR");
        Console.Write("\n> ");
        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Main();
        }

        if (choice == 1)
        {
            MegaSena_Menu();
        }
        else if (choice == 2)
        {
            CEP_Menu();
        }
        else if (choice == 3)
        {
			Fast_Search();
        }
		else if (choice == 0)
        {
            Console.Beep(900, 200);
            Console.Beep(520, 200);
            Console.Beep(440, 200);
            Environment.Exit(-1);
        }
        else
        {
            Console.WriteLine("Invalid option");
            Console.WriteLine("\n\nPress any button to continue...");
            Console.ReadKey();
            Main();
        }
    }
	
    ///MegaSena_Menu
    public static void MegaSena_Menu()
    {
        ///Declaracao e Incicializacao das Variveis
        int option = 0;
        string search;

        do
        {
            Console.Clear();
            string title2 = @"
          __  __                     _____                  
         |  \/  |                   / ____|                 
         | \  / | ___  __ _  __ _  | (___   ___ _ __   __ _ 
         | |\/| |/ _ \/ _` |/ _` |  \___ \ / _ | '_ \ / _` |
         | |  | |  __| (_| | (_| |  ____) |  __| | | | (_| |
         |_|  |_|\___|\__, |\__,_| |_____/ \___|_| |_|\__,_|
                       __/ |                                
                      |___/                                 
    ";
            Console.Beep(440, 300);
            Console.WriteLine();
            Console.WriteLine(new string(':', 75));
            Console.WriteLine(title2);
            Console.WriteLine(new string(':', 75));

            Console.WriteLine("\nPESQUISAR POR: \n");
            Console.WriteLine("[1] - Sorteio");
            Console.WriteLine("[2] - Data");
            Console.WriteLine("[3] - Retornar Números");
            Console.WriteLine("\n[4] - MENU");
            Console.Write("\n> ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("ERROR {0}", e);
                Console.WriteLine("Press any button to continue...");
                Console.ReadKey();
            }
            if (option == 1)
            {
                Console.Write("\nSorteio: ");
				Console.ForegroundColor = ConsoleColor.Green;
				search = Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.Gray;

                var ms_return_1 = Mega.Pesquisa_Mega_1(search);
				
				Console.WriteLine(new string('_', 75));
                Console.Write("\nNumeros Sorteados: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ms_return_1[0]);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nData: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ms_return_1[1]);
                Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine(new string('_', 75));
                Console.WriteLine("\n\nPress any button to continue...");
                Console.ReadKey();
            }
            else if (option == 2)
            {
                Console.Write("\nData: ");
				Console.ForegroundColor = ConsoleColor.Green;
				search = Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.Gray;

                var ms_return_2 = Mega.Pesquisa_Mega_2(search);
				
				Console.WriteLine(new string('_', 75));
                Console.Write("\nNumeros Sorteados: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ms_return_2[0]);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nConcurso: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ms_return_2[1]);
                Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine(new string('_', 75));
                Console.WriteLine("\n\nPress any button to continue...");
                Console.ReadKey();
            }
            else if (option == 3)
            {
                var pm3 = Mega.Pesquisa_Mega_3();
                Console.WriteLine();
				Console.WriteLine(new string('_', 75));
				Console.WriteLine();
                for (int i = 0; i < 60; i++)
                {
                    Console.Write("Nº {0} : {1} | ", i + 1, pm3[i]);
                }
				Console.WriteLine();
				Console.WriteLine(new string('_', 75));
                Console.WriteLine("\n\nPress any button to continue...");
                Console.ReadKey();
            }
            else if (option == 4)
            {
                Main();
            }
            else
            {
                MegaSena_Menu();
            }

        } while (option != 0);

    }

    ///Classe Base de CEP Menu
    public static void CEP_Menu()
    {
        Console.Clear();
        int option = 0;
        string cep = "";
        string log = "";
        //int op = 0;
        string title3 = @"
			
            ____                         __        ________________ 
           / __ )____ _________     ____/ ___     / ____/ ____/ __ \
          / __  / __ `/ ___/ _ \   / __  / _ \   / /   / __/ / /_/ /
         / /_/ / /_/ (__  /  __/  / /_/ /  __/  / /___/ /___/ ____/ 
        /_____/\__,_/____/\___/   \__,_/\___/   \____/_____/_/      
                                                            
		";

        Console.Beep(440, 300);
        Console.WriteLine();
        Console.WriteLine(new string(':', 75));
        Console.WriteLine(title3);
        Console.WriteLine(new string(':', 75));
        Console.WriteLine("\nPESQUISAR POR: \n");
        Console.WriteLine("[1] - CEP");
        Console.WriteLine("[2] - Logradouro");
        Console.WriteLine("\n[3] - Menu");
        Console.Write("\n> ");

        try
        {
            option = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException e)
        {
            Console.WriteLine("ERROR {0}", e);
            Console.WriteLine("Press any button to continue...");
            Console.ReadKey();
        }
        if (option == 1)
        {
            Console.Write("\nCEP: ");
            Console.ForegroundColor = ConsoleColor.Green;
            cep = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            var c_return_1 = CEP.Pesquisa_Cep_1(cep);
			
			Console.WriteLine("							  {0}", c_return_1[6]);
            Console.WriteLine(new string('_', 75));
            Console.Write("\nCidade: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_1[1]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nUF: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_1[2]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nBairro: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_1[3]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nLogradouro: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_1[4]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nComplemento: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_1[5]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(new string('_', 75));
            Console.WriteLine("\n\nPress any button to continue...");
            Console.ReadKey();
			CEP_Menu();
        }
        else if (option == 2)
        {
            Console.Write("\nLOGRADOURO: ");
            Console.ForegroundColor = ConsoleColor.Green;
            log = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            var c_return_2 = CEP.Pesquisa_Cep_1(log);
			Console.WriteLine(new string('_', 75));
            Console.Write("\nCidade: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_2[1]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nUF: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_2[2]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nBairro: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_2[3]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nCEP: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_2[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nComplemento: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c_return_2[5]);
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(new string('_', 75));
            Console.WriteLine("\n\nPress any button to continue...");
            Console.ReadKey();
			CEP_Menu();
			
        }
        else if (option  == 3)
        {
            Main();
        }
        else
        {
            CEP_Menu();
        }
    }
    public static void Fast_Search()
    {
        // Usando a classe XmlTextReader 
        XmlTextReader ceps = new XmlTextReader(".\\ceps.xml");

		//variáveis
        string cep = "", cidade = "", uf = "", bairro = "", logradouro = "", complemento = "";
		string search = "";
		
		//Variaveis de acesso rápido
		List<string> l_cep = new List<string>();
		List<string> l_cidade = new List<string>();
		List<string> l_uf = new List<string>();
		List<string> l_bairro = new List<string>();
		List<string> l_logradouro = new List<string>();
		List<string> l_complemento = new List<string>();

		string title4 = @"

	    ______           __     _____                      __  
	   / ____/___ ______/ /_   / ___/___  ____ ___________/ /_ 
	  / /_  / __ `/ ___/ __/   \__ \/ _ \/ __ `/ ___/ ___/ __ \
	 / __/ / /_/ (__  ) /_    ___/ /  __/ /_/ / /  / /__/ / / /
	/_/    \__,_/____/\__/   /____/\___/\__,_/_/   \___/_/ /_/ 
															   

		";
		
		
		Console.WriteLine("\nCarregando arquivos na memória...");
		
		//Carregar arquivos na memoria
        while (ceps.Read())
        {
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cep")
                cep = (ceps.ReadString());
				l_cep.Add(cep);
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cidade")
                cidade = (ceps.ReadString());
				l_cidade.Add(cidade);
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "uf")
                uf = (ceps.ReadString());
				l_uf.Add(uf);
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "bairro")
                bairro = (ceps.ReadString());
				l_bairro.Add(bairro);
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "logradouro")
                logradouro = (ceps.ReadString());
				l_logradouro.Add(logradouro);
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "complemento")
                complemento = (ceps.ReadString());
				l_complemento.Add(complemento);
				
        } // Fim While

		while(true)
		{
			Console.Clear();
			Console.WriteLine(new string(':', 75));
			Console.WriteLine(title4);
			Console.WriteLine(new string(':', 75));		
			Console.Write("\nCEP: ");
			search = Console.ReadLine();
			
			if(search == "0")
			{
				break;
			}
			
			
			DateTime time_af = DateTime.Now;
			var idx = l_cep.LastIndexOf(search);
			DateTime time_bf = DateTime.Now;
			TimeSpan time_t = time_bf.Subtract(time_af);

			
			Console.WriteLine(new string('_', 75));
			Console.Write("\nCidade: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(l_cidade[idx]);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nUF: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(l_uf[idx]);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nBairro: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(l_bairro[idx]);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nCEP: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(l_cep[idx]);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\nComplemento: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(l_complemento[idx]);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(new string('_', 75));
			
			Console.ForegroundColor = ConsoleColor.Cyan,;
			Console.WriteLine("\n	                      "+time_t);
			Console.ForegroundColor = ConsoleColor.Gray;
			
			Console.WriteLine("\n\nPress any button to continue...");
			Console.ReadKey();
		}
		Fast_Search();
    }
}
//Pesquisa do arquivo mega.xml
public class Mega
{
    public static string[] Pesquisa_Mega_1(string search)
    {
        // Usando a classe XmlTextReader 
        XmlTextReader megasena = new XmlTextReader(".\\megasena.xml");

        string concurso = "", data = "",
        d1 = "", d2 = "", d3 = "", d4 = "", d5 = "", d6 = "";

        while (megasena.Read())
        {
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "concurso")
                concurso = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "data_sorteio")
                data = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d1")
                d1 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d2")
                d2 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d3")
                d3 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d4")
                d4 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d5")
                d5 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d6")
            {
                d6 = (megasena.ReadString());

                if (search == concurso)
                {
                    megasena.Close();
                    string[] ret = new string[2];
                    string num = d1 + " " + d2 + " " + d3 + " " + d4 + " " + d5 + " " + d6 + " ";
                    ret[0] = num;
                    ret[1] = data;
                    return ret;
                }
            }
        } // Fim While
        return new string[2];
    }

    public static string[] Pesquisa_Mega_2(string search)
    {
        // Usando a classe XmlTextReader 
        XmlTextReader megasena = new XmlTextReader(".\\megasena.xml");

        string concurso = "", data_sorteio = "", d1 = "",
        d2 = "", d3 = "", d4 = "", d5 = "", d6 = "";

        while (megasena.Read())
        {
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "concurso")
                concurso = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "data_sorteio")
                data_sorteio = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d1")
                d1 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d2")
                d2 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d3")
                d3 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d4")
                d4 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d5")
                d5 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d6")
            {
                d6 = (megasena.ReadString());

                if (search == data_sorteio)
                {
                    megasena.Close();
                    string[] ret = new string[2];
                    string num = d1 + " " + d2 + " " + d3 + " " + d4 + " " + d5 + " " + d6 + " ";
                    ret[0] = num;
                    ret[1] = concurso;
                    return ret;
                }
            }
        }
        return new string[2];
    }

    public static int[] Pesquisa_Mega_3()
    {
        //Usando a classe XmlTextReader 
        XmlTextReader megasena = new XmlTextReader(".\\megasena.xml");

        string concurso = "", data_sorteio = "", d1 = "",
        d2 = "", d3 = "", d4 = "", d5 = "", d6 = "";

        int q1 = 0, q2 = 0, q3 = 0, q4 = 0, q5 = 0, q6 = 0, q7 = 0, q8 = 0, q9 = 0, q10 = 0;
        int q11 = 0, q12 = 0, q13 = 0, q14 = 0, q15 = 0, q16 = 0, q17 = 0, q18 = 0, q19 = 0, q20 = 0;
        int q21 = 0, q22 = 0, q23 = 0, q24 = 0, q25 = 0, q26 = 0, q27 = 0, q28 = 0, q29 = 0, q30 = 0;
        int q31 = 0, q32 = 0, q33 = 0, q34 = 0, q35 = 0, q36 = 0, q37 = 0, q38 = 0, q39 = 0, q40 = 0;
        int q41 = 0, q42 = 0, q43 = 0, q44 = 0, q45 = 0, q46 = 0, q47 = 0, q48 = 0, q49 = 0, q50 = 0;
        int q51 = 0, q52 = 0, q53 = 0, q54 = 0, q55 = 0, q56 = 0, q57 = 0, q58 = 0, q59 = 0, q60 = 0;


        while (megasena.Read())
        {
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "concurso")
                concurso = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "data_sorteio")
                data_sorteio = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d1")
                d1 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d2")
                d2 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d3")
                d3 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d4")
                d4 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d5")
                d5 = (megasena.ReadString());
            if (megasena.NodeType == XmlNodeType.Element && megasena.Name == "d6")
            {
                d6 = (megasena.ReadString());


                if (d1 == "1" || d2 == "1" || d3 == "1" || d4 == "1" || d5 == "1" || d6 == "1") q1++;
                if (d1 == "2" || d2 == "2" || d3 == "2" || d4 == "2" || d5 == "2" || d6 == "2") q2++;
                if (d1 == "3" || d2 == "3" || d3 == "3" || d4 == "3" || d5 == "3" || d6 == "3") q3++;
                if (d1 == "4" || d2 == "4" || d3 == "4" || d4 == "4" || d5 == "4" || d6 == "4") q4++;
                if (d1 == "5" || d2 == "5" || d3 == "5" || d4 == "5" || d5 == "5" || d6 == "5") q5++;
                if (d1 == "6" || d2 == "6" || d3 == "6" || d4 == "6" || d5 == "6" || d6 == "6") q6++;
                if (d1 == "7" || d2 == "7" || d3 == "7" || d4 == "7" || d5 == "7" || d6 == "7") q7++;
                if (d1 == "8" || d2 == "8" || d3 == "8" || d4 == "8" || d5 == "8" || d6 == "8") q8++;
                if (d1 == "9" || d2 == "9" || d3 == "9" || d4 == "9" || d5 == "9" || d6 == "9") q9++;
                if (d1 == "10" || d2 == "10" || d3 == "10" || d4 == "10" || d5 == "10" || d6 == "10") q10++;
                if (d1 == "11" || d2 == "11" || d3 == "11" || d4 == "11" || d5 == "11" || d6 == "11") q11++;
                if (d1 == "12" || d2 == "12" || d3 == "12" || d4 == "12" || d5 == "12" || d6 == "12") q12++;
                if (d1 == "13" || d2 == "13" || d3 == "13" || d4 == "13" || d5 == "13" || d6 == "13") q13++;
                if (d1 == "14" || d2 == "14" || d3 == "14" || d4 == "14" || d5 == "14" || d6 == "14") q14++;
                if (d1 == "15" || d2 == "15" || d3 == "15" || d4 == "15" || d5 == "15" || d6 == "15") q15++;
                if (d1 == "16" || d2 == "16" || d3 == "16" || d4 == "16" || d5 == "16" || d6 == "16") q16++;
                if (d1 == "17" || d2 == "17" || d3 == "17" || d4 == "17" || d5 == "17" || d6 == "17") q17++;
                if (d1 == "18" || d2 == "18" || d3 == "18" || d4 == "18" || d5 == "18" || d6 == "18") q18++;
                if (d1 == "19" || d2 == "19" || d3 == "19" || d4 == "19" || d5 == "19" || d6 == "19") q19++;
                if (d1 == "20" || d2 == "20" || d3 == "20" || d4 == "20" || d5 == "20" || d6 == "20") q20++;
                if (d1 == "21" || d2 == "21" || d3 == "21" || d4 == "21" || d5 == "21" || d6 == "21") q21++;
                if (d1 == "22" || d2 == "22" || d3 == "22" || d4 == "22" || d5 == "22" || d6 == "22") q22++;
                if (d1 == "23" || d2 == "23" || d3 == "23" || d4 == "23" || d5 == "23" || d6 == "23") q23++;
                if (d1 == "24" || d2 == "24" || d3 == "24" || d4 == "24" || d5 == "24" || d6 == "24") q24++;
                if (d1 == "25" || d2 == "25" || d3 == "25" || d4 == "25" || d5 == "25" || d6 == "25") q25++;
                if (d1 == "26" || d2 == "26" || d3 == "26" || d4 == "26" || d5 == "26" || d6 == "26") q26++;
                if (d1 == "27" || d2 == "27" || d3 == "27" || d4 == "27" || d5 == "27" || d6 == "27") q27++;
                if (d1 == "28" || d2 == "28" || d3 == "28" || d4 == "28" || d5 == "28" || d6 == "28") q28++;
                if (d1 == "29" || d2 == "29" || d3 == "29" || d4 == "29" || d5 == "29" || d6 == "29") q29++;
                if (d1 == "30" || d2 == "30" || d3 == "30" || d4 == "30" || d5 == "30" || d6 == "30") q30++;
                if (d1 == "31" || d2 == "31" || d3 == "31" || d4 == "31" || d5 == "31" || d6 == "31") q31++;
                if (d1 == "32" || d2 == "32" || d3 == "32" || d4 == "32" || d5 == "32" || d6 == "32") q32++;
                if (d1 == "33" || d2 == "33" || d3 == "33" || d4 == "33" || d5 == "33" || d6 == "33") q33++;
                if (d1 == "34" || d2 == "34" || d3 == "34" || d4 == "34" || d5 == "34" || d6 == "34") q34++;
                if (d1 == "35" || d2 == "35" || d3 == "35" || d4 == "35" || d5 == "35" || d6 == "35") q35++;
                if (d1 == "36" || d2 == "36" || d3 == "36" || d4 == "36" || d5 == "36" || d6 == "36") q36++;
                if (d1 == "37" || d2 == "37" || d3 == "37" || d4 == "37" || d5 == "37" || d6 == "37") q37++;
                if (d1 == "38" || d2 == "38" || d3 == "38" || d4 == "38" || d5 == "38" || d6 == "38") q38++;
                if (d1 == "39" || d2 == "39" || d3 == "39" || d4 == "39" || d5 == "39" || d6 == "39") q39++;
                if (d1 == "40" || d2 == "40" || d3 == "40" || d4 == "40" || d5 == "40" || d6 == "40") q40++;
                if (d1 == "41" || d2 == "41" || d3 == "41" || d4 == "41" || d5 == "41" || d6 == "41") q41++;
                if (d1 == "42" || d2 == "42" || d3 == "42" || d4 == "42" || d5 == "42" || d6 == "42") q42++;
                if (d1 == "43" || d2 == "43" || d3 == "43" || d4 == "43" || d5 == "43" || d6 == "43") q43++;
                if (d1 == "44" || d2 == "44" || d3 == "44" || d4 == "44" || d5 == "44" || d6 == "44") q44++;
                if (d1 == "45" || d2 == "45" || d3 == "45" || d4 == "45" || d5 == "45" || d6 == "45") q45++;
                if (d1 == "46" || d2 == "46" || d3 == "46" || d4 == "46" || d5 == "46" || d6 == "46") q46++;
                if (d1 == "47" || d2 == "47" || d3 == "47" || d4 == "47" || d5 == "47" || d6 == "47") q47++;
                if (d1 == "48" || d2 == "48" || d3 == "48" || d4 == "48" || d5 == "48" || d6 == "48") q48++;
                if (d1 == "49" || d2 == "49" || d3 == "49" || d4 == "49" || d5 == "49" || d6 == "49") q49++;
                if (d1 == "50" || d2 == "50" || d3 == "50" || d4 == "50" || d5 == "50" || d6 == "50") q50++;
                if (d1 == "51" || d2 == "51" || d3 == "51" || d4 == "51" || d5 == "51" || d6 == "51") q51++;
                if (d1 == "52" || d2 == "52" || d3 == "52" || d4 == "52" || d5 == "52" || d6 == "52") q52++;
                if (d1 == "53" || d2 == "53" || d3 == "53" || d4 == "53" || d5 == "53" || d6 == "53") q53++;
                if (d1 == "54" || d2 == "54" || d3 == "54" || d4 == "54" || d5 == "54" || d6 == "54") q54++;
                if (d1 == "55" || d2 == "55" || d3 == "55" || d4 == "55" || d5 == "55" || d6 == "55") q55++;
                if (d1 == "56" || d2 == "56" || d3 == "56" || d4 == "56" || d5 == "56" || d6 == "56") q56++;
                if (d1 == "57" || d2 == "57" || d3 == "57" || d4 == "57" || d5 == "57" || d6 == "57") q57++;
                if (d1 == "58" || d2 == "58" || d3 == "58" || d4 == "58" || d5 == "58" || d6 == "58") q58++;
                if (d1 == "59" || d2 == "59" || d3 == "59" || d4 == "59" || d5 == "59" || d6 == "59") q59++;
                if (d1 == "60" || d2 == "60" || d3 == "60" || d4 == "60" || d5 == "60" || d6 == "60") q60++;
            }
        }
        megasena.Close();
        int[] ret = new int[60] { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42, q43, q44, q45, q46, q47, q48, q49, q50, q51, q52, q53, q54, q55, q56, q57, q58, q59, q60 };
        return ret;
    }
}

//Pesquisa do arquivo cep.xml
public class CEP
{
    public static string[] Pesquisa_Cep_1(string search)
    {
        // Usando a classe XmlTextReader 
        XmlTextReader ceps = new XmlTextReader(".\\ceps.xml");

        string cep = "", cidade = "", uf = "", bairro = "", logradouro = "", complemento = "";
		
		DateTime time_af = DateTime.Now;
        while (ceps.Read())
        {
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cep")
                cep = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cidade")
                cidade = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "uf")
                uf = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "bairro")
                bairro = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "logradouro")
                logradouro = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "complemento")
            {
                complemento = (ceps.ReadString());

                if (search == cep)
                {
					DateTime time_bf = DateTime.Now;
					TimeSpan time_t = time_bf.Subtract(time_af);
                    ceps.Close();
                    string[] ret = new string[7] {cep,cidade, uf, bairro, logradouro, complemento, Convert.ToString(time_t)};
                    return ret;
                }
            }
        } // Fim While
        return new string[7];
    }

    public static string[] Pesquisa_Cep_2(string search)
    {
        // Usando a classe XmlTextReader 
        XmlTextReader ceps = new XmlTextReader(".\\ceps.xml");

        string cep = "", cidade = "", uf = "", bairro = "", logradouro = "", complemento = "";

		DateTime time_af = DateTime.Now;
        while (ceps.Read())
        {
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cep")
                cep = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "cidade")
                cidade = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "uf")
                uf = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "bairro")
                bairro = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "logradouro")
                logradouro = (ceps.ReadString());
            if (ceps.NodeType == XmlNodeType.Element && ceps.Name == "complemento")
            {
                complemento = (ceps.ReadString());

                if (search == logradouro)
				{	
					DateTime time_bf = DateTime.Now;
					TimeSpan time_t = time_bf.Subtract(time_af);
                    ceps.Close();
                    string[] ret = new string[7] {cep,cidade, uf, bairro, logradouro, complemento, Convert.ToString(time_t)};
                    return ret;
                }
            }
        } // Fim While
        return new string[7];
    }
	
}
