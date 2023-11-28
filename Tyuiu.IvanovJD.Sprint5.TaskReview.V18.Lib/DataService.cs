using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IvanovJD.Sprint5.TaskReview.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile =  @"C:\DataSprint5\OutPutDataFileTask7V18.txt";


            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'н' )
                        {
                            strLine += "нн";
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}