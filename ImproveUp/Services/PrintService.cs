using System;

namespace ImproveUp.Services
{
    using Interfaces;

    public class PrintService: IPrintableService {

        public void print(IPatternInfo item) {
             Console.WriteLine("" + item.name + "->" + item.description);            
        }


    }

}