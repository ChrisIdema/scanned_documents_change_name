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


        static string change_name(string s, DateTime d)
        {

            //return "test" + s;

            return "SCAN_" + d.ToString("yyyyMMdd_hhmmss") + Path.GetExtension(s);

        }

        static void Main(string[] args)
        {
            //open folder in 

            //open folder out 

            //iterate through all files in in

            //read name

            //convert name

            //save file as new name in out


            string[] input_file_paths = Directory.GetFiles( Directory.GetCurrentDirectory() );//get list of input files

           // Directory.CreateDirectory("out");//create output folder

            foreach (string file_path_name in input_file_paths)
            {

                if( 
                    (Path.GetExtension(file_path_name) == ".pdf")||
                    (Path.GetExtension(file_path_name) == ".png")||
                    (Path.GetExtension(file_path_name) == ".jpg")
                  //todo: add if it doesnt start with "SCAN_"
                  )
                {

                string output_name;



                output_name = "test" + file_path_name ;

                output_name = Path.Combine(Path.GetDirectoryName(file_path_name), change_name(Path.GetFileName(file_path_name), File.GetLastWriteTime(file_path_name)));

                //File.Copy(file_path_name, output_name);

                File.Move(file_path_name, output_name);


                Console.WriteLine("Input name: " + file_path_name + " Output name: " + output_name);

                }


            }




        }
    }
}
