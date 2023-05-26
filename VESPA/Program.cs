using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.IO;

namespace VESPA
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////pulse/////////////////////////////////////////////////////////////////////////////////////

            // Specify the target command for the shortcut
            string targetCommand = @"%USERPROFILE%\anaconda3\Scripts\activate.bat %USERPROFILE%\anaconda3\envs\python37 && python %USERPROFILE%\anaconda3\envs\python37\Lib\site-packages\vespa\pulse\main.py && exit";

            // Specify the shortcut file path
             string userProfileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Specify the shortcut file path
            string shortcutFilePath = Path.Combine(userProfileDirectory, "Desktop", "VESPA-Pulse.lnk");

            // Create a new shortcut object
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutFilePath);

            // Set the target command for the shortcut
            shortcut.TargetPath = @"%windir%\System32\cmd.exe";
            shortcut.Arguments = "/k " + targetCommand;
            shortcut.Description = "VESPA Pulse Shortcut";
            Directory.CreateDirectory(Path.GetDirectoryName(shortcutFilePath));
            // Save the shortcut
            shortcut.Save();

            // Display success message
            Console.WriteLine("Shortcut: created successfully!");
            Console.WriteLine(shortcutFilePath);
            Console.WriteLine("created successfully!");

            ///////////////////////////////////////////////////////////////////////////simulation/////////////////////////////////////////////////////////////////////////////////////
            // Specify the target command for the shortcut
            targetCommand = @"%USERPROFILE%\anaconda3\Scripts\activate.bat %USERPROFILE%\anaconda3\envs\python37 && python %USERPROFILE%\anaconda3\envs\python37\Lib\site-packages\vespa\simulation\main.py && exit";

            // Specify the shortcut file path
              userProfileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Specify the shortcut file path
              shortcutFilePath = Path.Combine(userProfileDirectory, "Desktop", "VESPA-Simulation.lnk");

            // Create a new shortcut object
              shell = new WshShell();
              shortcut = (IWshShortcut)shell.CreateShortcut(shortcutFilePath);

            // Set the target command for the shortcut
            shortcut.TargetPath = @"%windir%\System32\cmd.exe";
            shortcut.Arguments = "/k " + targetCommand;
            shortcut.Description = "VESPA Pulse Shortcut";
            Directory.CreateDirectory(Path.GetDirectoryName(shortcutFilePath));
            // Save the shortcut
            shortcut.Save();

            // Display success message
            Console.WriteLine("Shortcut: created successfully!");
            Console.WriteLine(shortcutFilePath);
            Console.WriteLine("created successfully!");

            ///////////////////////////////////////////////////////////////////////////Analysis/////////////////////////////////////////////////////////////////////////////////////
            // Specify the target command for the shortcut
            targetCommand = @"%USERPROFILE%\anaconda3\Scripts\activate.bat %USERPROFILE%\anaconda3\envs\python37 && python %USERPROFILE%\anaconda3\envs\python37\Lib\site-packages\vespa\analysis\main.py && exit";

            // Specify the shortcut file path
            userProfileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Specify the shortcut file path
            shortcutFilePath = Path.Combine(userProfileDirectory, "Desktop", "VESPA-analysis.lnk");

            // Create a new shortcut object
            shell = new WshShell();
            shortcut = (IWshShortcut)shell.CreateShortcut(shortcutFilePath);

            // Set the target command for the shortcut
            shortcut.TargetPath = @"%windir%\System32\cmd.exe";
            shortcut.Arguments = "/k " + targetCommand;
            shortcut.Description = "VESPA Pulse Shortcut";
            Directory.CreateDirectory(Path.GetDirectoryName(shortcutFilePath));
            // Save the shortcut
            shortcut.Save();

            // Display success message
            Console.WriteLine("Shortcut: created successfully!");
            Console.WriteLine(shortcutFilePath);
            Console.WriteLine("created successfully!");

            ///////////////////////////////////////////////////////////////////////////datasim/////////////////////////////////////////////////////////////////////////////////////
            // Specify the target command for the shortcut
            targetCommand = @"%USERPROFILE%\anaconda3\Scripts\activate.bat %USERPROFILE%\anaconda3\envs\python37 && python %USERPROFILE%\anaconda3\envs\python37\Lib\site-packages\vespa\datasim\main.py && exit";

            // Specify the shortcut file path
            userProfileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Specify the shortcut file path
            shortcutFilePath = Path.Combine(userProfileDirectory, "Desktop", "VESPA-datasim.lnk");

            // Create a new shortcut object
            shell = new WshShell();
            shortcut = (IWshShortcut)shell.CreateShortcut(shortcutFilePath);

            // Set the target command for the shortcut
            shortcut.TargetPath = @"%windir%\System32\cmd.exe";
            shortcut.Arguments = "/k " + targetCommand;
            shortcut.Description = "VESPA Pulse Shortcut";
            Directory.CreateDirectory(Path.GetDirectoryName(shortcutFilePath));
            // Save the shortcut
            shortcut.Save();

            // Display success message
            Console.WriteLine("Shortcut: created successfully!");
            Console.WriteLine(shortcutFilePath);
            Console.WriteLine("created successfully!");


            Console.ReadLine();
        }
    }
}
