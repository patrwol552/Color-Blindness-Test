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
        
        public void CreateOptions(List<string> tmp, List<string> namePng)
        {
            var plateString = new List<string>();
            string[] patchString = System.IO.Directory.GetFiles(@"C:\studia\pum projekt\WpfApplication1\WpfApplication1\Plates\");
            foreach (var item in patchString)
            {
                var containsPng = (item.Split('\\')[6]);
                namePng.Add(containsPng.ToString());
                var temp = (containsPng.Split('-'));
                tmp.Add(temp[1]);
                tmp.Add(temp[2]);
                tmp.Add(temp[3]);
                
            }

        }               
    }
}
