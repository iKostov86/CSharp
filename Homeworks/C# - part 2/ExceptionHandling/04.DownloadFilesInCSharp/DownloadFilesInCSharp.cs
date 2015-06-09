using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

class DownloadFilesInCSharp
{
    static void Main()
    {
        WebClient myWebClient = new WebClient();
        string remoteUri = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = null;

        try
        {
            //get FileName
            fileName = Path.GetFileName(remoteUri);

            if (!String.IsNullOrWhiteSpace(fileName))
            {
                string destination = Path.Combine(Application.StartupPath, fileName);
                destination = Path.Combine(@"D:\Users\Ivaylo\Desktop", fileName);

                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(remoteUri, destination);
            }
            else
            {
                Console.WriteLine("No valid web resource specified.");
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address is empty.");
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (myWebClient != null)
            {
                myWebClient.Dispose();
            }
        }
    }
}
