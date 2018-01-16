using AppKit;
using Foundation;
using System;
using System.Collections.Generic;

namespace ImproveUp
{
    using Interfaces;
    using Models;
    using Services;


    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {

        public Func<int> function;
        public List<IPatternInfo> patterns = new List<IPatternInfo>();

        public AppDelegate()
        {
            // title = General Responsibility Assignment Software Patterns
            var patternNames = new (string, string)[] { 
                ("Information expert",""),
                ("Creator",""),
                ("Controller",""),
                ("Low coupling",""),
                ("High cohession",""),
                ("Polymorphism","обрабатывать алтернативные варианты поведения на основе типа"),
                ("Pure fabrication",""),
                ("Indirection","Связь через интерфейсы"),
                ("Protected variations","Изменения в одной части не аффектили на измнения в дургой части")
            };

            foreach ((string, string) pattern in patternNames)
            {
                patterns.Add(new PatternInfo(pattern));
            }

        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            oldCode();
            printPatternsList();
                                   
        }

        protected void oldCode() {
            //Console.WriteLine("finish line");
            //var helper = MainHelper.getInstance();
            //helper.Run("privet");

            //var generic = new GenericUse<Int16>();
            //generic.Run(31337);

            //function = () => { 
            //    Console.WriteLine("Lambda function");
            //    return 31338; 
            //};

            //var result = function.Invoke();
            //Console.WriteLine(result);
        }

        protected void printPatternsList() 
        {
            foreach(IPatternInfo pattern in patterns) {
                var printablePattern = (PatternInfo)pattern;
                printablePattern.print(new PrintService());
            }
        }

    }
}
