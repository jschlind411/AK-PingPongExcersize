using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WooordleTests
{
    public class WordsTests
    {
        [Fact]
        public void Words_CanBeCreated_UsingDefaultConstructor()
        {
            Words words = new Words();

            Assert.NotNull(words);
        }

    }
}
