using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApplication1
{
    class Answers
    {
        
        public void CreateOptions(List<string> answersList, List<string> namePng)
        {
            
            string[] patchString = System.IO.Directory.GetFiles(@"C:\studia\pum projekt\WpfApplication1\WpfApplication1\Plates\");
            foreach (var item in patchString)
            {
                var fullPath = (item.Split('\\')[6]);
                namePng.Add(fullPath.ToString());
                var splited = (fullPath.Split('-'));
                answersList.Add(splited[1]);
                answersList.Add(splited[2]);
                answersList.Add(splited[3]);
                
            }

        }               
    }
}
