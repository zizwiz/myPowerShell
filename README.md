# myPowerShell
A C# .Net Winform app to run Powershell commands through, please see help file in the app for more detailed info on teh app and how it works. 

1.	Introduction 
For me it all started when I got code down from GitHub and could not compile it. When you download from the cloud Win10 puts a flag on some types of files like .resx that blocks them. This is picked up by VS and it will not allow the code to compile. I then had to manually go through the files unblocking each as required. I looked for a method I could use in an app to do this for me. I then saw that I could do this in Powershell, this is the story of how I achieved that.

2.	What is Powershell
Windows PowerShell 1.0 was launched in November 2006. It is a powerful command line shell for Windows. On Unix/Linux you have shells such as csh and bash. Powershell in some ways has more capabilities than them as it can read and write objects, as opposed to conventional shells that can only process strings of text. PowerShell runs on the .NET platform, the objects that are used are .NET objects, which makes it an ideal scripting language for .NET programs.

3.	What is a cmdlet
A cmdlet or "Command let" is a lightweight command used in the Windows PowerShell environment. The Windows PowerShell runtime invokes these cmdlets at command prompt. You can create and invoke them programmatically through Windows PowerShell APIs. An example of a cmdlet is Get-ChildItem.

3.1.	Alias
These are even shorter terms that you can associate with the cmdlet. In early versions of Powershell there were not many inbuilt aliases, so you had to tell Powershell what you had chosen. Today there are many inbuild aliases and the choice of using the cmdlet or its alias is up to the user. Many aliases have been chosen for those more familiar with Windows batch commands and some for those more familiar with Linux. You can as mentioned earlier still create your own.

e.g. The cmdlet Get-ChildItem can be shortened to its alias dir which if you are a windows user you may be more familiar with or ls if you are more familiar with Unix/Linux commands as we see in the following: 

•	Get-ChildItem -Path “directory path” -Recurse | Unblock-File

Can be written as

•	dir -Path “directory path” -Recurse | Unblock-File

or

•	ls -Path “directory path” -Recurse | Unblock-File

4.	Cmdlet help
I found that when I asked Powershell to supply help for a particular cmdlet that there was nothing available. This is strange as there should be and then I found that you can update the help for the cmdlets by using the following command

•	Update-Help

 After this update I was able to get help for the cmdlet. It may be wise to occasionally just update your help.

5.	The myPowershell app
I decided that I would investigate making an app to help me run Powershell commands. By doing this it would give me a better understanding of the deeper level commands and structures. As with a lot of apps today I found someone had started to make one and I used this as the basis for the one I would create. The original can be found at https://www.codeproject.com/Articles/18409/Asynchronously-Execute-PowerShell-Scripts-from-C 

I started my app from the beginning but did make the UI similar as I liked it and I did use some code from the original. I did find that the original was made with .Net v2.0 and I was using .Net v4.8. This means that many items do not work the same way. By the time I had worked out how to do a specific topic in v4.8 I found had to write the original in a different way so much of the code is written by me while studying how the original was written. Once I had the basics working, I started to look at making the app work the way I wanted it to work these will be detailed later.

5.1.	Nuget Packages required.
The first thing I found I need was the Powershell Reference assemblies and luckily this is available as a Nuget package which I installed.

 

5.2.	The UI
I wanted to make it look similar to the original, so I have two windows. One the shows the script and another the result. The result window can change from a RickTextBox to a GridView depending on what is likely to be returned. I am still working on understanding how to format what is returned. 

I wanted to pick up the list of scripts I could use from a folder. This will allow the user to write scripts and save them for reuse. If you do add new scripts to the folder then you can either restart the app to pick them up or click on the “refresh” button. The refresh button will clear both windows and reinitialise the list from the script folder.

The Text Only tick box is explained later.
  
 

In the original I saw that you could drag in a file and drop it into the Script window. I have added this feature to my app. It will allow you to drag a txt file and then will parse the text file and write the contents into the Script window.  

The drop down with the list of scripts in will always start on “User_Defined”. When in this mode you will be able to write into the script window from the keyboard your own script and then press the “Start Script” button to run it. 

5.3.	Scripts
The script naming convention is important. I use the following but will expand it as required. The name has a prefix, reading it LtoR the first part before the underscore.

Prefix	Meaning
config	Used to configure the Powershell environment.
info	These mostly bring back info about the PC you are on. 
operators	Demonstrate how to use some mathematical operators.
prog	Demonstrate how to use some programming features like loops.
util	Utilities which you may write to do a specific task.

This prefix is used by the app to determine how the result should be displayed. I am still learning how to do this section but so far, I know that those prefixed with “info” will need to use the data grid as there return is a PSObject containing many PSPropertyInfo. It is the property info that we will want to show in the Gridview and not the richtextbox so we need to switch the one that is shown and use. 

You will also note the Tickbox called “Text Only”. When Ticked the returning info will be displayed in a RichTextBox and when unticked it will be displayed in the Gridview. 


If I need more ways to display the data in the future then I will add more choices here. When you choose a script with Info prefix then the box is automatically unticked and when you choose another then the box will be ticked. When using “User_Defined” scripts you will need to do this manually for your script.
