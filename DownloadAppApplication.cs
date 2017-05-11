using System;
using System.IO;
/// <summary>
/// This program will rename the contents of a directory to an incrementor and what you specify.
/// Copyright(C) 2017  Seth G. R. Herendeen
/// 
/// This program is free software; you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation; either version 2 of the License, or
/// (at your option) any later version.
/// 
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
/// GNU General Public License for more details.
/// 
/// You should have received a copy of the GNU General Public License along
/// with this program; if not, write to the Free Software Foundation, Inc.,
/// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
/// </summary>
namespace RenameAll
{
    class DownloadAppApplication
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">arg[1] is the path</param>
        static void Main(string[] args)
        {
            string path = "", valueToRename = "";
            Console.WriteLine("Written by Seth G. R. Herendeen");
            Console.Title = "Rename All";

            if (args.Length > 0)
            {
                if ((args[0] != "") || (args[0] != null)|| (args[1] != "") || (args[1] != null))
                {
                    path = args[0];
                    valueToRename = args[1];
                }
            }
            else if (args.Length < 0)
            {
                Console.WriteLine("ERR: Not enough arguments...");

                return;
            }
            else
            {
                Console.Write("Input file location:");
                path = Console.ReadLine();
                Console.Write("Input value to rename with:");
                valueToRename = Console.ReadLine();
            }

            string[] fileNameArray = Directory.GetFiles(path);
            if (!path.EndsWith(@"\"))
            {
                path += @"\";
            }
            for (int i = 0; i < fileNameArray.Length; i++)
            {
                Console.WriteLine(fileNameArray[i]);
            }

            Console.WriteLine("Now we rename...");

            for (int i = 0; i < fileNameArray.Length; i++)
            {
                File.Move(fileNameArray[i],path +  i + "_" +valueToRename);
                Console.WriteLine(fileNameArray[i]);
            }

        }
    }
}
