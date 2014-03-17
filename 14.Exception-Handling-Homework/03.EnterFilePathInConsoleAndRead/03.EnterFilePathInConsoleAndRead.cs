//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class EnterFilePathInConsoleAndReadProgram
{
    static string ReadAllText(string path)
    {
        string answer = File.ReadAllText(path);
        return answer;
    }
    static void Main()
    {
        string filePath = Console.ReadLine();
        string exceptionMessage = string.Empty;
        try
        {
            Console.WriteLine(ReadAllText(filePath));
        }
        catch (ArgumentNullException ex)
        {
            exceptionMessage=ex.Message;
        }
        catch (ArgumentException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (PathTooLongException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (DirectoryNotFoundException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (FileNotFoundException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (IOException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (UnauthorizedAccessException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (NotSupportedException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (SecurityException ex)
        {
            exceptionMessage = ex.Message;
        }
        catch (Exception ex)
        {
            exceptionMessage = ex.Message;
        }
        finally
        {
            if(exceptionMessage!=null)
            {
                Console.WriteLine(exceptionMessage);
            }
        }
    }
}