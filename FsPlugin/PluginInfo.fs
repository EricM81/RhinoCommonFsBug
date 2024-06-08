namespace FsPlugin

open Rhino.PlugIns
open System.Drawing


type MyPlugin() as this = 
    inherit PlugIn()
    static let mutable instance = null
    
    do  
        instance <- this
    
    
    /////<summary>Gets the only instance of the MyRhinoPlugin1Plugin plug-in.</summary>
    //public static MyRhinoPlugin1Plugin Instance { get; private set; }
    static member val Instance = instance   
    
    
    //// You can override methods here to change the plug-in behavior on
    // loading and shut down, add options pages to the Rhino _Option command
    // and maintain plug-in wide options in a document.
    override this.LoadTime = PlugInLoadTime.AtStartup