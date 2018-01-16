using AppKit;
using Foundation;
using System;

namespace ImproveUp
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {

        public Func<int> function;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Console.WriteLine("finish line");
            var helper = MainHelper.getInstance();
            helper.Run("privet");

            var generic = new GenericUse<Int16>();
            generic.Run(31337);

            function = () => { 
                Console.WriteLine("Lambda function");
                return 31338; 
            };

            var result = function.Invoke();
            Console.WriteLine(result);


                                   
        }

    }
}
