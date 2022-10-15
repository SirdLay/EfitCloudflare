using System.Net;
public class Effit
{

   static  List<string> subdomainips = new List<string>();
    static List<string> foundcf = new List<string>();

    public static string[] otheripsranges = new string[] { "103.21.244.0/24",
"103.22.200.0/23",
"103.22.203.0/24",
"103.81.228.0/24",
"104.16.0.0/12",
"104.16.0.0/20",
"104.16.112.0/20",
"104.16.128.0/20",
"104.16.144.0/20",
"104.16.160.0/20",
"104.16.16.0/20",
"104.16.176.0/20",
"104.16.192.0/20",
"104.16.208.0/20",
"104.16.224.0/20",
"104.16.240.0/20",
"104.16.32.0/20",
"104.16.48.0/20",
"104.16.64.0/20",
"104.16.80.0/20",
"104.16.96.0/20",
"104.17.0.0/20",
"104.17.112.0/20",
"104.17.128.0/20",
"104.17.144.0/20",
"104.17.160.0/20",
"104.17.16.0/20",
"104.17.176.0/20",
"104.17.192.0/20",
"104.17.208.0/20",
"104.17.224.0/20",
"104.17.240.0/20",
"104.17.32.0/20",
"104.17.48.0/20",
"104.17.64.0/20",
"104.17.80.0/20",
"104.17.96.0/20",
"104.18.0.0/20",
"104.18.112.0/20",
"104.18.128.0/20",
"104.18.144.0/20",
"104.18.160.0/20",
"104.18.16.0/20",
"104.18.176.0/20",
"104.18.192.0/20",
"104.18.208.0/20",
"104.18.224.0/20",
"104.18.240.0/20",
"104.18.32.0/19",
"104.18.32.0/20",
"104.18.32.0/24",
"104.18.33.0/24",
"104.18.34.0/24",
"104.18.35.0/24",
"104.18.36.0/24",
"104.18.37.0/24",
"104.18.38.0/24",
"104.18.39.0/24",
"104.18.40.0/24",
"104.18.41.0/24",
"104.18.42.0/24",
"104.18.43.0/24",
"104.18.44.0/24",
"104.18.45.0/24",
"104.18.46.0/24",
"104.18.47.0/24",
"104.18.48.0/24",
"104.18.49.0/24",
"104.18.50.0/24",
"104.18.51.0/24",
"104.18.52.0/24",
"104.18.53.0/24",
"104.18.54.0/24",
"104.18.55.0/24",
"104.18.56.0/24",
"104.18.57.0/24",
"104.18.58.0/24",
"104.18.59.0/24",
"104.18.60.0/24",
"104.18.61.0/24",
"104.18.62.0/24",
"104.18.63.0/24",
"104.18.64.0/20",
"104.18.80.0/20",
"104.18.96.0/20",
"104.19.0.0/20",
"104.19.112.0/20",
"104.19.128.0/20",
"104.19.144.0/20",
"104.19.160.0/20",
"104.19.16.0/20",
"104.19.176.0/20",
"104.19.192.0/20",
"104.19.208.0/20",
"104.19.224.0/20",
"104.19.240.0/20",
"104.19.32.0/20",
"104.19.48.0/20",
"104.19.64.0/20",
"104.21.0.0/20",
"172.67.128.0/20"};
    static string[] subs = { "www", "mail", "ftp", "localhost", "webmail", "pop", "ns1", "webdisk", "ns2", "cpanel", "whm", "autodiscover", "autoconfig", "m", "imap", "test", "ns", "blog", "pop3", "dev", "www2", "admin", "forum", "news", "vpn", "new", "mysql", "old", "lists", "support", "mobile", "mx", "static", "docs", "beta", "shop", "sql", "secure", "demo", "cp", "calendar", "wiki", "web", "media" };

    public static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Title = "EfitCloudflare v1.0 | Brought to you by Cyber-request.com";
        string art = @"
  ______  __ _ _    _____ _                 _  __ _
 |  ____|/ _(_) |  / ____| |               | |/ _| |
 | |__  | |_ _| |_| |    | | ___  _   _  __| | |_| | __ _ _ __ ___
 |  __| |  _| | __| |    | |/ _ \| | | |/ _` |  _| |/ _` | '__/ _ \
 | |____| | | | |_| |____| | (_) | |_| | (_| | | | | (_| | | |  __/
 |______|_| |_|\__|\_____|_|\___/ \__,_|\__,_|_| |_|\__,_|_|  \___|
                       
                        Created by Puddy.


";

        Console.Write(art);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Type the domain of the given website you want to resolve.");
        Console.Write("Website domain : ");
        string url = Console.ReadLine();


        Thread.Sleep(1000);
        //Console.Clear();
        url = url.ToLower();
        if (url.StartsWith("https://"))
        {
            url = url.Replace("https://", "");
        }
        if (url.StartsWith("http://"))
        {
            url = url.Replace("http://", "");
        }
        if (url.StartsWith("www."))
        {
            url = url.Replace("www.", "");
        }
        foreach (string s in subs)
        {
            try
            {
                string urlto = s + "." + url;
                var resp = Dns.GetHostEntry(urlto);
                if (!subdomainips.Contains(System.Convert.ToString(resp.AddressList[0])))
                {
                    subdomainips.Add(System.Convert.ToString(resp.AddressList[0]));
                }
            }
            catch (Exception e)
            {

            }

        }
        tester();

        
        if (subdomainips.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed to find hidden IP.");
        }
        Console.ReadKey();
        Console.Clear();
        foundcf.Clear();
        subdomainips.Clear();
        Main();
         
    }
    public static void tester() {
        foreach (string range in otheripsranges)
        {
            
            foreach (string ipaddy in subdomainips) {
                
                 var rangetest = IpRange.ParseOrDefault(range);
               
                if (rangetest.Contains(ipaddy))
                {
                    foundcf.Add(ipaddy);
                }

            }
        }

        foreach (string cfip in foundcf)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Cloudflare IP : " + cfip);
            subdomainips.Remove(cfip);
        }
        foreach (string found in subdomainips)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hidden IP : " + found);

        }
    }
}