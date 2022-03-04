using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Words
    {
        protected List<string> WordList { get; set; }

        protected string CurrentWord { get; set; } = "tests";

        public Words()
        {
            SetupWordList();
        }

        protected void SetupWordList()
        {
            WordList = new List<string>
            {
                "tests"
            };
        }
    }
}
