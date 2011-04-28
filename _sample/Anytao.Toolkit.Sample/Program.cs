using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anytao.Toolkit.AtExecutor;

namespace Anytao.Toolkit.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IATService service = new ATService();
            service.DoAchieve(1);
        }
    }
}
