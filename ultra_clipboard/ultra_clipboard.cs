using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class ultra_clipboard : System.ServiceProcess.ServiceBase  
{
       public ultra_clipboard() 
	{
		this.ServiceName = "ultra_clipboard";
		this.CanStop = true;
		this.CanPauseAndContinue = true;
		this.AutoLog = true;
	}

       public static void Main()
       {
           System.ServiceProcess.ServiceBase.Run(new ultra_clipboard());
       }

       protected override void OnStart(string[] args)
       {
           string lines = "First line.\r\nSecond line.\r\nThird line.";

           // Write the string to a file.
           System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
           file.WriteLine(lines);

           file.Close();
       }
}

 
