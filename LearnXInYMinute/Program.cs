// Single-line comments start with //
/*
Multi-line comments look like this
*/

/// <summary>
/// This is an XML documentation comment which can be used to generate external
/// documentation or provide context help within an IDE
/// </summary>
/// /// <param name="firstParam">This is some parameter documentation for firstParam</param>
/// <returns>Information on the returned value of a function</returns>

// Specify the namespaces this source code will be using
// The namespaces below are all part of the standard .NET Framework Class Library
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;
// But this one is not:
//using System.Data.Entity;
// In order to be able to use it, you need to add a dll reference
// This can be done with the NuGet package manager: `Install-Package EntityFramework`

// Namespaces define scope to organize code into "packages" or "modules"
// Using this code from another source file: using Learning.CSharp;
namespace LearnXInYMinute
{
    // Each .cs file should at least contain a class with the same name as the file.
    // You're allowed to do otherwise, but shouldn't for sanity.
    class CsReview
    {    
        static void Main(string[] args)
        {
            //Basic.Run();
            Class.Run();
        }

        ///////////////////////////////////////
        // CLASSES - see definitions at end of file
        ///////////////////////////////////////
        
    }
}
