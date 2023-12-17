# ![Sophie's icon](.\Sophie.ico)Sophie - The Sophisticated Web Browser

## Sophie's Philosophy
### Sophisticated Functions
In the WWW world, functions that must be implemented are just only Back, GoForward, Reload, and Move.
Other functions are unnecessary for web browsers.

### Synthesizable Simple UI
I deployed UI elements where they should be. And you can customize its appearance by editing a XAML file.

### Small Program
Sophie just focus to browse the Web because this app is a web browser.
So this app doesn't implement other function like services of collecting user's information. 

## Compile
Please execute build.ps1.
You can also compile by using dotnet commandline tools. This repository contains a project file for .NET6.

## Execution
Please deploy Window.xaml in the same directory as Sophie.exe. You can customize the UI by editing a XAML file.

## Recommended settings
This app doesn't a have setting UI. I recommend that the following items be set.

### Internet Options
1. Open Internet Options.
2. Move to a Security tab and set the highest level.
 
### Rendering engine
1. Open Registory Editor.
2. Move to HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION .
3. Add a new REG_DWORD value that name is "Sophie.exe" and value is 0x2AF9. 

## Q&A
### Who is that girl on the icon?
Sophie-chan!

### Is this app related with Atelier Sophie?
N, No! I named this app Sophie from "Sophisticated"! 
I have never once said that "I love Sophie-chan very much!" !!
This app is not related with official Atelier series and KoeiTecmo.

### Why do you adopt IE's rendering engine?
This app focus to just display HTML files and doesn't care about appearance or dynamic contents and no need to adopt modern functions. So I just use IE's rendering engine that is one of OS component. If you don't like IE, please modify the program.