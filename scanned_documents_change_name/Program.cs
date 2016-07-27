using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace scanned_documents_change_name
{
    class Program
    {
        static void Main(string[] args)
        {
            //open folder in 

            //open folder out 

            //iterate through all files in in

            //read name

            //convert name

            //save file as new name in out


            string[] input_file_paths = Directory.GetFiles(@"in");//get list of input files

            Directory.CreateDirectory("out");//create output folder

            foreach (string file_path_name in input_file_paths)
            {
                Console.WriteLine("Input name: " + file_path_name + " Output name: " + file_path_name);

            }




        }
    }
}
